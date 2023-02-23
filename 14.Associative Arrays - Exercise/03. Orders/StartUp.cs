namespace _03._Orders
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main()
        {
            Dictionary<string, decimal> priceByProduct;
            Dictionary<string, int> quantityByProduct;
            DataForProducts(out priceByProduct, out quantityByProduct);
            Engine(priceByProduct, quantityByProduct);
            IO(priceByProduct, quantityByProduct);
        }
        private static void DataForProducts(out Dictionary<string, decimal> priceByProduct, out Dictionary<string, int> quantityByProduct)
        {
            priceByProduct = new Dictionary<string, decimal>();
            quantityByProduct = new Dictionary<string, int>();
        }
        private static void Engine(Dictionary<string, decimal> priceByProduct, Dictionary<string, int> quantityByProduct)
        {
            string inputLineFromConsole;
            while ((inputLineFromConsole = Console.ReadLine()) != "buy")
            {
                string[] parts = inputLineFromConsole.Split();
                string product = parts[0];
                decimal price = decimal.Parse(parts[1]);
                int quantity = int.Parse(parts[2]);
                if (!priceByProduct.ContainsKey(product))
                {
                    priceByProduct.Add(product, price);
                    quantityByProduct.Add(product, quantity);
                }
                else
                {
                    quantityByProduct[product] += quantity;
                    priceByProduct[product] = price;
                }
            }
        }
        private static void IO(Dictionary<string, decimal> priceByProduct, Dictionary<string, int> quantityByProduct)
        {
            foreach (var kvp in priceByProduct)
            {
                string product = kvp.Key;
                decimal price = kvp.Value;
                int quantity = quantityByProduct[product];
                decimal totalPrice = quantity * price;
                Console.WriteLine($"{product} -> {totalPrice:f2}");
            }
        }
    }
}
