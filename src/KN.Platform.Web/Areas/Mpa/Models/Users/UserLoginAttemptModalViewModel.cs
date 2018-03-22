using System.Collections.Generic;
using KN.Platform.Authorization.Users.Dto;

namespace KN.Platform.Web.Areas.Mpa.Models.Users
{
    public class UserLoginAttemptModalViewModel
    {
        public List<UserLoginAttemptDto> LoginAttempts { get; set; }
    }
}