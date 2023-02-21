namespace _09._Pokemon_Don_t_Go
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class StartUp
    {
        static void Main()
        {
            List<int> sequence = GetInfo();
            int index;
            int currentValue;
            int sum = default;
            while (sequence.Count != 0)
            {
                index = int.Parse(Console.ReadLine());
                if (index < 0)
                {
                    currentValue = sequence[0];
                    sum += currentValue;
                    sequence[0] = sequence[sequence.Count - 1];
                }
                else if (index > sequence.Count - 1)
                {
                    currentValue = sequence[sequence.Count - 1];
                    sum += currentValue;
                    sequence[sequence.Count - 1] = sequence[0];
                }
                else
                {
                    currentValue = sequence[index];
                    sum += currentValue;
                    sequence.RemoveAt(index);
                }
                for (int i = 0; i < sequence.Count; i++)
                {
                    if (sequence[i] <= currentValue)
                        sequence[i] += currentValue;
                    else
                        sequence[i] -= currentValue;
                }
            }
            IO(sum);
        }
        private static List<int> GetInfo()
            =>Console.ReadLine().Split().Select(int.Parse).ToList();
        private static void IO(int sum)
        {
            Console.WriteLine(sum);
        }
    }
}
