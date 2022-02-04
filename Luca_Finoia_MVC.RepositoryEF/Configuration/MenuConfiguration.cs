using Luca_Finoia_MVC.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Luca_Finoia_MVC.RepositoryEF.Configuration
{
    internal class MenuConfiguration : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.ToTable("Menu");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.HasMany(x=>x.Piatti).WithOne(x=> x.Menu).HasForeignKey(x=>x.IdMenu);
        }
    }
}