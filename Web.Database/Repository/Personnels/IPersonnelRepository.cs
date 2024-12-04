using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.DomainLayer;
using Web.ViewModel;

namespace Web.Database.Repository.Personnels;   

public interface IPersonnelRepository
{
    Task<Personnel> AddAsync(Personnel personnel);

    Task<Personnel> Get(int id);
    Personnel Update(Personnel personnel);
} 
