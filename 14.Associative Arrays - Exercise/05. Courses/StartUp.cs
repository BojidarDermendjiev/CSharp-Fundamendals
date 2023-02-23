namespace _05._Courses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            Dictionary<string, List<string>> studentByCourse = Engine();
            IO(studentByCourse);
        }
        private static Dictionary<string, List<string>> Engine()
        {
            Dictionary<string, List<string>> studentByCourse = new Dictionary<string, List<string>>();
            string inputLineFromConsole;
            while ((inputLineFromConsole = Console.ReadLine()) != "end")
            {
                string[] parts = inputLineFromConsole.Split(" : ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string course = parts[0];
                string student = parts[1];

                if (!studentByCourse.ContainsKey(course))
                    studentByCourse.Add(course, new List<string>() { student });
                else
                    studentByCourse[course].Add(student);
            }
            return studentByCourse;
        }
        private static void IO(Dictionary<string, List<string>> studentByCourse)
        {
            foreach (var course in studentByCourse)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count()}");
                foreach (var name in course.Value)
                    Console.WriteLine($"-- {name}");
            }
        }
    }
}
