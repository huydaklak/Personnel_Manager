namespace Personnel_Management.Models
{
    public class PartTimeEmployee : Employee
    {
        public int WorkingHours;
        public double HourlyRate;

        public override double CalculateSalary()
        {
            return WorkingHours * HourlyRate;
        }
    }
}
