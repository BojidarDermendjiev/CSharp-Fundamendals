﻿namespace _02._Grades
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            var grade = double.Parse(Console.ReadLine());
            Console.WriteLine(GetCorrespondingGrade(grade));
        }

        private static string GetCorrespondingGrade(double grade)
        {
            if (grade >= 2.00 && grade <= 2.99)
                return "Fail";
            else if (grade >= 3.00 && grade <= 3.49)
                return "Poor";
            else if (grade >= 3.50 && grade <= 4.49)
                return "Good";
            else if (grade >= 4.50 && grade <= 5.49)
                return "Very good";
            else if (grade >= 5.50 && grade <= 6.00)
                return "Excellent";
            return null;
        }
    }
}
