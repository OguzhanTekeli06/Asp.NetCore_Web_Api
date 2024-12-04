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

    public async Task<Personnel> Get(int id)
    {
        var record= await _context.Set<Personnel>().FindAsync(id);
        return record;
    }

    public Personnel Update(Personnel personnel)
    {
        return ( _context.Set<Personnel>().Update(personnel)).Entity;

    }
}
