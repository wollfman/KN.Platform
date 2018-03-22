using System.Threading.Tasks;
using Abp;
using Abp.Notifications;
using KN.Platform.Authorization.Users;
using KN.Platform.MultiTenancy;

namespace KN.Platform.Notifications
{
    public interface IAppNotifier
    {
        Task WelcomeToTheApplicationAsync(User user);

        Task NewUserRegisteredAsync(User user);

        Task NewTenantRegisteredAsync(Tenant tenant);

        Task SendMessageAsync(UserIdentifier user, string message, NotificationSeverity severity = NotificationSeverity.Info);
    }
}
