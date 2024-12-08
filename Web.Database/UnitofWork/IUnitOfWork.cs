using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Database.Repository;
using Web.Database.Repository.Personnels;

namespace Web.Database.UnitofWork
{
    public interface IUnitOfWork : IDisposable
    {
        ICityRepository Cities {  get; }

        IPersonnelRepository Personnels { get; }

        IDistrictRepository Districts { get; }

        Task<int> CompleteAsync();
    }
}
