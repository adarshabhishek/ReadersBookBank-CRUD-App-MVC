using Microsoft.EntityFrameworkCore;
using ReadersBookBank.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadersBookBank.DAL
{
    public class BookDbContext : DbContext
    {
        public DbSet<BookDetail> BookDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=ADARSH\\SQLEXPRESS;Initial Catalog=ReadersBookBankDB;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
