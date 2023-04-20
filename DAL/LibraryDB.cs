using cw18_1.maping;
using cw18_1.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace cw18_1.DAL
{
    public class LibraryDB : DbContext
    {
        public LibraryDB(DbContextOptions option):base(option) { }
        DbSet<Address> Addresses { get; set; }
        DbSet<Book> Books { get; set; }
        DbSet<City> Cities { get; set; }
        DbSet<Genre> Genres { get; set; }
        DbSet<Town> Towns { get; set; }
        DbSet<Genre> Users { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMaping());
            base.OnModelCreating(modelBuilder);

          
            //modelBuilder.Entity().HasData(new Genre { Id = 1, Name = "Fiction" });
            //modelBuilder.Entity().HasData(new Book { Id = 1, Title = "The Great Gatsby", GenreId = 1 });
        }
    }
}
