using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.DomainLayer.Shared;

namespace Web.DomainLayer;

public class Personnel : BaseClass 
{
    public string FullName { get; set; }

    public DateTime BirthDate { get; set; }

    public GenderType Gender { get; set; }

    public int DistrictId { get; set; }
    public District District { get; set; }


}
