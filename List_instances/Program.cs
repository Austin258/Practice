namespace List_instances
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);
            numbers.Add(6);
            numbers.Add(7);
            numbers.Add(8);
            numbers.Add(9);
            numbers.Add(10);

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            int max = Math.Max(numbers[0], Math.Max(numbers[1], Math.Max(numbers[2], Math.Max(numbers[3], Math.Max(numbers[4], Math.Max(numbers[5], Math.Max(numbers[6], Math.Max(numbers[7], Math.Max(numbers[8], numbers[9])))))))));
            Console.WriteLine("The maximum integer in the list is " + max);
            int min = Math.Min(numbers[0], Math.Min(numbers[1], Math.Min(numbers[2], Math.Min(numbers[3], Math.Min(numbers[4], Math.Min(numbers[5], Math.Min(numbers[6], Math.Min(numbers[7], Math.Min(numbers[8], numbers[9])))))))));
            Console.WriteLine("The minimum integer in the list is " + min);

            Console.WriteLine("Enter a number you are searching for: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            if (numbers.Contains(number2))
            {
                Console.WriteLine("The number is in the list");
            }
            else
            {
                Console.WriteLine("The number is not in the list");
            }

            numbers[0] = numbers[9];
            numbers[1] = numbers[8];
            numbers[2] = numbers[7];
            numbers[3] = numbers[6];
            numbers[4] = numbers[5];
            numbers[5] = numbers[4] - 1;
            numbers[6] = numbers[3] - 3;
            numbers[7] = numbers[2] - 5;
            numbers[8] = numbers[1] - 7;
            numbers[9] = numbers[0] - 9;
            Console.WriteLine("Reversed list: ");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
