using Application.Features.EmployeeFeature.Dtos;
using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
        Task<decimal> GetSalaryAsync(int Id);
        Task<List<EmployeeDTO>> GetEmployeeWithDepartment();
    }
}
