namespace Web.DomainLayer;

public class City
{
    public int Id { get; set; }
    public string Name { get; set; }

    
    public int Statu { get; set; }
    //0: active -1:deleted.              Datayı databaseden silmek çok doğru bir şey değildir o yüzden bu şekilde yöneticez!!
    //public virtual ICollection<District> Districts { get; set; }   // tabloları ilişkilendirdik. buradaki virtual önemli. sadece gerekli olduğunda fetxhlenecek artık boşa sürekli getirilmeyecek. Eager ve isloading!!
 }