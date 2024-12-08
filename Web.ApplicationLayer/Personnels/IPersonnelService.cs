using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.ViewModel;

namespace Web.ApplicationLayer.Personnels
{
    public interface IPersonnelService
    {
        Task<AddPersonnelModel> AddAsync(AddPersonnelModel model);
        Task<AddPersonnelModel> UpdateAsync(AddPersonnelModel model);
        Task<bool> DeleteAsync(int id);

        Task<AddPersonnelInfoModel> AddPersonnelAsync(AddPersonnelInfoModel model);



    }
}
