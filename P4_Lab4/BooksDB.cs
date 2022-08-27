using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace P4_Lab4
{
    public class BooksDB : DbContext
    {
        public BooksDB()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Biblioteka;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Autor> Autors { get; set; }
    }
}
