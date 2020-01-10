using Microsoft.AspNetCore.Http;
using Lezizz.Core.ApplicationService.Common.Interfaces;
using System.Security.Claims;

namespace Lezizz.Presentation.Web.Services
{
    public class CurrentUserService : ICurrentUserService
    {
        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
        {
            UserId = httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);
        }

        public string UserId { get; }
    }
}
