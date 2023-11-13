using Ef1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef1.DAL
{
    public class AppDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=DESKTOP-2BIHFIP;database=Ef1;trusted_connection=true;integrated security=true;encrypt=false;");

            

        }
        public DbSet<Student> Students { get; set; }
    }
}
