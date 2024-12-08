using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.DomainLayer;

namespace Web.Database.Repository;

public interface IDistrictRepository
{
    Task<District> GetDistrictByCityAndName(string cityName, string districtName);

    Task AddAsync(District district);
}
