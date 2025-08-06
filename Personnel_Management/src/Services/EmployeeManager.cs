using System.Collections.Generic;
using System.Linq;
using Personnel_Management.Base.Interface;
using Personnel_Management.Models;

namespace Personnel_Management.Services
{
    public class EmployeeManager : IEmployeeManage
    {
        private List<Employee> employees = new List<Employee>();
        public bool AddEmployee(Employee employee)
        {
            //employees.Add(employee);
            //Console.WriteLine("Thêm thành công nhân viên");

            if (employee == null) return false;
            employees.Add(employee);
            return true;
        }

        // xóa void 
        public List<Employee> DisplayAllEmployees()
        {
            return employees;
        }

        public double CalculateTotalSalary()
        {
            double total = 0;
            foreach (Employee emp in employees)
            {
                total += emp.CalculateSalary();
            }
            return total;
        }

        public Employee FindHighestSalaryEmployee()
        {
            if (employees.Count == 0)
            {
                return null;
            }

            Employee highest = employees[0];

            for (int i = 1; i < employees.Count; i++)
            {
                if (employees[i].CalculateSalary() > highest.CalculateSalary())
                {
                    highest = employees[i];
                }
            }

            return highest;
        }

        public List<Employee> FindEmployeesByName(string name)
        {
            List<Employee> result = new List<Employee>();

            for (int i = 0; i < employees.Count; i++)
            {
                Employee emp = employees[i];

                if (emp.Name != null && emp.Name.Contains(name))
                {
                    result.Add(emp);
                }
            }

            return result;
        }

        // ghi nho
        public int RemoveEmployeeById(string id)
        {
            var emp = employees.FirstOrDefault(e => e.ID == id);
            if (emp == null)
            {
                return -1; // ko tìm thấy nhân viên với ID đã cho
            }

            employees.Remove(emp);
            return 1; // xoá thành công
        }

        public Employee FindEmployeeById(string id)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                Employee emp = employees[i];

                if (emp.ID != null && emp.ID == id)
                {
                    return emp; // trả về nhân viên tìm thấy
                }
            }

            return null; // ko tìm thấy nhân viên với ID đã cho
        }


        public void SortEmployeesBySalary()
        {
            for (int i = 0; i < employees.Count - 1; i++)
            {
                for (int j = 0; j < employees.Count - i - 1; j++)
                {
                    if (employees[j].CalculateSalary() < employees[j + 1].CalculateSalary())
                    {
                        // Hoán đổi vị trí và tìm hiểu kĩ đoạn naỳ
                        Employee temp = employees[j];
                        employees[j] = employees[j + 1];
                        employees[j + 1] = temp;
                    }
                }
            }
        }
        public List<Employee> GetAllEmployees()
        {
            return employees;
        }
    }
}
