using Domain.Entities;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
        Task<decimal> GetSalaryAsync(int Id);
    }
}
