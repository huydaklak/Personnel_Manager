using System;
using System.Collections.Generic;
using System.Linq;
using Personnel_Management.Base.Interface;
using Personnel_Management.Models;

namespace Personnel_Management.Services
{
    public class EmployeeManager : IEmployeeManage
    {
        private List<Employee> employees = new List<Employee>();
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
            Console.WriteLine("Thêm thành công nhân viên");
        }

        public void DisplayAllEmployees()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            if (employees.Count == 0)
            {
                Console.WriteLine("Danh sách nhân viên trống");
                return;
            }

            Console.WriteLine("Danh sách nhân viên : ");
            foreach (var emp in employees)
            {
                emp.DisplayInfo();
                Console.WriteLine("Tổng lương các nhân viên : " + emp.CalculateSalary());
                Console.WriteLine("-------------------------------");
            }
        }

        public double CalculateTotalSalary()
        {
            return employees.Sum(e => e.CalculateSalary());
        }

        public Employee FindHighestSalaryEmployee()
        {
            if (employees.Count == 0)
            {
                return null;
            }

            return employees.OrderByDescending(e => e.CalculateSalary()).First();
        }

        public void FindEmployeesByName(string name)
        {
            var matches = employees
                .Where(e => e.Name != null && e.Name.ToLower().Contains(name.ToLower()))
                .ToList();

            if (matches.Count == 0)
            {
                Console.WriteLine("Không tìm thấy nhân viên nào khớp.");
                return;
            }

            Console.WriteLine("Các nhân viên tìm thấy:");
            foreach (var emp in matches)
            {
                emp.DisplayInfo();
                Console.WriteLine($"Tổng lương: {emp.CalculateSalary()}");
                Console.WriteLine("-----------------------------");
            }
        }

        public void RemoveEmployeeById(string id)
        {
            var emp = employees.FirstOrDefault(e => e.ID == id);
            if (emp == null)
            {
                Console.WriteLine("Không tìm thấy nhân viên với ID đó");
                return;
            }

            employees.Remove(emp);
            Console.WriteLine("Nhân viên đã được xóa thành công");
        }

        public void SortEmployeesBySalary()
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("Không có nhân viên để sắp xếp");
                return;
            }

            employees = employees.OrderByDescending(e => e.CalculateSalary()).ToList();
            Console.WriteLine("Danh sách nhân viên sau khi sắp xếp theo lương giảm dần : ");
            DisplayAllEmployees();
        }
    }
}
