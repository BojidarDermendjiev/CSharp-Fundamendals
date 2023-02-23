namespace _02._Articles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            var inputLine = new List<string>();
            int countOfChanges;
            var article = new Articles();
            GetInfo(inputLine, out countOfChanges, out article);
            Engine(article, countOfChanges);
            IO(article);
        }
        private static void GetInfo(List<string> inputLine, out int countOfChanges,out Articles article)
        {
            inputLine = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            countOfChanges = int.Parse(Console.ReadLine());
            article = new Articles(inputLine[0], inputLine[1], inputLine[2]);
        }
        private static void Engine(Articles article, int countOfChanges)
        {
            for (int currentEdit = 0; currentEdit < countOfChanges; currentEdit++)
            {
                var tokens = Console.ReadLine().Split(new string[] { ": "}, StringSplitOptions.RemoveEmptyEntries);
                switch (tokens[0])
                {
                    case "Edit":
                        article.Edit(tokens[1]);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(tokens[1]);
                        break;
                    case "Rename":
                        article.Rename(tokens[1]);
                        break;
                }
            }
        }
        private static void IO(Articles article)
        {
            Action<Articles> print = message => Console.WriteLine(message);
            print(article);
        }
    }
    public class Articles
    {
        public Articles() { }
        public Articles(string title, string content, string author) : this()
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public void Edit(string content)
           => Content = content;
        public void ChangeAuthor(string author)
            => Author = author;
        public void Rename(string title)
            => Title = title;
        public override string ToString()
            => $"{Title} - {Content}: {Author}";
    }
}
