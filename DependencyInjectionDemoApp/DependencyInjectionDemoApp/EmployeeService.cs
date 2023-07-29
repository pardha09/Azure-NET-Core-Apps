using DependencyInjectionDemoApp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DependencyInjectionDemoApp
{
    public class EmployeeService : IEmployeeDetails, IDepartmentDetails
    {

        public List<Employee> GetEmployee()
        {
            var employees = new List<Employee>()
            {
                new Employee()
                {
                    Id = 1,
                    Title = "Mr",
                    Name = "Employee 1",
                    Age =30,
                    EmailId = "Employee1@test.com",
                    MobileNumber ="111111",
                    City ="Hyderabad",
                    Pincode ="567890"
                },
                 new Employee()
                {
                    Id = 2,
                    Title = "Mr",
                    Name = "Employee 2",
                    Age =20,
                    EmailId = "Employee2@test.com",
                    MobileNumber ="22222",
                    City ="Bangalore",
                    Pincode ="222333"
                },
                  new Employee()
                {
                    Id = 3,
                    Title = "Mr",
                    Name = "Employee 3",
                    Age =35,
                    EmailId = "Employee3@test.com",
                    MobileNumber ="333333",
                    City ="Delhi",
                    Pincode ="563908"
                }
            };
            return employees;
        }
        public List<Department> getDepartmentDetails()
        {
            var departmentList = new List<Department>() {
                new  Department()
                {
                    DepartmentId = "D001",
                    DepartmentHead = "Mr. Davis",
                    DepartmentName = "IT"
                }
            };
            return departmentList;
        }
        public IEnumerable<Employee> SaveEmpAsList(Employee request)
        {
            List<Employee> emp = new List<Employee>();
            emp.Add(request);
            return emp;
        }
        public Employee GetOneEmployee()
        {
            Employee employee = new Employee()
            {
                Id = 3,
                Title = "Mr",
                Name = "Employee 3",
                Age = 35,
                EmailId = "Employee3@test.com",
                MobileNumber = "333333",
                City = "Delhi",
                Pincode = "563908"

            };
            return employee;
        }
    }
}
