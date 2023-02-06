namespace _04._Array_Rotation
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            var array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int rotations = int.Parse(Console.ReadLine());
            for (int rotation = 0; rotation < rotations; rotation++)
            {
                var firstElement = array[0];
                for (int index = 1; index < array.Length; index++)
                    array[index - 1] = array[index];
                array[array.Length - 1] = firstElement; // switch first element to last.
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
