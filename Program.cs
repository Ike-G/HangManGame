﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace HangManGame
{
    class Program
    {
        static void Main()
        {
            using(var reader = new StreamReader("Categories/Brands.csv"))
            {
                Console.WriteLine("Hello World!");
                List<string> listA = new List<string>();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    listA.Add(values[0]);
                    foreach (var coloumn1 in listA)
                    {
                        Console.WriteLine(coloumn1);
                    }
                }
            }
        }
    }
}

    class SortingCsv
    {
        static void Sort(string[] args)
        {
            
            
        }
    }

    partial class Game 
    {

    }

    static partial class Menu 
    {

    }

