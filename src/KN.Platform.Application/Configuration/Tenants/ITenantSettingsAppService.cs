using System.Threading.Tasks;
using Abp.Application.Services;
using KN.Platform.Configuration.Tenants.Dto;

namespace KN.Platform.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
