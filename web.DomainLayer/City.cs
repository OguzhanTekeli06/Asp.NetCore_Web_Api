using Web.DomainLayer.Shared;

namespace Web.DomainLayer;

public class City : BaseClass
{
    public string Name { get; set; }
    //public DataStatus Status { get; set; }
    //0: active -1:deleted.              Datayı databaseden silmek çok doğru bir şey değildir o yüzden bu şekilde yöneticez!!. Enum Shared Enum.cs.
    public virtual ICollection<District> Districts { get; set; } = new List<District>();    // tabloları ilişkilendirdik. buradaki virtual önemli. sadece gerekli olduğunda fetxhlenecek artık boşa sürekli getirilmeyecek. Eager ve isloading!!
}