using DynamicProfileEndpoint.API.Data;



namespace DynamicProfileEndpoint.API.Services
    {
        public class UserServices
        {
            public List<User> GetUsers()
            {
                return InMemoryDatabase.Profiles;
            }
        }
    }



