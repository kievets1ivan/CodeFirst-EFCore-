using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class UserRepository : DbContext
    {
        public UserRepository(DbContextOptions<UserRepository> options) : base(options)
        {

        }

        public DbSet<User> UserSet { get; set; }
    }
}
