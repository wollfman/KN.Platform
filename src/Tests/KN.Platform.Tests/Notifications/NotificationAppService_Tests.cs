using System.Threading.Tasks;
using KN.Platform.Notifications;
using Shouldly;
using Xunit;

namespace KN.Platform.Tests.Notifications
{
    public class NotificationAppService_Tests : AppTestBase
    {
        private readonly INotificationAppService _notificationAppService;

        public NotificationAppService_Tests()
        {
            _notificationAppService = Resolve<INotificationAppService>();
        }

        [Fact]
        public async Task Test_ChangeNotificationSettings()
        {
            var settings = await _notificationAppService.GetNotificationSettings();
            settings.ReceiveNotifications.ShouldBe(true);
            settings.Notifications.Count.ShouldBeGreaterThan(0);
        }
    }
}
