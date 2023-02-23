namespace _03._Articles_2._0
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
            var articles = new List<Articles>();
            GetInfo(inputLine, out countOfChanges, ref article, articles);
            IO(articles);
        }
        private static void GetInfo(List<string> inputLine, out int countOfChanges, ref Articles article, List<Articles> articles)
        {
            countOfChanges = int.Parse(Console.ReadLine());
            for (int currentArticle = 0; currentArticle < countOfChanges; currentArticle++)
            {
            inputLine = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                article = new Articles(inputLine[0], inputLine[1], inputLine[2]);
                articles.Add(article);
            }
            var line = Console.ReadLine();
        }
        private static void IO(List<Articles> articles)
        {
            Action<List<Articles>> print = message => Console.WriteLine(string.Join(Environment.NewLine, message));
            print(articles);
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