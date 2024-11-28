
using Web.DomainLayer;

namespace Web.ApplicationLayer
{
    public interface ICityService
    {
        Task Add(City city);

       // List<City> GetCityList();
    }
}
