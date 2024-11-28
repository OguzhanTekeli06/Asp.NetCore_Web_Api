using Microsoft.EntityFrameworkCore;
using Web.DomainLayer;

namespace Web.Database;

public static class ContextSeed
{
    public static void Seed(this ModelBuilder builder) {
        builder.Entity<City>().HasData(new
        {
            Id = 1,
            Name = "İstanbul"

        });

        
    }

 
}
