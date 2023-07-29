using DependencyInjectionDemoApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionDemoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeDetails _employeeService;
        private readonly IDepartmentDetails _departmentService;

        public EmployeeController(IEmployeeDetails employeeService, IDepartmentDetails departmentService)
        {
            _employeeService = employeeService;
            _departmentService = departmentService;
        }

        [Route("GetEmp")]
        [HttpGet]
        public IEnumerable<Employee> GetEmployeeList1() 
        { 
            var res = _employeeService.GetEmployee();
            _employeeService.
            return res;
        }

        [Route("GetDeptment")]
        [HttpGet]
        public IEnumerable<Department> GetDepartment()
        {
            var res = _departmentService.getDepartmentDetails();
            return res;
        }
    }
}
