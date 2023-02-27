namespace _01._Furniture
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        static void Main()
        {
            string pattern, inputLineFromConsole;
            decimal totalPrice;
            List<string> purchasItems;
            GetInfo(out pattern, out totalPrice, out purchasItems);
            inputLineFromConsole = Engine(pattern, ref totalPrice, purchasItems);
            IO(totalPrice, purchasItems);
        }
        private static void GetInfo(out string pattern, out decimal totalPrice, out List<string> purchasItems)
        {
            pattern = @"\B>>(?<productName>[A-z]+)<<(?<price>\d+(.\d+)?)!(?<quantity>\d+)";
            totalPrice = default;
            purchasItems = new List<string>();
        }
        private static string Engine(string pattern, ref decimal totalPrice, List<string> purchasItems)
        {
            string inputLineFromConsole;
            while ((inputLineFromConsole = Console.ReadLine()) != "Purchase")
            {
                var matches = Regex.Match(inputLineFromConsole, pattern);
                if (matches.Success)
                {
                    var name = matches.Groups["productName"].Value;
                    var price = decimal.Parse(matches.Groups["price"].Value);
                    var quantity = int.Parse(matches.Groups["quantity"].Value);
                    purchasItems.Add(name);
                    totalPrice += price * quantity;
                }
            }

            return inputLineFromConsole;
        }
        private static void IO(decimal totalPrice, List<string> purchasItems)
        {
            Console.WriteLine("Bought furniture:");
            purchasItems.ForEach(Console.WriteLine);
            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
