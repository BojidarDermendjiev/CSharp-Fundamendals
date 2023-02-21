namespace _10.SoftUniCoursePlanning
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            List<string> list = Console.ReadLine()
                .Split(", ")
                .ToList();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "course start")
            {
                string[] command = input.Split(":");
                list = SoftUniCoursePlanning(list, command);
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{list[i]}");
            }
        }

        static List<string> SoftUniCoursePlanning(List<string> list, string[] command)
        {
            switch (command[0])
            {
                case "Add":
                    list = Add(list, command);
                    break;
                case "Insert":
                    list = Insert(list, command);
                    break;
                case "Remove":
                    list = Remove(list, command);
                    break;
                case "Swap":
                    list = Swap(list, command);
                    break;
                case "Exercise":
                    list = Exercise(list, command);
                    break;
                default:
                    break;
            }
            return list;
        }

        static List<string> Exercise(List<string> list, string[] command)
        {
            string lessonTitle = command[1];
            if (list.Contains(lessonTitle) && !list.Contains(lessonTitle + "-Exercise"))
            {
                int index = list.IndexOf(lessonTitle);
                list.Insert(index + 1, lessonTitle + "-Exercise");
            }
            else if (!list.Contains(lessonTitle))
            {
                list.Add(lessonTitle);
                list.Add(lessonTitle + "-Exercise");
            }
            return list;
        }

        static List<string> Swap(List<string> list, string[] command)
        {
            string lessonTitleOne = command[1];
            string lessonTitleTwo = command[2];
            int indexOne = list.IndexOf(lessonTitleOne);
            int indexTwo = list.IndexOf(lessonTitleTwo);
            if (list.Contains(lessonTitleOne) && list.Contains(lessonTitleTwo))
            {
                string tempLessonTitleOne = list.ElementAt(indexOne);
                list[indexOne] = list[indexTwo];
                list[indexTwo] = tempLessonTitleOne;
            }
            if (list.Contains(lessonTitleOne + "-Exercise") && list.Contains(list[indexOne]))
            {
                indexOne = list.IndexOf(lessonTitleOne);
                list.Remove(lessonTitleOne + "-Exercise");
                list.Insert(indexOne + 1, lessonTitleOne + "-Exercise");
            }
            else if (list.Contains(lessonTitleTwo + "-Exercise") && list.Contains(list[indexTwo]))
            {
                indexTwo = list.IndexOf(lessonTitleTwo);
                list.Remove(lessonTitleTwo + "-Exercise");
                list.Insert(indexTwo + 1, lessonTitleTwo + "-Exercise");
            }
            return list;
        }

        static List<string> Remove(List<string> list, string[] command)
        {
            string lessonTitle = command[1];
            if (list.Contains(lessonTitle))
            {
                list.Remove(lessonTitle);
            }
            else if (list.Contains(lessonTitle + "-Exercise"))
            {
                list.Remove(lessonTitle + "-Exercise");
            }
            return list;
        }

        static List<string> Insert(List<string> list, string[] command)
        {
            string lessonTitle = command[1];
            int index = int.Parse(command[2]);
            if (index < 0 || index >= list.Count)
            {
                return list;
            }
            else if (!list.Contains(lessonTitle))
            {
                list.Insert(index, lessonTitle);
            }
            return list;
        }

        private static List<string> Add(List<string> list, string[] command)
        {
            string lessonTitle = command[1];
            if (!list.Contains(lessonTitle))
            {
                list.Add(lessonTitle);
            }
            return list;
        }
    }
}