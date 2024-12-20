namespace BreakingSRP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a UserRepository instance
            UserRepository userRepository = new UserRepository();

            // Create a couple of users
            User user1 = new User { Name = "Alice", Email = "alice@example.com" };
            User user2 = new User { Name = "Bob", Email = "bob@example.com" };

            // Save users to the repository
            userRepository.SaveUser(user1);
            userRepository.SaveUser(user2);

            // Retrieve all users and print them
            userRepository.PrintAllUsers();
        }
    }
}
