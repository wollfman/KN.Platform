using Abp.Application.Services;
using KN.Platform.Tenants.Dashboard.Dto;

namespace KN.Platform.Tenants.Dashboard
{
    public interface ITenantDashboardAppService : IApplicationService
    {
        GetMemberActivityOutput GetMemberActivity();
    }
}
