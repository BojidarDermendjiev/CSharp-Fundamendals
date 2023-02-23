namespace _04._Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        static void Main()
        {
            List<Studen> studens = new List<Studen>();
            GetInfo(studens);
            IO(studens);
        }
        private static void GetInfo(List<Studen> studens)
        {
            var countOfStudents = int.Parse(Console.ReadLine());
            for (int currentStudent = 0; currentStudent < countOfStudents; currentStudent++)
            {
                var inputLineFromConsole = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Studen studen = new Studen(inputLineFromConsole[0], inputLineFromConsole[1], double.Parse(inputLineFromConsole[2]));
                studens.Add(studen);
            }
        }
        private static void IO(List<Studen> studens)
        {
            foreach (var student in studens.OrderByDescending(x => x.Grade))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }
    public class Studen
    {
        public Studen(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
    }
}
