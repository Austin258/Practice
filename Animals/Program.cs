namespace Animals
{
    public class Cat
    {
        // Field name 
        private string name;
        // Field color 
        private string color;

        public string Name
        {
            // Getter of the property "Name" 
            get
            {
                return this.name;
            }
            // Setter of the property "Name" 
            set
            {
                this.name = value;
            }
        }

        public string Color
        {
            // Getter of the property "Color" 
            get
            {
                return this.color;
            }
            // Setter of the property "Color" 
            set
            {
                this.color = value;
            }
        }

        // Default constructor 
        public Cat()
        {
            this.name = "Unnamed";
            this.color = "gray";
        }

        // Constructor with parameters 
        public Cat(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        // Method SayMiau 
        public void SayMiau()
        {
            Console.WriteLine("Cat {0} said: Miauuuuuu!", name);
        }
    }

    class Animal
    {
        private int legs;
        private string name;
        private string color;
        public void SetLegs(int _legs)
        {
            legs = _legs;
        }
        public void GetLegs()
        {
            Console.WriteLine(legs);
        }
        public void SetName(string _name)
        {
            name = _name;
        }
        public void GetName()
        {
            Console.WriteLine(name);
        }
        public void SetColor(string _color)
        {
            color = _color;
        }
        public void GetColor()
        {
            Console.WriteLine(color);
        }
        public Animal(int _legs, string _name, string _color)
        {
            legs = _legs;
            name = _name;
            color = _color;
        }
        public void eat()
        {
            Console.WriteLine(name + " moves");
        }
        public void move()
        {
            Console.WriteLine(name + " eats");
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Hello, World!");
            }
        }
    }
}
