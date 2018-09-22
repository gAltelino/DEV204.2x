namespace Mod2Lab2
{
    public class TechnicalEmployee : Employee
    {
        public int SucessfulCheckIns = 5;
        public TechnicalEmployee(string name) : base(name, 7500)
        {

        }

        public override string EmployeeStatus()
        {
            return this.toString() + " has " + this.SucessfulCheckIns.ToString() + " sucessusful checkins";
        }
    }
}