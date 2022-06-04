using Domain.Entities;
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
        public Department Department { get; set; }
    }

    public class DepartmentDTO
    {
        public int Id { get; set; }
        public string DepName { get; set; }
        public bool InUse { get; set; }
        public DateTime InsertedAt { get; set; }

    }

}
