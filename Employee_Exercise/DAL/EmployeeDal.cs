using Employee_Exercise.Models;

namespace Employee_Exercise.DAL
{
    public class EmployeeDal : IEmployeeDal
    {
        private static List<Employee> employees = new List<Employee> { new Employee { Role = "ofhg", FullName = "A", Salary = 1 }, new Employee {    Role = "hfjk",  Salary = 2, FullName = "B" } };
        public void Add(Employee employee)
        {
            employees.Add(employee);
        }

        public Employee Get(int id)
        {
            return employees.Find(e => e.Id == id);
        }

        public List<Employee> Get()
        {
            return employees;
        }
    }
}
