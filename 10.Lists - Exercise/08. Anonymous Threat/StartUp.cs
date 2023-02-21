namespace _08._Anonymous_Threat
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartUp
    {
        static void Main()
        {
            List<string> elements = GetInfo();
            Engine(elements);
            Io(elements);
        }
        private static List<string> GetInfo()
        {
            return Console.ReadLine()
                            .Split()
                            .ToList();
        }
        private static void Engine(List<string> elements)
        {
            string line;
            while ((line = Console.ReadLine()) != "3:1")
            {
                string[] parts = line.Split();
                string command = parts[0];
                if (command == "merge")
                {
                    int startInx = int.Parse(parts[1]);
                    int endIndx = int.Parse(parts[2]);
                    if (startInx >= elements.Count || endIndx < 0)
                    {
                        continue;
                    }
                    if (startInx < 0)
                    {
                        startInx = 0;
                    }
                    if (endIndx >= elements.Count)
                    {
                        endIndx = elements.Count - 1;
                    }
                    string merged = string.Empty;
                    for (int i = startInx; i <= endIndx; i++)
                    {
                        string element = elements[i];
                        merged += element;
                    }
                    elements.RemoveRange(startInx, endIndx - startInx + 1);
                    elements.Insert(startInx, merged);
                }
                else
                {
                    int idx = int.Parse(parts[1]);
                    int partitions = int.Parse(parts[2]);
                    string element = elements[idx];
                    elements.RemoveAt(idx);
                    int partiotionsSize = element.Length / partitions;
                    List<string> substrings = new List<string>();
                    for (int i = 0; i < partitions - 1; i++)
                    {
                        string substring = element.Substring(i * partiotionsSize, partiotionsSize);
                        substrings.Add(substring);
                    }
                    string lastSubstring = element.Substring((partitions - 1) * partiotionsSize);
                    substrings.Add(lastSubstring);
                    elements.InsertRange(idx, substrings);
                }
            }
        }
        private static void Io(List<string> elements)
        {
            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
