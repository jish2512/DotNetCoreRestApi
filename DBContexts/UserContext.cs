using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreRestApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreRestApi.DBContexts
{
    public class UserContext : DbContext

    {
        public UserContext(DbContextOptions<UserContext> opt) : base(opt)
        {

        }
        public DbSet<UserData> UserDatas { get; set; }
    }
}
