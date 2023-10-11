using MyRequest = Serene1.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<Serene1.Administration.UserRow>;
using MyRow = Serene1.Administration.UserRow;

namespace Serene1.Administration;
public interface IUserListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
{
    public UserListHandler(IRequestContext context)
         : base(context)
    {
    }
}