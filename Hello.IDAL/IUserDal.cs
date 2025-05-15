using Hello.Model;

namespace Hello.IDAL
{
    public interface IUserDal
    {
        List<User> GetUserList();

        User GetUser(int userNo);

        bool SaveUser(User user);

    }
}
