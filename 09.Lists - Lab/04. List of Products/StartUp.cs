namespace _04._List_of_Products
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main()
        {
            int readNumberFromConsole;
            var products = new List<string>();
            GetInfo(out readNumberFromConsole, ref products);
            PrintProducts(products);
        }


        private static void GetInfo(out int readNumberFromConsole, ref List<string> products)
        {
            readNumberFromConsole = int.Parse(Console.ReadLine());
            for (int i = 0; i < readNumberFromConsole; i++)
                products.Add(Console.ReadLine());
        }
        private static void PrintProducts(List<string> products)
        {
            int numberOfProduct = default;
            foreach (var product in products.OrderBy(x => x))
                Console.WriteLine($"{++numberOfProduct}.{product}");
        }
    }
}
