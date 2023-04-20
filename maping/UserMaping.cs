using cw18_1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace cw18_1.maping
{
    public class UserMaping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
           builder.ToTable("Users");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn(1,1);
            builder.Property(x => x.Name).HasMaxLength(50).IsRequired();
            builder.Property(x=>x.Email).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Password).HasMaxLength(50).IsRequired();
            builder.HasOne(x => x.Address).WithOne(b => b.User).HasForeignKey<User>(x=>x.AddressId);
            builder.HasMany(u => u.Books)
            .WithMany(b => b.Users)
            .UsingEntity<Dictionary<string, object>>(
            "UserBook",
            u => u.HasOne<Book>().WithMany().HasForeignKey("BookId").OnDelete(DeleteBehavior.Cascade),
            b => b.HasOne<User>().WithMany().HasForeignKey("UserId").OnDelete(DeleteBehavior.Cascade),
            ue => ue.HasKey("UserId", "BookId"));
            builder.HasData(
                new User { Id=-1,Name = "ashkan", Email = "razaviash21@gmail.com", Password = "1234", AddressId=1},
                new User { Id=-2,Name = "mohamd ", Email = "mohamad@gmail.com", Password = "1234",AddressId=2 },
                new User { Id=-3,Name = "farnosh", Email = "farnosh2@gmail.com", Password = "1234",AddressId=3 },
                new User { Id=-4,Name = "mohamd2", Email = "mohamad123@gmail.com", Password = "1234",AddressId=4 }
             );
        }
    }
}
