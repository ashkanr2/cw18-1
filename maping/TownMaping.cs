using cw18_1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace cw18_1.maping
{
    public class TownMaping : IEntityTypeConfiguration<Town>
    {
        public void Configure(EntityTypeBuilder<Town> builder)
        {
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.HasKey(x => x.Id);
            new Town { Name = "tehran" };
            new Town { Name = "shiraz" };
            new Town { Name = "esfahan" };
        }
    }
}
