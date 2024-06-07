using AutoMapper;
using Employee_Exercise.BLL;
using Employee_Exercise.Models;
using Employee_Exercise.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileSystemGlobbing.Internal.PatternContexts;
using System.ComponentModel.DataAnnotations;

namespace Employee_Exercise.Controllers
{
    [ApiController]
    [Route("[controller]")]
   
    public class EmployeeController:ControllerBase
    {
        private readonly IEmployeeService employeeService;
        private readonly IMapper mapper;

        public EmployeeController(IEmployeeService employeeService,IMapper mapper)
        {
            this.employeeService = employeeService;
            this.mapper = mapper;
        }
        [HttpGet("")]
        public List<Employee> Get()
        {
            return employeeService.Get();
        } 

        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return employeeService.Get(id);
        }

        [HttpPost]
        public void Add(EmployeeDto employee)

        { 
            var e = mapper.Map<Employee>(employee);
            //var e = new Employee
            //{
            //    Name = employee.Name,
            //    Salary = employee.Salary,
            //    Role = employee.Role
            //};
            employeeService.Add(e);
        }

        [HttpGet]
        public void ZehaviFunction()
        {
            var response = "hi, it's work!, so amazing!!!";
            response += "hi its hadassa !!!";
            return response;
        }
    }
}
