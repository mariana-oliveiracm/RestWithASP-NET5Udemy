using RestWithASP_NET5Udemy.Data.VO;
using RestWithASP_NET5Udemy.Model;


namespace RestWithASP_NET5Udemy.Repository
{
    public interface IUserRepository
    {
        User ValidateCredentials(UserVO user);
        User ValidateCredentials(string userName);
        User RefreshUserInfo(User user);

        bool RevokeToken(string username);
    }
}
