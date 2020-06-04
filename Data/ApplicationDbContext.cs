using ANOOSHEH_Library.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ANOOSHEH_Library.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
           
        }

        public DbSet<Booklist> Booklist { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Blogpost> Blogpst { get; set; }

    }
}
