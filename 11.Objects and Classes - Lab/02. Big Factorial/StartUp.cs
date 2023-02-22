namespace _02._Big_Factorial
{
    using System;
    using System.Numerics;

    public class StartUp
    {
        static void Main()
        {
            BigInteger factorialNumber;
            GetInfo(out factorialNumber);
            Console.WriteLine(Engine(factorialNumber));
        }
        private static void GetInfo(out BigInteger factorialNumber)
        {
            factorialNumber = BigInteger.Parse(Console.ReadLine());
        }
        private static BigInteger Engine(BigInteger factorialNumber)
        {
            if(factorialNumber == 0)
                return 1;
            return factorialNumber * Engine(factorialNumber - 1);
        }
    }
}
