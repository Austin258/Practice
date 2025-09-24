namespace Person
{
    public class Person
    {
        private string name;
        private int age;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
    public class Student : Person
    {
        private int grade;
        public int Grade
        {
            get { return grade; }
            set { grade = value; }
        }
        public void Study()
        {
            Console.WriteLine("{0} is studying.", Name);
        }
    }
    public class Teacher : Person
    {
        private string subject;
        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }
        public void Teach()
        {
            Console.WriteLine("{0} is teaching.", Name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();
            teacher.Name = "John";
            teacher.Age = 30;
            teacher.Subject = "Math";
            teacher.Teach();
        }
    }
}
