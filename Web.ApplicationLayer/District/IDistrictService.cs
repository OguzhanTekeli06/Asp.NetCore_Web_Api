using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.DomainLayer;

namespace Web.ApplicationLayer;

public interface IDistrictService
{
    List<District> GetDistricts(string citycode)
}
