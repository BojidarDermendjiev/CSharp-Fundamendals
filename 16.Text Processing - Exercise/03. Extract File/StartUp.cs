namespace _03._Extract_File
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            string[] pathParts = GetInfo();
            string fileName, extensions;
            Engine(pathParts, out fileName, out extensions);
            IO(extensions, fileName);
        }
        private static string[] GetInfo()
         => Console.ReadLine().Split('\\', StringSplitOptions.RemoveEmptyEntries);
        private static void Engine(string[] pathParts, out string fileName, out string extensions)
        {
            string fileWithExtension = pathParts[pathParts.Length - 1];
            string[] fileParts = fileWithExtension.Split(".", StringSplitOptions.RemoveEmptyEntries);
            fileName = fileParts[0];
            extensions = fileParts[1];
        }
        private static void IO(string extensions, string fileName)
        {
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extensions}");
        }
    }
}
