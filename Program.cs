using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace HangManGame
{
    class Program
    {
        public static void Main()
        {
            // Code is encapsulated within UIStartUp, which acts as a framework for all actions.
            // UIStartUp takes an instance of game as an argument
            UI.UIStartUp(new Game());
        }
        // Finds all indexes where a character is in a string. 
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





