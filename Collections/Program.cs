﻿using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[] { "Enes", "Erdem", "Hasan", "Muhammet" };
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[3]);

            //names = new string[5];

            //names[4] = "Fatih";
            //Console.WriteLine(names[4]);
            //Console.WriteLine(names[1]);

            List<string> names2 = new List<string>("Enes", "Erdem", "Hasan", "Muhammet");
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);

            names2.Add("Fatih");

            
           
            Console.WriteLine(names2[4]);
            Console.WriteLine(names2[1]);


        }
    }
}