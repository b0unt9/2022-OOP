﻿using System;
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
            int i = 0;
            while (i++ < 10)
            {
                if (i % 2 == 0) continue;
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
