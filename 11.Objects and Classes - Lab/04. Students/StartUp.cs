namespace _04._Students
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
                var studen = new ParametersForStuden(tokens[0], tokens[1], int.Parse(tokens[2]), tokens[3]);
                studens.Add(studen);
            }
        }
        private static void IO(List<ParametersForStuden> studens)
        {
            var town = Console.ReadLine();
            var filter = studens.Where(x => x.HomeTown == town).ToList();
            if(filter != null)
                foreach (var studen in filter)
                    Console.WriteLine($"{studen.FirstName} {studen.LastName} is {studen.Age} years old.");
        }
    }
    public class ParametersForStuden
    {
        public ParametersForStuden(string firstName, string lastName, int age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public string HomeTown { get; private set; }
    }
}
