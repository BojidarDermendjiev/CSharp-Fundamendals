namespace _06._Store_Boxes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        static void Main()
        {
            var products = new List<StoreBox>();
            Engine(products);
            Console.WriteLine(IO(products));
        }
        private static void Engine(List<StoreBox> products)
        {
            string inputLineFromConsole;
            while ((inputLineFromConsole = Console.ReadLine()) != "end")
            {
                var tokens = inputLineFromConsole.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                StoreBox box = new StoreBox(tokens[0], tokens[1], int.Parse(tokens[2]), decimal.Parse(tokens[3]));
                products.Add(box);
            }
        }
        private static string IO(List<StoreBox> products)
        {
            StringBuilder sb = new StringBuilder();
            var sortedProducts = products.OrderByDescending(p => p.ItemPrice * p.ItemQuantuty).ToList();
            foreach (var product in sortedProducts)
            {
                sb.AppendLine($"{product.SerialNumber}");
                sb.AppendLine($"-- {product.ItemName} - ${product.ItemPrice:f2}: {product.ItemQuantuty}");
                sb.AppendLine($"-- ${(product.ItemQuantuty * product.ItemPrice):f2}");
            }
            return sb.ToString().TrimEnd();
        }
    }
    public class StoreBox
    {
        public StoreBox(string serialNumber, string itemName, int itemQuantuty, decimal itemPrice) 
        {
            SerialNumber = serialNumber;
            ItemName = itemName;
            ItemQuantuty = itemQuantuty;
            ItemPrice = itemPrice;
        }

        public string SerialNumber { get; set; }
        public string ItemName { get; set; }
        public int ItemQuantuty { get; set; }
        public decimal ItemPrice { get; set; }
    }
}
