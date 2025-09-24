namespace Product_
{
    public class Product
    {
        private string name;
        private double price;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
    }
    public class OrderItems : Product
    {
        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public void TotalItemCost()
        {
            Console.WriteLine("Total cost of item: " + Price * quantity);
        }
    }
    public class Order : OrderItems
    {
        private List<OrderItems> items = new List<OrderItems>();
        public List<OrderItems> Items
        {
            get { return items; }
            set { items = value; }
        }
        public void TotalOrderCost()
        {
            double total = 0;
            foreach (var item in items)
            {
                total += item.Price * item.Quantity;
            }
            Console.WriteLine("Total cost of order: " + total);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderItems orderItems = new OrderItems();
            orderItems.Name = "Apple";
            orderItems.Price = 1.5;
            orderItems.Quantity = 2;
            orderItems.TotalItemCost();
            OrderItems orderItems2 = new OrderItems();
            orderItems2.Name = "Banana";
            orderItems2.Price = 1.0;
            orderItems2.Quantity = 3;
            orderItems2.TotalItemCost();
            OrderItems orderItems3 = new OrderItems();
            orderItems3.Name = "Orange";
            orderItems3.Price = 2.0;
            orderItems3.Quantity = 1;
            orderItems3.TotalItemCost();
            Order order = new Order();
            order.Items.Add(orderItems);
            order.Items.Add(orderItems2);
            order.Items.Add(orderItems3);
            order.TotalOrderCost();
            foreach (var item in order.Items)
            {
                Console.WriteLine("Name: " + item.Name);
                Console.WriteLine("Price: " + item.Price);
                Console.WriteLine("Quantity: " + item.Quantity);
                Console.WriteLine("----------------------------------------");
            }
        }
    }
}
