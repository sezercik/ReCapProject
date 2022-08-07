using Core.Business;
using Core.Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserService : IBaseService<User>
    {
        List<OperationClaim> GetClaims(User user);
        User GetByMail(string email);
    }
}
