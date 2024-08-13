using FastEndpoints;
using webApplication.DbContext;
using webApplication.Services;

namespace webApplication.createusers
{
    public class UserEndpoint(Data Dbcontext,UserService Uservice): Endpoint<UsersRequest>
    {
        
        public  override void Configure()
        {
            Post("users");
           // Get("users");
            AllowAnonymous();
        }
        public override async Task HandleAsync (UsersRequest us, CancellationToken ct)
        {
           var user= Uservice.createusers(us);
            await SendOkAsync(user,ct);

        }


    }
}
