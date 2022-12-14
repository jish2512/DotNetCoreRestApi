using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreRestApi.Models;

namespace DotNetCoreRestApi.BusinessManager
{
    public interface IUserDetails
    {
        IEnumerable<UserData> FetchUsers();
        UserData GetUserById(int id);
        void CreateUserData(UserData user);
        bool SaveChanges();
        void UpdateUserData(UserData user);
        void DeleteUserData(UserData user);
        void DeleleAllUsers();
    }
}
