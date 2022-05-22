using Domain.Common;
using System;

namespace Domain.Entities
{
    public class Employee: IEntityBase
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string IdentityNo { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public Department Department { get; set; }

        public bool InUse { get; set; }
        public DateTime InsertedAt { get; set; }
    }
}
