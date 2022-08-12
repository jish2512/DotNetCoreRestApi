using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreRestApi.DBContexts;
using DotNetCoreRestApi.Models;

namespace DotNetCoreRestApi.BusinessManager
{
    public class UserDetails : IUserDetails
    {
        private readonly UserContext _context;

        public UserDetails(UserContext context)
        {
            _context = context;
        }

        public void CreateUserData(UserData user)
        {
            if (user == null)
                throw new ArgumentNullException();
            _context.UserDatas.Add(user);
        }

        public IEnumerable<UserData> FetchUsers()
        {
            return _context.UserDatas.ToList();
        }

        public UserData GetUserById(int id)
        {
            return _context.UserDatas.FirstOrDefault(user => user.ID == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() > 0);
        }
    }
}
