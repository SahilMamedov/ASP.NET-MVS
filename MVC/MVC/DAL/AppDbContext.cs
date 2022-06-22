using Microsoft.EntityFrameworkCore;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        //public DbSet<Book> Books { get; set; }
        //public DbSet<Student> Students { get; set; }

        public DbSet <Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<SosialAcaunt> SosialAcaunts { get; set; }

    }
}
