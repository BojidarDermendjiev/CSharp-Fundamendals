namespace _05._Students_2._0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            string inputLine;
            List<ParametersForStuden> studens = new List<ParametersForStuden>();
            GetInfo(out inputLine, studens);
            IO(studens);
        }
        private static void GetInfo(out string inputLine, List<ParametersForStuden> studens)
        {
            while ((inputLine = Console.ReadLine()) != "end")
            {
                var tokens = inputLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                ParametersForStuden studen = studens.FirstOrDefault(x => x.FirstName == tokens[0] && x.LastName == tokens[1]);
                if (studen == null)
                    studens.Add(new ParametersForStuden(tokens[0], tokens[1], int.Parse(tokens[2]), tokens[3]));
                else
                {
                    studen.FirstName = tokens[0];
                    studen.LastName = tokens[1];
                    studen.Age = int.Parse(tokens[2]);
                    studen.HomeTown = tokens[3];
                }
            }
        }
        private static void IO(List<ParametersForStuden> studens)
        {
            var town = Console.ReadLine();
            var filter = studens.Where(x => x.HomeTown == town).ToList();
            if (filter != null)
                foreach (var studen in filter)
                    Console.WriteLine($"{studen.FirstName} {studen.LastName} is {studen.Age} years old.");
        }
    }
    public class ParametersForStuden
    {
        public ParametersForStuden() { }
        public ParametersForStuden(string firstName, string lastName, int age, string homeTown) : this()
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}
