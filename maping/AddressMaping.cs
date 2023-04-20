using cw18_1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace cw18_1.maping
{
    public class AddressMaping : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.HasData(
              new Address {Title="enghelab",Description="koche 3"},
              new Address {Title = "azadi", Description = "koche 4" },
              new Address {Title = "tehranpars", Description = "koche 1" },
              new Address {Title = "sadatabad", Description = "koche 123" }
            );
        }
    }
}
