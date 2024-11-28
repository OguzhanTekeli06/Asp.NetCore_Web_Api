using Web.DomainLayer;

namespace Web.Database.Repository;     

public interface ICityRepository
{
    Task AddAsync(City city);
}
