using Abp.Application.Services;
using Abp.Application.Services.Dto;
using KN.Platform.Authorization.Permissions.Dto;

namespace KN.Platform.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
