namespace _03._SoftUni_Bar_Income
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    class ValidOrder
    {
        public ValidOrder(string name, string product, int count, decimal price)
        {
            this.Name = name;
            this.Product = product;
            this.Price = price;
            this.Count = count;
        }
        public string Name { get; set; }
        public string Product { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
        public override string ToString()
        => $"{this.Name}: {this.Product} - {this.Price * this.Count:f2}";
    }
    public class StartUp
    {
        static void Main()
        {
            List<ValidOrder> validOrders;
            string pattern;
            GetInfo(out validOrders, out pattern);
            Engine(validOrders, pattern);
            IO(validOrders);
        }
        private static void GetInfo(out List<ValidOrder> validOrders, out string pattern)
        {
            validOrders = new List<ValidOrder>();
            pattern = @"%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>[\w]+)>[^|$%.]*\|(?<quantity>[\d]+)\|[^|$%.]*?(?<price>[\d]+.?[\d]+)?\$";
        }
        private static void Engine(List<ValidOrder> validOrders, string pattern)
        {
            string inputLineFromConsole;
            while ((inputLineFromConsole = Console.ReadLine()) != "end of shift")
            {
                Regex regex = new Regex(pattern);
                bool isValid = regex.IsMatch(inputLineFromConsole);
                if (isValid)
                {
                    string cutomer = regex.Match(inputLineFromConsole).Groups["customer"].Value;
                    string product = regex.Match(inputLineFromConsole).Groups["product"].Value;
                    int quantity = int.Parse(regex.Match(inputLineFromConsole).Groups["quantity"].Value);
                    decimal price = decimal.Parse(regex.Match(inputLineFromConsole).Groups["price"].Value);
                    validOrders.Add(new ValidOrder(cutomer, product, quantity, price));
                }
            }
        }
        private static void IO(List<ValidOrder> validOrders)
        {
            foreach (ValidOrder validOrder in validOrders)
                Console.WriteLine(validOrder.ToString());
            Console.WriteLine($"Total income: {(validOrders.Sum(x => x.Price * x.Count)):f2}");
        }
    }
}
