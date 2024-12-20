namespace BreakingSRP;

public class UserRepository
{
    private List<User> _users = new List<User>();

    public void SaveUser(User user)
    {
        _users.Add(user);
    }

    public void PrintAllUsers()
    {
        foreach (var user in _users)
        {
            Console.WriteLine($"Namn: {user.Name}, Email: {user.Email}");
        }
    }
}
