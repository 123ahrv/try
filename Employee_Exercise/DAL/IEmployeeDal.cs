using Employee_Exercise.Models;

namespace Employee_Exercise.DAL
{
    public interface IEmployeeDal
    {
        List<Employee> Get();
        Employee Get(int id);

        void Add(Employee product);
    }
}
