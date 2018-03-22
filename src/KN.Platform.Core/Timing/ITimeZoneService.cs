using System.Threading.Tasks;
using Abp.Configuration;

namespace KN.Platform.Timing
{
    public interface ITimeZoneService
    {
        Task<string> GetDefaultTimezoneAsync(SettingScopes scope, int? tenantId);
    }
}
