using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace HangManGame
{
    class Program
    {
        void asciiTest()
        {
            for (int i = 0; i < new UI(new Game()).asciiArt.Length; i++)
            {
                Console.WriteLine(new UI(new Game()).asciiArt[i]);
            }
        }
        static void Main()
        {
            new Game();
        }
    }
    partial class UI 
    {

    }
    
}





