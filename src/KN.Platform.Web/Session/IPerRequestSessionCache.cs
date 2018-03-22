using System.Threading.Tasks;
using KN.Platform.Sessions.Dto;

namespace KN.Platform.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
