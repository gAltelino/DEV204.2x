namespace Mod2Lab2
{
    public class BusinessEmployee : Employee
    {
        public BusinessEmployee(string name) : base(name, 50000) { }
        public double BonusBudget = 1000;

        public override string EmployeeStatus()
        {
            return this.toString() + " with a budget of " + this.BonusBudget.ToString();
        }



    }
}