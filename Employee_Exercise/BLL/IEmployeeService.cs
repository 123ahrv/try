using Employee_Exercise.Models;

namespace Employee_Exercise.BLL
{
    public interface IEmployeeService
    {
        List<Employee> Get();
        Employee Get(int id);
        void Add(Employee product);
    }
}
