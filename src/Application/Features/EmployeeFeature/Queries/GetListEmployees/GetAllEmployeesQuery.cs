using Application.Features.EmployeeFeature.Dtos;
using Application.Interfaces;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.EmployeeFeature.Queries.GetListEmployees
{
    public class GetAllEmployeesQuery : IRequest<List<EmployeeDTO>>
    {
        public class GetAllEmployeesQueryHandler : IRequestHandler<GetAllEmployeesQuery, List<EmployeeDTO>>
        {
            private readonly IEmployeeRepository EmployeeRepository;
            private readonly IMapper _mapper;
            public GetAllEmployeesQueryHandler(IEmployeeRepository EmployeeRepository, IMapper mapper)
            {
                this.EmployeeRepository = EmployeeRepository;
                this._mapper = mapper;
            }

            public async Task<List<EmployeeDTO>> Handle(GetAllEmployeesQuery request, CancellationToken cancellationToken)
            {
                var Employees = await EmployeeRepository.GetAllAsyn();
                var empVM = _mapper.Map<List<EmployeeDTO>>(Employees);
                return empVM;
            }

        }






    }
}
