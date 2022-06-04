using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Features.EmployeeFeature.Dtos;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;

namespace Persistence.Repositories.EFCore
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        protected new ApplicationDbContext _context;
        protected IMapper _mapper;
        public EmployeeRepository(ApplicationDbContext context,IMapper mapper) : base(context)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<EmployeeDTO>> GetEmployeeWithDepartment()
        {
            var empList = await _context.Employees.Include("Department").ToListAsync();
            var empVM = _mapper.Map<List<EmployeeDTO>>(empList);
            return empVM;
        }

        public Task<decimal> GetSalaryAsync(int Id)
        {
            decimal mdSalary = 5000;
            return Task.FromResult(mdSalary);
        }
    }

}
