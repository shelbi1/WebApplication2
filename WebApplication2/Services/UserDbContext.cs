using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Services
{
        public class UserDbContext : DbContext
        {
            public UserDbContext(DbContextOptions options) : base(options)
            {
                Database.EnsureCreated();
            }

            public DbSet<User> CurrentUsers { get; set; }
        }
}
