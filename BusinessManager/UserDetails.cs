using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreRestApi.Models;

namespace DotNetCoreRestApi.BusinessManager
{
    public class UserDetails : IUserDetails
    {
        public IEnumerable<UserData> FetchUsers()
        {
            var users = new List<UserData>
            {
            new UserData{ID=0,Name="Jishnu",Email="abc@gmail.com",Password="1234",IsAdmin=true },
            new UserData { ID = 1, Name = "Jishnu1", Email = "abc1@gmail.com", Password = "1234", IsAdmin = false },
            new UserData{ ID = 2, Name = "Jishnu2", Email = "abc2@gmail.com", Password = "1234", IsAdmin = false }
            };
            return users;
        }

        public UserData GetUserById(int id)
        {
            return new UserData { ID = 0, Name = "Jishnu", Email = "abc@gmail.com", Password = "1234", IsAdmin = true };
        }
    }
}
