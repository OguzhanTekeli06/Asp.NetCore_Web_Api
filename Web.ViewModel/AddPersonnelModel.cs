using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.DomainLayer.Shared;

namespace Web.ViewModel
{
    public class AddPersonnelModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        public DateTime BirthDate { get; set; }

        public GenderType Gender { get; set; }

        public int DistrictId { get; set; }
    }
}
