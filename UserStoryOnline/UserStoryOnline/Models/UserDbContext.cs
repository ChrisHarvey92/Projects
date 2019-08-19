using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;

namespace UserStoryOnline.Models
{
    public class UserDbContext : DbContext
    {
           public DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
            .UseMySql(@"server=userstoryonline.net;database=UserStoryOnline;user=usersto1_Chris;password=ZX7R996sp");

    }




    }


