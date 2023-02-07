namespace _05._Orders
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            string product; int capacity;
            GetInfo(out product, out capacity);
            Console.WriteLine(CalculatePrice(product, capacity, PriceForProducts()) > 0 ? CalculatePrice(product, capacity, PriceForProducts()) : "You cannot give zero capacity! Try Again ;)");
        }

        private static decimal CalculatePrice(string product, int quantity, List<decimal> listOfPrices)
        {
            if(product == "coffee")
                return listOfPrices.First() * quantity;
            else if (product == "water")
                return listOfPrices.Skip(1).First() * quantity;
            else if(product == "coke")
                return listOfPrices.Skip(2).First() * quantity;
            else if(product == "snacks")
                return listOfPrices.Last() * quantity;
            else return 0;
        }

        private static void GetInfo(out string product, out int quantity)
        {
            product = Console.ReadLine().ToLower();
            quantity = int.Parse(Console.ReadLine());
        }

        public static List<decimal> PriceForProducts()
            => new List<decimal>() 
            {
                1.50m,
                1.00m,
                1.40m,
                2.00m
            };
    }
}
