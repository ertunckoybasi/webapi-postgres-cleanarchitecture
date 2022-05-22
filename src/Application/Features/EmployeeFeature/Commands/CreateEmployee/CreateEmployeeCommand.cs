using Application.Features.EmployeeFeature.Dtos;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.EmployeeFeature.Commands.CreateEmployee
{

    public class CreateEmployeeCommand : IRequest<EmployeeDTO>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string IdentityNo { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DepartmentDTO Department { get; set; }
    }
    public class EmployeeCreateHandler : IRequestHandler<CreateEmployeeCommand, EmployeeDTO>
    {
        private readonly IEmployeeRepository _EmployeeRepository;
        private readonly IMapper _mapper;
        

        public EmployeeCreateHandler(IEmployeeRepository EmployeeRepository, IMapper mapper)
        {
            _EmployeeRepository = EmployeeRepository;
            _mapper = mapper;
        }

        public async Task<EmployeeDTO> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var EmployeeEntity = _mapper.Map<Employee>(request);
            if (EmployeeEntity == null)
                throw new ApplicationException("Entity could not be mapped!");

            var sEmployee = await _EmployeeRepository.AddAsyn(EmployeeEntity);

            var EmployeeResponse = _mapper.Map<EmployeeDTO>(sEmployee);

            return EmployeeResponse;
        }


    }
}
