using cw18_1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace cw18_1.maping
{
    public class CityMaping : IEntityTypeConfiguration<City>
    {

        public void Configure(EntityTypeBuilder<City> builder)
        {
        
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).HasMaxLength(50).IsRequired();
            builder.HasOne(u => u.Town).WithMany(x => x.Cities).HasForeignKey(x => x.TownId);
            builder.HasData(
            new City { Name = "tehran" },
            new City { Name = "shiraz" },
            new City { Name = "mashhad" });
        }
    
    }
}
