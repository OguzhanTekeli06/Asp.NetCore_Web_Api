using Web.DomainLayer.Shared;

namespace Web.DomainLayer;

public class District
{
    public int Id { get; set; }
    public int CityId { get; set; }
    public DataStatus Status { get; set; }
    public City City    { get; set; }// foregni key
    public string Name { get; set; }

}
