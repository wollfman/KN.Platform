﻿using System.Threading.Tasks;
using System.Web;
using Abp.Dependency;
using KN.Platform.Sessions;
using KN.Platform.Sessions.Dto;

namespace KN.Platform.Web.Session
{
    public class PerRequestSessionCache : IPerRequestSessionCache, ITransientDependency
    {
        private readonly ISessionAppService _sessionAppService;

        public PerRequestSessionCache(ISessionAppService sessionAppService)
        {
            _sessionAppService = sessionAppService;
        }

        public async Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync()
        {
            var httpContext = HttpContext.Current;
            if (httpContext == null)
            {
                return await _sessionAppService.GetCurrentLoginInformations();
            }

            var cachedValue = httpContext.Items["__PerRequestSessionCache"] as GetCurrentLoginInformationsOutput;
            if (cachedValue == null)
            {
                cachedValue = await _sessionAppService.GetCurrentLoginInformations();
                httpContext.Items["__PerRequestSessionCache"] = cachedValue;
            }

            return cachedValue;
        }
    }
}