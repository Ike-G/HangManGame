using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace HangManGame
{
    class Program
    {
        // Main code
        
        
        // Below is testing code
        static void Main()
        {
            Console.WriteLine("Main is running.");
            UI.UIStartUp(new Game());
        }
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
        public static List<int> allIndexesOf(string s, char c) 
        {
            List<int> indexes = new List<int>();
            for (int i = 0; i < s.Length; i++) {
                if (s[i] == c) {
                    indexes.Add(i);
                }
            }
            return indexes; 
        }
    }
}





