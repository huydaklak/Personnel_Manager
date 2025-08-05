using System;
using System.Globalization;
using Personnel_Management.Base.Interface;
using Personnel_Management.Models;
using Personnel_Management.Services;

namespace Personnel_Management.UI
{
    public class MenuManager : IMenuManager
    {
        private readonly IEmployeeManage employeeManager;


        public MenuManager()
        {
            employeeManager = new EmployeeManager();
        }

        public void ShowMainMenu()
        {
            Console.WriteLine("=========== MENU QUẢN LÝ NHÂN VIÊN =========== ");
            Console.WriteLine("1. Thêm nhân viên Full-Time");
            Console.WriteLine("2. Thêm nhân viên Part-Time");
            Console.WriteLine("3. Hiển thị tất cả nhân viên");
            Console.WriteLine("4. Tính tổng lương công ty");
            Console.WriteLine("5. Tìm nhân viên có lương cao nhất");
            Console.WriteLine("6. Tìm nhân viên theo tên");
            Console.WriteLine("7. Xoá nhân viên theo ID");
            Console.WriteLine("8. Sắp xếp nhân viên theo lương");
            Console.WriteLine("0. Thoát");
        }

        public void HandleOption(int option)
        {
            switch (option)
            {
                case 1:
                    InputFullTimeEmployee();
                    break;
                case 2:
                    InputPartTimeEmployee();
                    break;
                case 3:
                    employeeManager.DisplayAllEmployees();
                    break;
                case 4:
                    PromptCalculateTotalSalary();
                    break;
                case 5:
                    PromptFindHighestSalary();
                    break;
                case 6:
                    PromptSearchByName();
                    break;
                case 7:
                    PromptDeleteById();
                    break;
                case 8:
                    employeeManager.SortEmployeesBySalary();
                    Console.WriteLine("Danh sách nhân viên đã được sắp xếp theo lương.");
                    break;
                case 0:
                    Console.WriteLine("Cảm ơn bạn đã sử dụng chương trình. Tạm biệt!");
                    Environment.Exit(0); // Thoát chương trình
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ, vui lòng nhập lại");
                    break;

            }
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
            Console.Write("Nhập ID để xóa : ");
            string id = Console.ReadLine();
            employeeManager.RemoveEmployeeById(id);
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

        public void Run()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            while (true)
            {
                ShowMainMenu();
                Console.WriteLine();
                Console.Write("Vui lòng nhập từ (1 -> 7) và 0 để thoát chương trình :  ");
                Console.WriteLine();
                if (int.TryParse(Console.ReadLine(), out int option))
                {
                    HandleOption(option);
                }
                else
                {
                    Console.WriteLine("Vui lòng nhập từ (1 -> 7) và 0 để thoát chương trình ");
                }
            }
        }
    }
}
