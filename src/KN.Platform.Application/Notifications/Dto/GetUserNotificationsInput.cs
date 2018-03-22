using Abp.Notifications;
using KN.Platform.Dto;

namespace KN.Platform.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }
    }
}