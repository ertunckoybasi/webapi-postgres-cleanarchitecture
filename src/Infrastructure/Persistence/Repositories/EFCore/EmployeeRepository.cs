using System.Threading.Tasks;

using Application.Interfaces;
using Domain.Entities;
using Persistence.Data;

namespace Persistence.Repositories.EFCore
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {

        public EmployeeRepository(ApplicationDbContext context) : base(context)
        {

        }
      

        public Task<decimal> GetSalaryAsync(int Id)
        {
            decimal mdSalary = 5000;
            return Task.FromResult(mdSalary);
        }
    }
}