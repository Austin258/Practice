namespace Employee
{
    public class Employee
    {
        private string name;
        private string position;
        private long salary;
        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }
        public string Position
        {
            get { return position; }
            set { this.position = value; }
        }
        public long Salary
        {
            get { return salary; }
            set { this.salary = value; }
        }
        public Employee(string name, string position, long salary)
        {
            Name = name;
            Position = position;
            Salary = salary;
        }
        public long IncreaseSalary(double percent)
        {
            Salary += (long)(Salary * percent);
            return Salary;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("John", "Manager", 100000);
            Console.WriteLine("Name: " + employee.Name);
            Console.WriteLine("Position: " + employee.Position);
            Console.WriteLine("Salary: " + employee.Salary);
            Console.WriteLine("Increased Salary: " + employee.IncreaseSalary(0.1));
        }
    }
}
