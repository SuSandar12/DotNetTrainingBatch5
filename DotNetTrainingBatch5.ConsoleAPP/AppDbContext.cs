using DotNetTrainingBatch5.ConsoleAPP.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTrainingBatch5.ConsoleAPP
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = "Data Source=SQLEXPRESS;Initial Catalog=DotNetBatch5_DB;User ID=sa;Password=root;";
                optionsBuilder.UseSqlServer(connectionString);
            }

            
        }

        public DbSet<BlogDataModel> Blogs { get; set; } 
    }
}
