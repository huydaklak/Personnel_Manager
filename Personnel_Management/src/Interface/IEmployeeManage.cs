using System.Collections.Generic;
using Personnel_Management.Models;

namespace Personnel_Management.Base.Interface
{
    public interface IEmployeeManage
    {
        bool AddEmployee(Employee employee);
        List<Employee> DisplayAllEmployees();
        double CalculateTotalSalary();
        Employee FindHighestSalaryEmployee();
        int RemoveEmployeeById(string ID);
        Employee FindEmployeeById(string id);
        // sai  void SortEmployeesBySalary();
        List<Employee> FindEmployeesByName(string name);
        // sai  void FindEmployeesByName(string Name);
        void SortEmployeesBySalary();
        List<Employee> GetAllEmployees();
    }
}
