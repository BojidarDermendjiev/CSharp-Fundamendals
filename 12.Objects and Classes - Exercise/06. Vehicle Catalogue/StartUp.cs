namespace _06._Vehicle_Catalogue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    enum VegiceType { Car, Truck }
    internal class Vehicle
    {

        public Vehicle(VegiceType type, string model, string color, int horsePower)
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }

        public VegiceType Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Type: {Type}");
            stringBuilder.AppendLine($"Model: {Model}");
            stringBuilder.AppendLine($"Color: {Color}");
            stringBuilder.AppendLine($"Horsepower: {HorsePower}");
            return stringBuilder.ToString().TrimEnd();
        }
    }
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            GetInfo(vehicles);
            Engine(vehicles);
            IO(vehicles);
        }
        private static void GetInfo(List<Vehicle> vehicles)
        {
            string inputLine;
            while ((inputLine = Console.ReadLine()) != "End")
            {
                string[] inputArgs = inputLine.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                VegiceType vehiceType;
                bool isVehcileTypaParseSuccessful = Enum.TryParse(inputArgs[0], true, out vehiceType);
                if (isVehcileTypaParseSuccessful)
                {
                    string vehicleModel = inputArgs[1];
                    string vehicleColor = inputArgs[2];
                    int vehicleHorsePower = int.Parse(inputArgs[3]);
                    var curVehicle = new Vehicle(vehiceType, vehicleModel, vehicleColor, vehicleHorsePower);
                    vehicles.Add(curVehicle);
                }
            }
        }
        private static void Engine(List<Vehicle> vehicles)
        {
            string inputLine;
            while ((inputLine = Console.ReadLine()) != "Close the Catalogue")
            {
                var desiredVehicel = vehicles.FirstOrDefault(vehicle => vehicle.Model == inputLine);
                Console.WriteLine(desiredVehicel);
            }
        }
        private static void IO(List<Vehicle> vehicles)
        {
            var cars = vehicles.Where(vehicle => vehicle.Type == VegiceType.Car).ToList();
            var trucks = vehicles.Where(vehicle => vehicle.Type == VegiceType.Truck).ToList();
            double carAvgHorsePower = cars.Count > 0 ? cars.Average(car => car.HorsePower) : 0.00;
            double trucksAvgHorsePower = trucks.Count > 0 ? trucks.Average(truck => truck.HorsePower) : 0.00;
            Console.WriteLine($"Cars have average horsepower of: {carAvgHorsePower:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksAvgHorsePower:f2}.");
        }
    }
}