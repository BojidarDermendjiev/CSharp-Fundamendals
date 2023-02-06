namespace _10._LadyBugs
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            int fieldSize = int.Parse(Console.ReadLine());
            bool[] field = new bool[fieldSize];
            var inputFromConsole = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            foreach (var index in inputFromConsole)
            {
                if (index < 0 || index > field.Length)
                    continue;
                field[index] = true;
            }
            string line;
            while ((line = Console.ReadLine()) != "end")
            {
                var parts = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int index = int.Parse(parts[0]);
                string direction = parts[1];
                int length = int.Parse(parts[2]);
                if (index < 0 || index >= field.Length || !field[index])
                    continue;
                field[index] = false;
                while (true)
                {
                    if (direction == "right")
                        index += length;
                    else
                        index -= length;
                    if (index >= field.Length || index < 0)
                        break;
                    if (!field[index])
                    {
                        field[index] = true;
                        break;
                    }
                }
            }
            foreach (var cell in field)
            {
                if (cell)
                    Console.Write("1 ");
                else
                    Console.Write("0 ");
            }
        }
    }
}
