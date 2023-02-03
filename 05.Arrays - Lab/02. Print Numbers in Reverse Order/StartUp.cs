namespace _02._Print_Numbers_in_Reverse_Order
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            int range = int.Parse(Console.ReadLine());
            int[] array = new int[range];
            for (int currentNumber = 0; currentNumber < range; currentNumber++)
                array[currentNumber] = int.Parse(Console.ReadLine());
            //for(i = range - 1; i > 0; i--)
            //Console.Write(array[i] + " ");
            Console.WriteLine(string.Join(" ", array.Reverse()));
        }
    }
}
