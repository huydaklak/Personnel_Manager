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
    }
}
