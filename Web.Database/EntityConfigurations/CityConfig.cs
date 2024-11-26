using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.DomainLayer;

namespace Web.Database.EntityConfigurations;

public class CityConfig : IEntityTypeConfiguration<City>
{
    public void Configure(EntityTypeBuilder<City> builder)
    {
        builder.ToTable(nameof(City),"dbo");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).HasMaxLength(256).IsRequired();

        
    }
}
// database tarafında bu classın tablosunu oluşturduğu zaman bu confige bakacak ve buna göre oluşturucak.
