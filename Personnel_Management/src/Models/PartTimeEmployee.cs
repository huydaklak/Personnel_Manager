using System;

namespace Personnel_Management.Models
{
    public class PartTimeEmployee : Employee
    {
        public int WorkingHours { get; set; }
        public double HourlyRate { get; set; }

        public override double CalculateSalary()
        {
            return WorkingHours * HourlyRate;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Số giờ làm: " + WorkingHours);
            Console.WriteLine("Lương theo giờ: " + HourlyRate);
        }
    }
}
