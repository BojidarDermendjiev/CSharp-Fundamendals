namespace _07._Vehicle_Catalogue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        static void Main()
        {
            var listOfCars = new List<Car>();
            var listOfTrucks = new List<Truck>();
            Engine(listOfCars, listOfTrucks);
            Console.WriteLine(IO(listOfCars, listOfTrucks));

        }
        private static void Engine(List<Car> listOfCars, List<Truck> listOfTrucks)
        {
            string inputLineFromConsole;
            while ((inputLineFromConsole = Console.ReadLine()) != "end")
            {
                var tokens = inputLineFromConsole.Split("/", StringSplitOptions.RemoveEmptyEntries);
                switch (tokens[0]) 
                {
                    case "Car":
                        FillPropertiesForCar(tokens, listOfCars);
                        break;
                    case "Truck":
                        FillPropertiesForTruck(tokens, listOfTrucks);
                        break;
                }
            }
        }
        private static void FillPropertiesForCar(string[] tokens, List<Car> listOfCars)
        {
            var car = new Car(tokens[1], tokens[2], int.Parse(tokens[3]));
            listOfCars.Add(car);
        }
        private static void FillPropertiesForTruck(string[] tokens, List<Truck> listOfTrucks)
        {
            var truck = new Truck(tokens[1], tokens[2], int.Parse(tokens[3]));
            listOfTrucks.Add(truck);
        }
        private static string IO(List<Car> listOfCars, List<Truck> listOfTrucks)
        {
            StringBuilder sb = new StringBuilder();
            if (listOfCars.Any())
            {
                sb.AppendLine("Cars:");
                foreach (var car in listOfCars.OrderBy(x => x.Brand))
                    sb.AppendLine($"{car.Brand}: {car.Model} - {car.HoursePower}hp");
            }
            if (listOfTrucks.Any())
            {
                sb.AppendLine("Trucks:");
                foreach (var truck in listOfTrucks.OrderBy(x => x.Brand))
                    sb.AppendLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
            return sb.ToString().TrimEnd();
        }
    }
    public class Vehicle
    {
        public Vehicle(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
    }
    public class Car : Vehicle
    {

        public Car(string brand, string model, int hoursePower) : base(brand, model)
        {
            HoursePower = hoursePower;
        }
        public int HoursePower { get; set; }
    }
    public class Truck : Vehicle
    {
        public Truck(string brand, string model, int weight) : base(brand, model)
        {
            Weight = weight;
        }
        public int Weight { get; set; }
    }
}
