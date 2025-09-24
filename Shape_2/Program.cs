namespace Shape_2
{
    public abstract class Shape
    {
        // Removed PI and Radius from base class, as they are specific to Circle.
        public abstract void GetArea();
    }

    public class Circle : Shape
    {
        private const double PI = 3.14;
        private int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public int Radius
        {
            get { return radius; }
            set { this.radius = value; }
        }

        public override void GetArea()
        {
            Console.WriteLine("Area of circle: {0}", PI * radius * radius);
        }
    }

    public class Triangle : Shape
    {
        private int baseLength;
        private int height;

        public Triangle(int baseLength, int height)
        {
            this.baseLength = baseLength;
            this.height = height;
        }

        public int BaseLength
        {
            get { return baseLength; }
            set { this.baseLength = value; }
        }

        public int Height
        {
            get { return height; }
            set { this.height = value; }
        }

        public override void GetArea()
        {
            Console.WriteLine("Area of triangle: {0}", (baseLength * height) / 2);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Triangle triangle = new Triangle(10, 5);
            triangle.GetArea();
        }
    }
}