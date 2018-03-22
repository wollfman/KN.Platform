using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using KN.Platform.Authorization.Users;

namespace KN.Platform.Configuration.Host.Dto
{
    public class SendTestEmailInput
    {
        [Required]
        [MaxLength(User.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }
    }
}