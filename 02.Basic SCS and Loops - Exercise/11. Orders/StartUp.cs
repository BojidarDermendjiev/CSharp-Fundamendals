namespace _11._Orders
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int countOfOrdersTheShop = int.Parse(Console.ReadLine());
            decimal allOrdersCost = 0;
            for (int i = 0; i < countOfOrdersTheShop; i++)
            {
                decimal priceCapsule = decimal.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsules = int.Parse(Console.ReadLine());
                decimal orderPrice = priceCapsule * days * capsules;
                Console.WriteLine($"The price for the coffee is: ${orderPrice:f2}");
                allOrdersCost += orderPrice;
            }
            Console.WriteLine($"Total: ${allOrdersCost:f2}");
        }
    }
}
