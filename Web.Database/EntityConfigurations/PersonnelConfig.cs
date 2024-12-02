using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.DomainLayer.Shared;
using Web.DomainLayer;

namespace Web.Database.EntityConfigurations
{
    public class PersonnelConfig : IEntityTypeConfiguration<Personnel>
    {
        public void Configure(EntityTypeBuilder<Personnel> builder)
        {
            builder.ToTable(nameof(Personnel), "dbo");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Status).HasDefaultValue(DataStatus.Active);
            builder.Property(x => x.FullName).HasMaxLength(500).IsRequired();
            builder.HasOne(s => s.District).WithMany(s => s.Personnels).HasForeignKey(s => s.DistrictId).OnDelete(DeleteBehavior.NoAction).IsRequired();

        }
    }

}