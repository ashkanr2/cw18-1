using cw18_1.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace cw18_1.maping
{
    public class BookMaping : IEntityTypeConfiguration<Book>
    {
        
            public void Configure(EntityTypeBuilder<Book> builder)
            {
                builder.ToTable("Book");
                builder.HasKey(x => x.Id);
                builder.Property(x => x.Id).ValueGeneratedOnAdd();
                builder.Property(x => x.Name).HasMaxLength(50).IsRequired();
                builder.HasMany(u => u.Users).WithMany(b => b.Books);
                builder.HasOne(u => u.Genre).WithMany(x => x.Books).HasForeignKey(x=>x.GenreId);

            builder.HasData(
            new Book { GenreId=1 ,Name = "Funny"},
            new Book { GenreId=2 ,Name = "Asqar History"},
            new Book { GenreId=3 , Name = "Math and Life"},
            new Book { GenreId =1, Name = "Bamaze" }
            );
             }
   
       
    }
}
