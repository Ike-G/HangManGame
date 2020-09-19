using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace HangManGame
{
    class Program
    {
        static void Main()
        {
            void categoryTest() 
            {
                using (var reader = new StreamReader("Categories/Brands.csv"))
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
            void asciiTest()
            {
                for (int i = 0; i < new UI(new Game()).asciiArt.Length; i++)
                {
                    Console.WriteLine(new UI(new Game()).asciiArt[i]);
                }
            }
        }
    }
    partial class UI 
    {

    }

    class SortingCsv
    {
        static void Sort(string[] args)
        {

        }
    }
    public partial class Game
    {
        public List<Game.Mode> modes { get; set; }
        public partial class Mode 
        {

        }
    }
}





