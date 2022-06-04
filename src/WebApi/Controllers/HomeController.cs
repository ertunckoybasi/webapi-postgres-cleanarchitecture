using Application.Features.EmployeeFeature.Dtos;
using Application.Features.EmployeeFeature.Queries.GetListEmployees;
using Application.Interfaces;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    //[Authorize]
    [ApiController]
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeService;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public HomeController(IEmployeeRepository employeeRepository, IMediator mediator, IMapper mapper)
        {
            _employeeService = employeeRepository;
            _mapper = mapper;
            _mediator = mediator;
        }


        [HttpGet]
        [Route("GetAll")]
        [ProducesResponseType(typeof(IEnumerable<EmployeeDTO>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public async Task<ActionResult<IEnumerable<EmployeeDTO>>> Getemployees()
        {
            var query = new GetAllEmployeesWithDepartmentQuery();
            var employeeResponse = await _mediator.Send(query);
            if (!employeeResponse.Any()) return NoContent();
            return Ok(employeeResponse);
        }
    }
}
