namespace _05.Exercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            var dataForMonth = new Dictionary<int, string>()
            {
                {1, "January" },
                {2, "February" },
                {3, "March" },
                {4, "April" },
                {5, "May" },
                {6, "June" },
                {7, "July" },
                {8, "August" },
                {9, "September" },
                {10, "Octorber" },
                {11, "November" },
                {12, "December" },
            };
            var numberOfMonth = int.Parse(Console.ReadLine());
            var month = dataForMonth.FirstOrDefault(x => x.Key == numberOfMonth).Value;
            var message = dataForMonth.ContainsKey(numberOfMonth) ? $"{month}" : "Error!";
            Console.WriteLine(message);
        }
    }
}
