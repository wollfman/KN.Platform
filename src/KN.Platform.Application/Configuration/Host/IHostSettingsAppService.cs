using System.Threading.Tasks;
using Abp.Application.Services;
using KN.Platform.Configuration.Host.Dto;

namespace KN.Platform.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
