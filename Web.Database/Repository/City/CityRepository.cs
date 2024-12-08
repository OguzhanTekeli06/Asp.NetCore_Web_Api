using Microsoft.EntityFrameworkCore;
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

    public async Task<City> GetCityByName(string cityName)
    {
        var record = await _context.Set<City>().Where(s => s.Name == cityName).FirstOrDefaultAsync();
        return record;
    }

    
}
