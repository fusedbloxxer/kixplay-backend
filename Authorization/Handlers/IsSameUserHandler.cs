using KixPlay_Backend.Authorization.Requirements;
using Microsoft.AspNetCore.Authorization;

namespace KixPlay_Backend.Authorization.Handlers
{
    public class IsSameUserHandler : AuthorizationHandler<IsSameUserRequirement>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public IsSameUserHandler(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, IsSameUserRequirement requirement)
        {
            // Assert that the jwt contains an user identifier
            if (!context.User.HasClaim(claim => claim.Type.EndsWith("nameidentifier")))
                return Task.CompletedTask;

            // Extract the user identifier from the claims
            var claimUserId = context.User.Claims
                .First(claim => claim.Type.EndsWith("nameidentifier"))
                .Value;

            // Extract the user identifier from the route
            var routeParamData = _httpContextAccessor.HttpContext.GetRouteData();
            var requestUserId = routeParamData.Values["userId"].ToString();

            // Assert that both are the same
            // To provide access to the right owner
            if (requestUserId != claimUserId)
                return Task.CompletedTask;

            // Mark the requirement as being satisfied
            context.Succeed(requirement);
            return Task.CompletedTask;
        }
    }
}
