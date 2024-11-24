using System.Web.Mvc;
using Web.DomainLayer;

namespace Web.ApplicationLayer;

public class CityService
{
    public readonly List<City> Cities = new List<City>() {
        new City()
        {
            Name="Istanbul",
            Code="IST"
        },
        new City()
        {
            Name="Izmir",
            Code="IZM"
        }

    };


    [HttpGet]
    public List<City> GetCityList()
    {
        return Cities;
    }
}
