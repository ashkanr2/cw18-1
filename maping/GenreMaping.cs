using cw18_1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace cw18_1.maping
{
    public class GenreMaping : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.HasData(
           new Genre { Title = "comedy" },
           new Genre { Title = "Historical" },
           new Genre { Title = "Math" });
        }
    }
}
