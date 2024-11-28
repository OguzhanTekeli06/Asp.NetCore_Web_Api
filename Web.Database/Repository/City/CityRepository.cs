using Web.DomainLayer;

namespace Web.Database.Repository;

public class CityRepository : ICityRepository
{

    private readonly Context _context;

    public CityRepository(Context context)
    {
        _context = context;
    }

    public async Task AddAsync(City city)
    {
        await _context.Set<City>().AddAsync(city);
        await _context.SaveChangesAsync();
    }
}
