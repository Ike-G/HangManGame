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
            List<int> test = new List<int>() {1,2,3}; 
            string modeList = "";
            for (int i = 1; i-1 < test.Count; i++) {
                modeList += $"{i}: {test[i-1]}\n";
            }
            Console.WriteLine(modeList);

            
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
    }

    class SortingCsv
    {
        
    }
}
public static void (){
    mode
    char[] blankArray = word.ToCharArray();
    for (int i = 0; i < blankArray.length; i++)
    {
        if (char[] wordArray[i] = string guessLetter ) 
        {
            char[] blankArray[i] = string guessLetter;
        }
        if (char[] wordArray[i] != string guessLetter)
        {
            char[] blankArray[i] = "_";
            int total += 1;
        }
        if (int total = wordArray.length) {
            wrongGuesses += 1
}
 
}
}


