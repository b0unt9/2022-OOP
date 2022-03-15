using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                int year = int.Parse(Console.ReadLine());
                if (year < 1 || year > 4000) return;
                if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0) Console.WriteLine("윤년");
                else Console.WriteLine("평년");
            }
           
        }
    }
}
