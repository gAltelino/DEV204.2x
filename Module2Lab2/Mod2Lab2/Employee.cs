namespace Mod2Lab2
{
    public class Employee
    {
        private string employeeName;
        private double employeeBaseSalary;
        private int employeeId;
        private static int employeeCount = 1;

        public string Name
        {
            get { return employeeName; }
            set { employeeName = value; }
        }

        public double BaseSalary
        {
            get { return employeeBaseSalary; }
            set { employeeBaseSalary = value; }
        }

        public int ID
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        public Employee(string name, double baseSalary)
        {
            this.Name = name;
            this.BaseSalary = baseSalary;
            this.ID = employeeCount++;
        }

        public double GetBaseSalary()
        {
            return this.BaseSalary;
        }

        public string GetName()
        {
            return this.Name;
        }

        public int GetEmployeeId()
        {
            return this.ID;
        }

        public string toString()
        {
            return this.ID + " " + this.Name;
        }

        public virtual string EmployeeStatus()
        {
            return this.toString() + " is in the company's system";
        }

    }
}