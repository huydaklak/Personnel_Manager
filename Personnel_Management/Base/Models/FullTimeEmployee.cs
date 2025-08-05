namespace Personnel_Management.Models
{
    public class FullTimeEmployee : Employee
    {
        public double Bonus;
        public double Penalty;


        public override double CalculateSalary()
        {
            return BasicSalary + Bonus - Penalty;
        }
    }
}
