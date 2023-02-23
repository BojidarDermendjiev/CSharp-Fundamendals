namespace _06._Student_Academy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartUp
    {
        static void Main()
        {
            Dictionary<string, List<double>> students = Engine();
            Dictionary<string, double> sortedStudent = Sorted(students);
            IO(sortedStudent);
        }
        private static Dictionary<string, List<double>> Engine()
        {
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
            int number = int.Parse(Console.ReadLine());
            for (int currentStudent = 0; currentStudent < number; currentStudent++)
            {
                string studentsName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!students.ContainsKey(studentsName))
                    students.Add(studentsName, new List<double>());
                students[studentsName].Add(grade);
            }

            return students;
        }
        private static Dictionary<string, double> Sorted(Dictionary<string, List<double>> students)
            => students
                .Select(s => new KeyValuePair<string, double>(s.Key, s.Value.Average())).Where(s => s.Value >= 4.50).ToDictionary(x => x.Key, x => x.Value);
        private static void IO(Dictionary<string, double> sortedStudent)
        {
            foreach (var student in sortedStudent)
            {
                Console.WriteLine($"{student.Key} -> {student.Value:f2}");
            }
        }
    }
}
