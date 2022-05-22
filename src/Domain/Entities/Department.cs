using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public  class Department: IEntityBase
    {
        public int Id { get; set; }
        public string DepName { get; set; }

        public List<Employee> Employees { get; set; }
        public bool InUse { get; set; }
        public DateTime InsertedAt { get; set; }
      
    }
}
