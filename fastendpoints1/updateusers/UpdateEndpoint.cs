using FastEndpoints;
using webApplication.getusers;
using webApplication.Services;

namespace webApplication.updateusers
{
    public class UpdateEndpoint(UserService service): Endpoint<Updaterequest>
    {
        public override void Configure()
        {
            Put("users");
            AllowAnonymous();
        }

        public override async Task HandleAsync(Updaterequest request, CancellationToken ct)
        {
            var UpdatedUser = service.UpdateUser(request);
             await SendOkAsync(UpdatedUser, ct);
        }

    }
}
