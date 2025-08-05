using Personnel_Management.Models;

namespace Personnel_Management.Base.Interface
{
    public interface IEmployeeManage
    {
        void AddEmployee(Employee employee);
        void DisplayAllEmployees();
        double CalculateTotalSalary();
        Employee FindHighestSalaryEmployee();
        void FindEmployeesByName(string Name);
        void RemoveEmployeeById(string ID);
        void SortEmployeesBySalary();

    }
}
