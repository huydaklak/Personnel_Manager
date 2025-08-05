namespace Personnel_Management.Models
{
    public class FullTimeEmployee : Employee
    {
        public double Bonus { get; set; }
        public double Penalty { get; set; }


        public override double CalculateSalary()
        {
            return BasicSalary + Bonus - Penalty;
        }
    }
}
