using Web.DomainLayer.Shared;

namespace Web.DomainLayer;

public class District : BaseClass
{
    public int CityId { get; set; }
    public City City    { get; set; }// foregni key
    public string Name { get; set; }

    public virtual ICollection<Personnel> Personnels { get; set; }



}
