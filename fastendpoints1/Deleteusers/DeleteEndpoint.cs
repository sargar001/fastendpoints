using FastEndpoints;
using webApplication.getusers;
using webApplication.Services;

namespace webApplication.Deleteusers
{
    public class DeleteEndpoint(UserService service): Endpoint<Deleterequest>
    {
        public override void Configure()
        {
            Delete("users");
            AllowAnonymous();
        }
      
        public override async Task HandleAsync(Deleterequest deleterequest, CancellationToken ct)
        {
            service.DeleteUser(deleterequest.Id);
            await SendOkAsync(deleterequest, ct);
        }
    }
}
