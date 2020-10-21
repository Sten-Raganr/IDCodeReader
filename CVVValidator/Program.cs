using System;

namespace CVVValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your CVV:");
            string userCVV = Console.ReadLine();
            if (ThreeNum(userCVV))
            {
                Console.WriteLine("alright");
            }
        }public static bool ThreeNum(string userCVV)
        {
            if (userCVV.Length == 3)
            {
                try
                {
                    Int32.Parse(userCVV);
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Wrong format:{e}");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Wrong format!");
                return false;
            }
        }
    }
}
