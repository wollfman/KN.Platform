using System.Threading.Tasks;
using Abp.Application.Services;
using KN.Platform.Sessions.Dto;

namespace KN.Platform.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
