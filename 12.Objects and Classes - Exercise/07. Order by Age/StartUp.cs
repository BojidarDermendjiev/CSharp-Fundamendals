namespace _07._Order_by_Age
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Orders
    {
        public Orders(string name, int iD, int age)
        {
            Name = name;
            ID = iD;
            Age = age;
        }
        public string Name { get; set; }
        public int ID { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }
    }
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Orders> ordersByPerson = Engine();
            IO(ordersByPerson);
        }

        private static List<Orders> Engine()
        {
            List<Orders> ordersByPerson = new List<Orders>();
            string inputLine;
            while ((inputLine = Console.ReadLine()) != "End")
            {
                string[] index = inputLine.Split();
                Orders orders = new Orders(index[0], int.Parse(index[1]), int.Parse(index[2]));
                ordersByPerson.Add(orders);
            }

            return ordersByPerson;
        }

        private static void IO(List<Orders> ordersByPerson)
        {
            foreach (var orders in ordersByPerson
                         .OrderBy(x => x.Age)
                         .ToList())
                Console.WriteLine(orders);
        }
    }
}
