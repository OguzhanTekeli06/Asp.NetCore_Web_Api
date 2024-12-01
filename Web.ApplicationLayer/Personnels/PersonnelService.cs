using Web.Database.UnitofWork;
using Web.ViewModel;
using Web.DomainLayer;
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

        
    }
}
