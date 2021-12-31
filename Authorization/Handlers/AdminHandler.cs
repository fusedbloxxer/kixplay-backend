using KixPlay_Backend.Authorization.Requirements;
using Microsoft.AspNetCore.Authorization;

namespace KixPlay_Backend.Authorization.Handlers
{
    public class AdminHandler : IAuthorizationHandler
    {
        public Task HandleAsync(AuthorizationHandlerContext context)
        {
            if (!context.User.IsInRole("Admin"))
                return Task.CompletedTask;

            var pendingRequirements = context.PendingRequirements.ToList();

            foreach (var requirement in pendingRequirements)
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
