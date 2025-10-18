namespace DynamicProfileEndpoint.API.Data
{
    public class InMemoryDatabase
    {
        public static List<User> Profiles { get; set; } = new()
        {
             new User()
             {
                    Email = "oshinkoyamasturah@gmail.com",
                    Name = "Masturah Oshinkoya",
                    Stack = "Backend Developer"
             }
        };
    }
}
