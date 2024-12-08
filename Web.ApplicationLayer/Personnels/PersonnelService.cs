using Web.Database.UnitofWork;
using Web.ViewModel;
using Web.DomainLayer;
using Web.DomainLayer.Shared;
namespace Web.ApplicationLayer.Personnels
{
    public class PersonnelService : IPersonnelService
    {
        private readonly IUnitOfWork _unitOfWork;



        public PersonnelService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<AddPersonnelModel> AddAsync(AddPersonnelModel model)
        {
            try
            {
                var personel = new Personnel  //mapping  ıd vermedik çünkü etity fw kendisi yapıcak ıd işlemelerini. configdeki haskey ile
                {
                    BirthDate = model.BirthDate,
                    DistrictId = model.DistrictId,
                    FullName = model.FullName,
                    Gender = model.Gender,

                };
                await _unitOfWork.Personnels.AddAsync(personel);
                await _unitOfWork.CompleteAsync();
                model.Id = personel.Id;    // ui tarafında gözükmesi için.
                return model;
            }
            catch (Exception exp)
            {

                throw new Exception(exp.Message);
            }
            
        }

        public async Task<AddPersonnelModel> UpdateAsync(AddPersonnelModel model)
        {
            try
            {
                var record = await _unitOfWork.Personnels.Get(model.Id);                                        //hangisini update edeceğimizi bilmek için ıdyi bilmemmiz gerek.
                if (record != null)
                {
                    record.FullName = model.FullName;
                    record.Gender = model.Gender;
                    record.BirthDate = model.BirthDate;
                    record.DistrictId   = model.DistrictId;

                    _unitOfWork.Personnels.Update(record);
                    await _unitOfWork.CompleteAsync();
                    return model;   
                }
                return new AddPersonnelModel();  // eğer yoksa boş bir data dönüyoruz
                
                    
              

            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message);

            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                var record = await _unitOfWork.Personnels.Get(id);                                        //hangisini update edeceğimizi bilmek için ıdyi bilmemmiz gerek.
                if (record != null)
                {
                    record.Status = DataStatus.Deleted; 
                    _unitOfWork.Personnels.Update(record);         // bu iki satır UpdateAsync olarak birleştirilebillir mi?  bu satır Personelrepoisotrydeki Update fonksiyonu.
                    await _unitOfWork.CompleteAsync();
                    return true;
                }
                return false;

            }
            catch (Exception exp)
            {

                throw new Exception(exp.Message);
            }
        }


        public async Task<AddPersonnelInfoModel> AddPersonnelAsync(AddPersonnelInfoModel model)
        { 
            try
            {

                var personnel = new Personnel();
                personnel.Gender = model.Gender;
                personnel.BirthDate = model.BirthDate;
                personnel.FullName = model.FullName;

                var district = await _unitOfWork.Districts.GetDistrictByCityAndName(model.CityName,model.DistrictName);
                if (district != null)
                {
                    personnel.DistrictId = district.Id;
                    await _unitOfWork.Personnels.AddAsync(personnel);
                    await _unitOfWork.CompleteAsync();
                    model.Id = personnel.Id;
                    return model;
                }

                var city = await _unitOfWork.Cities.GetCityByName(model.CityName);

                if (city != null)
                {
                    var newDistrictForCity = new District()           //burda da maping
                    {
                        CityId = city.Id,
                        Name= model.DistrictName
                    };
                    newDistrictForCity.Personnels.Add(personnel);
                    await _unitOfWork.Districts.AddAsync(newDistrictForCity);
                    await _unitOfWork.CompleteAsync();
                    model.Id = personnel.Id;
                    return model;
                }

                var newCity = new City()
                {
                    Name = model.CityName,

                };
                var newDistrict = new District()   // collection olarak eklediğimiz için db ye kaydederken kendisi otomatik olarak kaydettiği cityId yi alıcak. o yüzden cityıd eklemedik.
                {
                    Name = model.DistrictName
                };
                // bu city altında bu district, bu d. altında bu personel var.
                
                newDistrict.Personnels.Add(personnel);
                newCity.Districts.Add(newDistrict);
                await _unitOfWork.Cities.AddAsync(newCity);
                await _unitOfWork.CompleteAsync();
                model.Id = personnel.Id;
                return model;
            }
            catch (Exception exp)
            {

                throw new InvalidOperationException("An error occurred while adding personnel.", exp);
             }
        }


    }
}
