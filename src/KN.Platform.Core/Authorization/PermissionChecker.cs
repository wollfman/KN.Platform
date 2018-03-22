using Abp.Authorization;
using KN.Platform.Authorization.Roles;
using KN.Platform.Authorization.Users;
using KN.Platform.MultiTenancy;

namespace KN.Platform.Authorization
{
    /// <summary>
    /// Implements <see cref="PermissionChecker"/>.
    /// </summary>
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
