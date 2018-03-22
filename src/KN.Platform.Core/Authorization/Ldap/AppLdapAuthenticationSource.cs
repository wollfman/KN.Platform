using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using KN.Platform.Authorization.Users;
using KN.Platform.MultiTenancy;

namespace KN.Platform.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}
