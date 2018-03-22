using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace KN.Platform.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
