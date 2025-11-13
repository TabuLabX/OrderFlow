using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace OrderFlow.Identity.Features.Auth.V1;

public static class AuthGroupExtensions
{
    public static RouteGroupBuilder MapAuthGroup(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.MapGroup("/api/v1.0/auth")
            .WithTags("Authentication")
            .WithOpenApi();
    }
}