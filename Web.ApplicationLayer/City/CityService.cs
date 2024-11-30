using System.Web.Mvc;
using Web.DomainLayer;
using Web.Database.Repository;
using Web.Database.UnitofWork;
namespace Web.ApplicationLayer;

public class CityService : ICityService
{

    private readonly IUnitOfWork _unitOfWork;    // dependency injection yapılımış olunuyor.

    public CityService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }


    public async Task Add(City city)
    {
        await _unitOfWork.Cities.AddAsync(city);
        await _unitOfWork.CompleteAsync();
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

