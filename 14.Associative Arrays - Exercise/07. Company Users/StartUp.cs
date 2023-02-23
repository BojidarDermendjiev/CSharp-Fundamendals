using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Company_Users
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = Engine();
            IO(companies);
        }
        private static Dictionary<string, List<string>> Engine()
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();
            string inputLineFromConsole;
            while ((inputLineFromConsole = Console.ReadLine()) != "End")
            {
                string[] parts = inputLineFromConsole.Split(new string[] { " ", "->"}, StringSplitOptions.RemoveEmptyEntries);
                string company = parts[0];
                string employeeId = parts[1];
                if (!companies.ContainsKey(company))
                    companies.Add(company, new List<string>());
                companies[company].Add(employeeId);
            }
            return companies;
        }
        private static void IO(Dictionary<string, List<string>> companies)
        {
            foreach (var company in companies)
            {
                Console.WriteLine($"{company.Key}");
                foreach (var employee in company.Value
                    .Distinct()
                    .ToList())
                    Console.WriteLine($"-- {employee}");
            }
        }
    }
}
