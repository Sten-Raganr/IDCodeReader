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
            AgeCalc(idCode);
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
        public static int GetYear(string idcode)
        {
            int firstnum = Int32.Parse(idcode.Substring(0,1));
            string year = idcode.Substring(1, 2);
            string YearofBirth;
            int YoB = 0;
            if(firstnum == 3 || firstnum == 4)
            {
               YearofBirth= "19" + year;
                YoB = Int32.Parse(YearofBirth);
            }
            else if (firstnum == 5 || firstnum == 6)
            {
                YearofBirth = "20" + year;
                YoB = Int32.Parse(YearofBirth);
                
            }
            return YoB;

        }
        public static void AgeCalc(string idcode)
        {
            int year = GetYear(idcode);
            DateTime now = DateTime.Now;
            string currentYear = now.Year.ToString();
            int yearNow = Int32.Parse(currentYear);
            int age = yearNow - year;
            Console.WriteLine($"You are {age} years old.");

        }
        
    }
}
