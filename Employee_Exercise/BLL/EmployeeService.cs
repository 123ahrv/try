using Employee_Exercise.DAL;
using Employee_Exercise.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Employee_Exercise.BLL
{
    public class EmployeeService:IEmployeeService
    {
        private readonly IEmployeeDal employeeDal;

        public EmployeeService(IEmployeeDal employeeDal)
        {
            this.employeeDal = employeeDal;
        }
        public List<Employee> Get()
        {
            return employeeDal.Get();
        }

        public Employee Get(int id)
        {
            var e = employeeDal.Get(id);
            e.Salary = e.Salary + 2000;
            return e;
        }

        public void Add(Employee employee)
        {
          
            employeeDal.Add(employee);
        }
    }
}
