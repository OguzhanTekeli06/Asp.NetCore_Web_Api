using Web.Database.Repository;
using Web.Database.Repository.Personnels;

namespace Web.Database.UnitofWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly Context _context;
    public ICityRepository Cities { get; private set; }

    public IPersonnelRepository Personnels { get; private set; }

    public IDistrictRepository Districts { get; private set; } // Doğru şekilde tanımlandı

    //public ICityRepository cityRepository => throw new NotImplementedException();



    

    public UnitOfWork(Context context)
    {
        _context = context;
        Cities = new CityRepository(_context);
        Personnels = new PersonnelRepository(_context);
        Districts = new DistrictRepository(_context);

    }

    public void Dispose()
    {
        _context.Dispose();
    }

    public async Task<int> CompleteAsync()
    {
         return await _context.SaveChangesAsync();
    }
}
