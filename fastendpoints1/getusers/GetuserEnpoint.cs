using FastEndpoints;
using webApplication.Services;

namespace webApplication.getusers
{
    public class GetuserEnpoint(UserService service): Endpoint<GetuserResponse>
    {
        public override void Configure()
        {

            Get("users");
            AllowAnonymous();
        }
        public override async Task HandleAsync(GetuserResponse response, CancellationToken ct )
        {
            var user = service.GetUsers();
            await SendOkAsync(user, ct);
           
        }
    }
}
