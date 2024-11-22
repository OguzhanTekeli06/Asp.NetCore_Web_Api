namespace WebApplication1.Models;

public class District
{
    public string CityCode { get; set; }
    public string Name { get; set; }

    internal static object Where(Func<object, object> value)
    {
        throw new NotImplementedException();
    }
}
