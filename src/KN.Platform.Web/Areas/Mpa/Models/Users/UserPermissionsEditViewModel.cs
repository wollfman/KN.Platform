using Abp.AutoMapper;
using KN.Platform.Authorization.Users;
using KN.Platform.Authorization.Users.Dto;
using KN.Platform.Web.Areas.Mpa.Models.Common;

namespace KN.Platform.Web.Areas.Mpa.Models.Users
{
    [AutoMapFrom(typeof(GetUserPermissionsForEditOutput))]
    public class UserPermissionsEditViewModel : GetUserPermissionsForEditOutput, IPermissionsEditViewModel
    {
        public User User { get; private set; }

        public UserPermissionsEditViewModel(GetUserPermissionsForEditOutput output, User user)
        {
            User = user;
            output.MapTo(this);
        }
    }
}