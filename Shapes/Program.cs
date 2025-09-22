namespace Shapes
{
    public abstract class Shape
    {
        public abstract void GetArea();
        public abstract void GetPerimeter();
    }
    public class Rectangle : Shape
    {
        private int length;
        private int width;
        public int Length
        {
            get { return length; }
            set { length = value; }
        }
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        public override void GetArea()
        {
            Console.WriteLine("Area of rectangle: " + length * width);
        }
        public override void GetPerimeter()
        {
            Console.WriteLine("Perimeter of rectangle: " + 2 * (length + width));
        }
    }
    public class Circle : Shape
    {
        private int radius;
        private const double PI = 3.14;
        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public override void GetArea()
        {
            Console.WriteLine("Area of circle: " + PI * radius * radius);
        }
        public override void GetPerimeter()
        {
            Console.WriteLine("Perimeter of circle: " + (int)(2 * PI * radius));
        }
    }
    public class Triangle : Shape
    {
        private int baseLength;
        private int height;
        public int BaseLength
        {
            get { return baseLength; }
            set { baseLength = value; }
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        public override void GetArea()
        {
            Console.WriteLine("Area of triangle: " + (baseLength * height) / 2);
        }
        public override void GetPerimeter()
        {
            Console.WriteLine("Perimeter of triangle: " + (baseLength + height + (int)(Math.Sqrt(baseLength * baseLength + height * height))));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            Circle circle = new Circle();
            circle.Radius = 5;
            circle.GetArea();
            circle.GetPerimeter();
            Rectangle rectangle = new Rectangle();
            rectangle.Length = 10;
            rectangle.Width = 5;
            rectangle.GetArea();
            rectangle.GetPerimeter();
            Triangle triangle = new Triangle();
            triangle.BaseLength = 10;
            triangle.Height = 5;
            triangle.GetArea();
            triangle.GetPerimeter();
            shapes.Add(circle);
            shapes.Add(rectangle);
            shapes.Add(triangle);
            foreach (var shape in shapes)
            {
                shape.GetArea();
                shape.GetPerimeter();
            }
        }
    }
}
