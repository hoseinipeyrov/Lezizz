using CLezizz.Core.ApplicationService.Common.Models;
using System.Threading.Tasks;

namespace Lezizz.Core.ApplicationService.Common.Interfaces
{
    public interface IIdentityService
    {
        Task<string> GetUserNameAsync(string userId);

        Task<(Result Result, string UserId)> CreateUserAsync(string userName, string password);

        Task<Result> DeleteUserAsync(string userId);
    }
}
