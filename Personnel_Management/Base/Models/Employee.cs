using System;

namespace Personnel_Management.Models
{
    public abstract class Employee
    {
        public string ID;
        public string Name;
        public string Age;
        public double BasicSalary;


        public virtual double CalculateSalary()
        {
            return BasicSalary;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("ID cua nhan vien la : " + ID);
            Console.WriteLine("Họ và tên của nhân viên là : " + Name);
            Console.WriteLine("Tuổi của nhân viên là : " + Age);
            Console.WriteLine("Mức lương cơ bản của nhân viên là : " + BasicSalary);

        }

    }
}
