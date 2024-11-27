using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Web.DomainLayer;

namespace Web.ApplicationLayer;

public class DistrictService:IDistrictService
{
    //private readonly List<District> Districts = new List<District>()
    //{
    //    new District{CityCode="IST",Name="Ataşehir"},
    //    new District{CityCode="IST",Name="Kadıköy"},
    //    new District{CityCode="IZM",Name="Karşıyaka"}
    //};


    
    //public List<District> GetDistricts(string citycode)
    //{
    //    var result = Districts.Where(s => s.CityCode == citycode).ToList();
    //    return result;
    //}

}
