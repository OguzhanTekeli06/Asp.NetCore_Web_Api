using System.Web.Mvc;
using Web.DomainLayer;

using Web.Database.Repository;
namespace Web.ApplicationLayer;

public class CityService : ICityService
{

    private readonly ICityRepository _cityRepository;    // dependency injection yapılımış olunuyor.

    public CityService(ICityRepository cityRepository)
    {
        _cityRepository = cityRepository;
    }


    public async Task Add(City city)
    {
        await _cityRepository.AddAsync(city);
    }




    //public readonly List<City> Cities = new List<City>() {
    //    new City()
    //    {
    //        Name="Istanbul",
    //        Code="IST"
    //    },
    //    new City()
    //    {
    //        Name="Izmir",
    //        Code="IZM"
    //    }

    //};


    //[HttpGet]
    //public List<City> GetCityList()
    // {
    //     return Cities;
    // }
}

