using Personnel_Management.Models;

namespace Personnel_Management.Base.Interface
{
    public interface IEmployeeManage
    {
        void AddEmployee(Employee employee);
        void DisplayAllEmployees();
        void CalculateSalaryEmploye();
        void FindHighestSalaryEmployee();
        void FindEmployeesByName(string Name);
        void RemoveEmployeeById(string ID);
        void SortEmployeesBySalary();

    }
}
