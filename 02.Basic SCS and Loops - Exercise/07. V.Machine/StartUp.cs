namespace _07._V.Machine
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            double[] coinValues = { 0.1, 0.2, 0.5, 1, 2 };
            string[] products = { "Nuts", "Water", "Crisps", "Soda", "Coke" };
            double[] prices = { 2.0, 0.7, 1.5, 0.8, 1.0 };
            double balance = 0;
            string input;
            while ((input = Console.ReadLine()) != "Start")
            {
                double coin = double.Parse(input);
                if (coinValues.Contains(coin))
                    balance += coin;
                else
                    Console.WriteLine($"Cannot accept {coin}");
            }

            while ((input = Console.ReadLine()) != "End")
            {
                if (!products.Contains(input))
                {
                    Console.WriteLine("Invalid product");
                    continue;
                }
                for (int i = 0; i < 5; i++)
                    if (input == products[i])
                    {
                        if (balance - prices[i] < 0) 
                            Console.WriteLine("Sorry, not enough money");
                        else
                        {
                            Console.WriteLine($"Purchased {input.ToLower()}");
                            balance -= prices[i];
                        }
                        break;
                    }
            }
            Console.WriteLine($"Change: {balance:f2}");
        }
    }
}
