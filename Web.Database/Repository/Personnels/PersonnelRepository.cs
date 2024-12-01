using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.DomainLayer;
using Web.ViewModel;

namespace Web.Database.Repository.Personnels;

public class PersonnelRepository : IPersonnelRepository
{
    private readonly Context _context;

    public PersonnelRepository(Context context)
    {
        _context = context;
    }


    public async Task<Personnel> AddAsync(Personnel personnel)
    {
        return (await _context.Set<Personnel>().AddAsync(personnel)).Entity;    
    }

    
}
