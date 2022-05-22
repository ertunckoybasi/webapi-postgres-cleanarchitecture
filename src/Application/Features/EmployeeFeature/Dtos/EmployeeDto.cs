using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.EmployeeFeature.Dtos
{
   public class EmployeeDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string IdentityNo { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DepartmentDTO Department { get; set; }
    }

    public class DepartmentDTO
    {
        public string Name { get; set; }
    }
}
