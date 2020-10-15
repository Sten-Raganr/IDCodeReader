using System;

namespace IDCodeReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your personal code:");
            string idCode = Console.ReadLine();
            int idcodelenght = idCode.Length;

            if (Validate(idCode))
            {
                HelloUser(idCode);
            }
            else
            {
                Console.WriteLine("wrong format.");
            }
        }
        public static bool Validate(string idCode)
        {
            if (idCode.Length == 11)
            {
                try
                {
                    long.Parse(idCode);
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                    Console.WriteLine($"Wrong format = {e}");
                }
            }
            else
            {
                return false;
            }
        }
        public static void HelloUser(string idCode)
        {
            int firstnum = Int32.Parse(idCode[0].ToString());
            if (firstnum == 1 || firstnum == 3 || firstnum == 5)
            {
                Console.WriteLine("Hello, Sir!!");
            }
            else if (firstnum == 2 || firstnum == 4 || firstnum == 6)
            {
                Console.WriteLine("Hello, Madam!!");
            }

        }
        
    }
}
