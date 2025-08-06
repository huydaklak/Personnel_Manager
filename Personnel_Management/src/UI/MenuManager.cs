using System;
using Personnel_Management.Base.Interface;
using Personnel_Management.Services;
using Personnel_Management.src.Interface;
using Personnel_Management.src.UI;

namespace Personnel_Management.UI
{
    public class MenuManager : IMenuManager
    {
        private readonly IEmployeeManage employeeManager;
        private readonly IEmployeeUI employeeUI;
        public MenuManager()
        {
            employeeManager = new EmployeeManager();
            employeeUI = new EmployeeUI(employeeManager);
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
                    employeeUI.InputFullTimeEmployee();
                    break;
                case 2:
                    employeeUI.InputPartTimeEmployee();
                    break;
                case 3:
                    employeeManager.DisplayAllEmployees();
                    break;
                case 4:
                    employeeUI.PromptCalculateTotalSalary();
                    break;
                case 5:
                    employeeUI.PromptFindHighestSalary();
                    break;
                case 6:
                    employeeUI.PromptSearchByName();
                    break;
                case 7:
                    employeeUI.PromptDeleteById();
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

        public void Run()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            while (true)
            {
                ShowMainMenu();
                Console.WriteLine();
                Console.Write("Vui lòng nhập từ (1 -> 8) và 0 để thoát chương trình :  ");
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
