namespace _09._P.Equipment
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            double JohnsMoney = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());

            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            int lightsaberQuantity = (int)Math.Ceiling(1.1 * students);
            int robeQuantity = students;
            int beltQuantity = students - (students / 6);

            double totalPrice = lightsaberPrice * lightsaberQuantity
                    + robePrice * robeQuantity
                    + beltPrice * beltQuantity;

            if (totalPrice <= JohnsMoney)
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            else
                Console.WriteLine($"John will need {totalPrice - JohnsMoney:f2}lv more.");
        }
    }
}
