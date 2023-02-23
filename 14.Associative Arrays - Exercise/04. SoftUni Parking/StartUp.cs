namespace _04._SoftUni_Parking
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main()
        {
            Dictionary<string, string> users = Engine();
            IO(users);
        }

        private static Dictionary<string, string> Engine()
        {
            Dictionary<string, string> users = new Dictionary<string, string>();
            int numberOFCommand = int.Parse(Console.ReadLine());
            for (int currentCommand = 0; currentCommand < numberOFCommand; currentCommand++)
            {
                string[] parts = Console.ReadLine().Split();
                string command = parts[0];
                if (command == "register")
                    Register(users, parts);
                else
                    Unregister(users, parts);
            }
            return users;
        }
        private static void Register(Dictionary<string, string> users, string[] parts)
        {
            string username = parts[1];
            string licensePlateNumber = parts[2];
            if (!users.ContainsKey(username))
            {
                users.Add(username, licensePlateNumber);
                Console.WriteLine($"{username} registered {licensePlateNumber} successfully ");
            }
            else
                Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
        }
        private static void Unregister(Dictionary<string, string> users, string[] parts)
        {
            string username = parts[1];
            bool removed = users.Remove(username);
            if (removed)
                Console.WriteLine($"{username} unregistered successfully");
            else
                Console.WriteLine($"ERROR: user {username} not found");
        }
        private static void IO(Dictionary<string, string> users)
        {
            foreach (var user in users)
                Console.WriteLine($"{user.Key} => {user.Value}");
        }
    }
}
