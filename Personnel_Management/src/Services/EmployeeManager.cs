using System;
using System.Collections.Generic;
using Personnel_Management.Base.Interface;
using Personnel_Management.Models;

namespace Personnel_Management.Services
{
    public class EmployeeManager : IEmployeeManage
    {
        private List<Employee> employees = new List<Employee>();
        public void AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void DisplayAllEmployees()
        {
            throw new NotImplementedException();
        }

        public void CalculateSalaryEmploye()
        {
            throw new NotImplementedException();
        }

        public void FindHighestSalaryEmployee()
        {
            throw new NotImplementedException();
        }

        public void FindEmployeesByName(string name)
        {
            throw new NotImplementedException();
        }

        public void RemoveEmployeeById(string id)
        {
            throw new NotImplementedException();
        }

        public void SortEmployeesBySalary()
        {
            throw new NotImplementedException();
        }
    }
}
