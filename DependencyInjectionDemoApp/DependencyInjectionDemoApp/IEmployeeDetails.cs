using DependencyInjectionDemoApp.Models;

namespace DependencyInjectionDemoApp
{
    public interface IEmployeeDetails
    {
        public List<Employee> GetEmployee();
    }

}
