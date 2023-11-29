using System;

namespace Inlämningsuppgift5_1C_A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meningarArray = new string[]
            {
            "Detta är den första meningen.",
            "Här kommer den andra meningen.",
            "Och här är den tredje meningen."
            };

            foreach (string mening in meningarArray)
            {
                Console.WriteLine(mening + "\n"); 
            }

        }
    }
}
