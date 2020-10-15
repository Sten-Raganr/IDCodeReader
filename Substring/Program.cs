using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayLOGIT();
            
        }public static void DisplayLOGIT()
        {
            string LOGITfull = "LOGITpe20";
            string LOGITsub = LOGITfull.Substring(0, 5);
            string LOGITsubpe = LOGITfull.Substring(5, 2);
            string LOGITsub20 = LOGITfull.Substring(7, 2);
            Console.WriteLine(LOGITsub);
            Console.WriteLine(LOGITsubpe);
            Console.WriteLine(LOGITsub20);
        }

    }
}
