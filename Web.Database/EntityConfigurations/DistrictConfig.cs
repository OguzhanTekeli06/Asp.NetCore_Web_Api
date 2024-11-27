using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.DomainLayer;
using Web.DomainLayer.Shared;

namespace Web.Database.EntityConfigurations;

public class DistrictConfig : IEntityTypeConfiguration<District>
{
    public void Configure(EntityTypeBuilder<District> builder)
    {
        builder.ToTable(nameof(City), "dbo");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).HasMaxLength(256).IsRequired();
        builder.Property(x => x.Status).HasDefaultValue(DataStatus.Active);
        builder.HasOne(s => s.City).WithMany(s => s.Districts).HasForeignKey(s => s.CityId).OnDelete(deleteBehavior: DeleteBehavior.Cascade ); // bu şekilde istanbul silinince istanbula bağlı tüm disltricler de silincecektir.!

    }
}
