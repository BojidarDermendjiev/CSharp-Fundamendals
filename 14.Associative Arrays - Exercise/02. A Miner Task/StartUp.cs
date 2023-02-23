namespace _02._A_Miner_Task
{
    using System;
    using System.Collections.Generic;
    public class StartUp
    {
        static void Main()
        {
            Dictionary<string, int> quantityByResource = Engine();
            IO(quantityByResource);
        }
        private static Dictionary<string, int> Engine()
        {
            Dictionary<string, int> quantityByResource = new Dictionary<string, int>();
            string inputLineFromConsole;
            while ((inputLineFromConsole = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!quantityByResource.ContainsKey(inputLineFromConsole))
                    quantityByResource.Add(inputLineFromConsole, quantity);
                else
                    quantityByResource[inputLineFromConsole += quantity;
            }

            return quantityByResource;
        }
        private static void IO(Dictionary<string, int> quantityByResource)
        {
            foreach (var kvp in quantityByResource)
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
        }
    }
}
