namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(@$"Hello, {name}!
 Welcome to the calculator!
 ------------------------------------------------------------------------------
 What problem do you want to solve today:
 Choose any one of the operations(add, subtract, multiply, divide, factorial, power, permutation, combination, numerical conversions)");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Enter the operation:");
            string answer = Console.ReadLine();
            if (answer == "add" || answer == "subtract" || answer == "multiply" || answer == "divide" || answer == "power" || answer == "permutation" || answer == "combination")
            {
                Console.WriteLine("Enter the first number:");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second number:");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("                                                    ");
                if (answer == "add")
                {
                    Console.WriteLine("= " + Add(a, b));
                }
                else if (answer == "subtract")
                {
                    Console.WriteLine("= " + Subtract(a, b));
                }
                else if (answer == "multiply")
                {
                    Console.WriteLine("= " + Multiply(a, b));
                }
                else if (answer == "divide")
                {
                    Console.WriteLine("= " + Divide(a, b));
                }
                else if (answer == "power")
                {
                    Console.WriteLine("= " + Power(a, b));
                }
                else if (answer == "permutation")
                {
                    Console.WriteLine("= " + Permutation(a, b));
                }
                else if (answer == "combination")
                {
                    Console.WriteLine("= " + Combination(a, b));
                }
            }
            else if (answer == "factorial")
            {
                Console.WriteLine("Enter the number:");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("= " + Factorial(c));
            }
            else if (answer == "numerical conversions")
            {
                Console.WriteLine("What conversion do you want to perform? (binary to decimal, decimal to binary, decimal to hexadecimal, hexadecimal to decimal, decimal to octal, octal to decimal)");
                string answer1 = Console.ReadLine();
                if (answer1 == "binary to decimal")
                {
                    Console.WriteLine("Enter the binary number:");
                    string binary = Console.ReadLine();
                    int decimalNumber = Convert.ToInt32(binary, 2);
                    Console.WriteLine();
                    Console.WriteLine("= " + decimalNumber);
                }
                else if (answer1 == "decimal to binary")
                {
                    Console.WriteLine("Enter the decimal number:");
                    int decimalNumber = Convert.ToInt32(Console.ReadLine());
                    string binary = Convert.ToString(decimalNumber, 2);
                    Console.WriteLine();
                    Console.WriteLine("= " + binary);
                }
                else if (answer1 == "decimal to hexadecimal")
                {
                    Console.WriteLine("Enter the decimal number:");
                    int decimalNumber = Convert.ToInt32(Console.ReadLine());
                    string hexadecimal = Convert.ToString(decimalNumber, 16);
                    Console.WriteLine();
                    Console.WriteLine("= " + hexadecimal.ToUpper());
                }
                else if (answer1 == "hexadecimal to decimal")
                {
                    Console.WriteLine("Enter the hexadecimal number:");
                    string hexadecimal = Console.ReadLine();
                    int decimalNumber = Convert.ToInt32(hexadecimal, 16);
                    Console.WriteLine();
                    Console.WriteLine("= " + decimalNumber);
                }
                else if (answer1 == "decimal to octal")
                {
                    Console.WriteLine("Enter the decimal number:");
                    int decimalNumber = Convert.ToInt32(Console.ReadLine());
                    string octal = Convert.ToString(decimalNumber, 8);
                    Console.WriteLine();
                    Console.WriteLine("= " + octal);
                }
                else if (answer1 == "octal to decimal")
                {
                    Console.WriteLine("Enter the octal number:");
                    string octal = Console.ReadLine();
                    int decimalNumber = Convert.ToInt32(octal, 8);
                    Console.WriteLine();
                    Console.WriteLine("= " + decimalNumber);
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
                Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Do you want to solve another problem? (yes/no)");
            string answer2 = Console.ReadLine();
            if (answer2 == "yes")
            {
                Console.WriteLine("Choose any of these problems(trignometric ratios, Pythagoras theorem,quadratic equations, linear equations)");
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("Enter the problem:");
                string answer3 = Console.ReadLine();
                if (answer3 == "trignometric ratios")
                {
                    Console.WriteLine("What are you finding? (sin, cos, tan, side)");
                    string answer4 = Console.ReadLine();
                    if (answer4 == "sin")
                    {
                        Console.WriteLine("Enter the opposite side:");
                        int d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the hypotenuse:");
                        int e = Convert.ToInt32(Console.ReadLine());
                        int f = d / e;
                        Console.WriteLine();
                        Console.WriteLine("= " + radiansToDegrees(Math.Asin(f)));
                    }
                    else if (answer4 == "cos")
                    {
                        Console.WriteLine("Enter the adjacent side:");
                        int f = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the hypotenuse:");
                        int g = Convert.ToInt32(Console.ReadLine());
                        int h = f / g;
                        Console.WriteLine();
                        Console.WriteLine("= " + radiansToDegrees(Math.Acos(h)));
                    }
                    else if (answer4 == "tan")
                    {
                        Console.WriteLine("Enter the opposite side:");
                        int h = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the adjacent side:");
                        int i = Convert.ToInt32(Console.ReadLine());
                        int j = h / i;
                        Console.WriteLine();
                        Console.WriteLine("= " + radiansToDegrees(Math.Atan(j)));
                    }
                    else if (answer4 == "side")
                    {
                        Console.WriteLine("What side are you finding? (opposite, adjacent, hypotenuse)");
                        string answer5 = Console.ReadLine();
                        if (answer5 == "opposite")
                        {
                            Console.WriteLine("Enter the sine value:");
                            double j = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the hypotenuse:");
                            double k = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            Console.WriteLine("= " + (Math.Sin(degreesToRadians(j)) * k));
                        }
                        else if (answer5 == "adjacent")
                        {
                            Console.WriteLine("Enter the cosine value:");
                            double l = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the hypotenuse:");
                            double m = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            Console.WriteLine("= " + (Math.Cos(degreesToRadians(l) * m)));
                        }
                        else if (answer5 == "hypotenuse")
                        {
                            Console.WriteLine("Enter the sine value:");
                            double n = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the opposite side:");
                            double o = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            Console.WriteLine("= " + (Math.Sin(degreesToRadians(o) / n)));
                        }
                    }
                }
                else if (answer3 == "Pythagoras theorem")
                {
                    Console.WriteLine("What are you finding? (hypotenuse, opposite, adjacent)");
                    string answer6 = Console.ReadLine();
                    if (answer6 == "hypotenuse")
                    {
                        Console.WriteLine("Enter the opposite side:");
                        int p = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the adjacent side:");
                        int q = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("= " + Math.Sqrt((p * p) + (q * q)));
                    }
                    else if (answer6 == "opposite")
                    {
                        Console.WriteLine("Enter the hypotenuse:");
                        int r = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the adjacent side:");
                        int s = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("= " + Math.Sqrt((r * r) - (s * s)));
                    }
                    else if (answer6 == "adjacent")
                    {
                        Console.WriteLine("Enter the hypotenuse:");
                        int t = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the opposite side:");
                        int u = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("= " + Math.Sqrt((t * t) - (u * u)));
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }
                else if (answer3 == "quadratic equations")
                {
                    Console.WriteLine("Enter the value of squared value(a):");
                    int v = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the value of the coefficient(b):");
                    int w = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the value of the constant(c):");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("= " + (-w + (Math.Sqrt((w * w) - (4 * v * x)))) / (2 * v) + " and " + (-w - (Math.Sqrt((w * w) - (4 * v * x)))) / (2 * v));
                }
                else if (answer3 == "linear equations")
                {
                    Console.WriteLine("Enter the value of the first coefficient(ax):");
                    int y = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the value of the second coefficient(by):");
                    int z = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the value of the constant(c1):");
                    int aa = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the value of the third coefficient(dx):");
                    int ab = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the value of the fourth coefficient(ey):");
                    int ac = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the value of the constant(c2):");
                    int ad = Convert.ToInt32(Console.ReadLine());
                    double x = (z * ad) - (ac * aa);
                    double x3 = (z * ab) - (y * ac);
                    double x1 = x / x3;
                    double y3 = (y * ad) - (ab * aa);
                    double y2 = (y * ac) - (z * ab);
                    double y1 = y3 / y2;
                    Console.WriteLine();
                    Console.WriteLine("= " + x1 + " and " + y1);
                }
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("Thanks for using the calculator, " + name);
            }
            else if (answer2 == "no")
            {
                Console.WriteLine("Thanks for using the calculator, " + name);
            }





            // Functions for the calculator

            static int Add(int a, int b)
            {
                return a + b;
            }
            static int Subtract(int a, int b)
            {
                return a - b;
            }
            static int Multiply(int a, int b)
            {
                return a * b;
            }
            static int Divide(int a, int b)
            {
                return a / b;
            }
            static int Factorial(int a)
            {
                int result = 1;
                for (int i = 1; i <= a; i++)
                {
                    result *= i;
                }
                return result;
            }
            static double Power(int a, int b)
            {
                double result = Math.Pow(a, b);
                return result;
            }
            static int Permutation(int a, int b)
            {
                int result = Factorial(a) / Factorial(a - b);
                return result;
            }
            static int Combination(int a, int b)
            {
                int result = Factorial(a) / (Factorial(b) * Factorial(a - b));
                return result;
            }
            static double degreesToRadians(double degrees)
            {
                return degrees * Math.PI / 180;
            }
            static double radiansToDegrees(double radians)
            {
                return radians * 180 / Math.PI;
            }
        }
    }
}
