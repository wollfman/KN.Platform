using System.Collections.Generic;
using Abp.Application.Services.Dto;
using KN.Platform.Authorization.Permissions.Dto;

namespace KN.Platform.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}