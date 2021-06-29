﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB280621
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число: ");
            int number = int.Parse(Console.ReadLine());
            int[] arr = new int[] { -1, 2, -3, 4, -5, 6, 7, 8, 9 };
            Task Sim = new Task();

            Console.Write(Sim.GetSimple(number) + "\n\n");

            foreach (int i in Sim.GetTripleArr(arr))
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("\n");

            foreach (int i in Sim.GetAntiArr(arr))
            {
                Console.Write($"{i} ");            
            }
            Console.WriteLine("\n");

            foreach (var i in Sim.GetStringArr(arr))
            {
                Console.Write($"{i} ");
            }
            

        }
    }
}
