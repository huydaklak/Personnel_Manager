using System;
using System.Globalization;
using Personnel_Management.Base.Interface;
using Personnel_Management.Models;
using Personnel_Management.src.Interface;

namespace Personnel_Management.src.UI
{
    public class EmployeeUI : IEmployeeUI
    {

        private readonly IEmployeeManage employeeManager;

        public EmployeeUI(IEmployeeManage employeeManager)
        {
            this.employeeManager = employeeManager;
        }

        public void InputFullTimeEmployee()
        {
            Console.WriteLine("--------- NHÂN VIÊN FULL-TIME ---------");
            var emp = new FullTimeEmployee();

            Console.Write("ID của nhân viên : ");
            emp.ID = Console.ReadLine();

            Console.Write("Họ và tên của nhân viên : ");
            emp.Name = Console.ReadLine();

            Console.Write("Tuổi nhân viên : ");
            emp.Age = Console.ReadLine();



            Console.Write("Mức lương cơ bản: ");
            double basicSalary;
            while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, new CultureInfo("vi-VN"), out basicSalary))
            {
                Console.WriteLine("Nhập sai định dạng! Vui lòng nhập lại số (dấu chấm): ");
            }
            emp.BasicSalary = basicSalary;

            Console.Write("Lương thưởng : ");
            double bonus;
            while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, new CultureInfo("vi-VN"), out bonus))
            {
                Console.WriteLine("Nhập sai định dạng! Vui lòng nhập lại số (dấu chấm): ");
            }
            emp.Bonus = bonus;

            Console.Write("Phạt : ");
            double penalty;
            while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, new CultureInfo("vi-VN"), out penalty))
            {
                Console.WriteLine("Nhập sai định dạng! Vui lòng nhập lại số (dấu chấm): ");
            }
            emp.Penalty = penalty;

            employeeManager.AddEmployee(emp);
        }
        public void InputPartTimeEmployee()
        {
            Console.WriteLine("--------- NHÂN VIÊN PART-TIME ---------");
            var emp = new PartTimeEmployee();

            Console.Write("ID của nhân viên : ");
            emp.ID = Console.ReadLine();

            Console.Write("Họ và tên của nhân viên : ");
            emp.Name = Console.ReadLine();

            Console.Write("Tuổi nhân viên : ");
            emp.Age = Console.ReadLine();

            Console.Write("Số giờ làm việc : ");
            emp.WorkingHours = int.Parse(Console.ReadLine());

            Console.Write("Lương theo giờ : ");
            double hourlyRate;
            while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, new CultureInfo("vi-VN"), out hourlyRate))
            {
                Console.WriteLine("Nhập sai định dạng! Vui lòng nhập lại số (dấu chấm): ");
            }
            emp.HourlyRate = hourlyRate;

            employeeManager.AddEmployee(emp);
        }
        public void PromptSearchByName()
        {
            Console.Write("Nhập tên để tìm kiếm : ");
            string name = Console.ReadLine();
            employeeManager.FindEmployeesByName(name);
        }
        public void PromptDeleteById()
        {
            Console.Write("Nhập ID nhân viên cần xoá: ");
            string id = Console.ReadLine();

            int result = employeeManager.RemoveEmployeeById(id); // gọi lớp xử lý

            if (result == -1)
            {
                Console.WriteLine("Không tìm thấy nhân viên");
            }
            else
            {
                Console.WriteLine("Nhân viên đã được xoá thành công");
            }
        }

        public void PromptFindHighestSalary()
        {
            var employee = employeeManager.FindHighestSalaryEmployee();
            if (employee != null)
            {
                Console.WriteLine("Nhân viên có lương cao nhất:");
                Console.WriteLine(employee);
            }
            else
            {
                Console.WriteLine("Không tìm thấy nhân viên.");
            }
        }

        public void PromptCalculateTotalSalary()
        {
            double total = employeeManager.CalculateTotalSalary();
            Console.WriteLine($"Tổng lương của công ty là: {total}");
        }

    }
}
