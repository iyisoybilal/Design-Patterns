﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Satıs satıs = new MuzikMagazası();
            satıs.GitarSatısYap();
            Console.ReadLine();
        }
    }
}
