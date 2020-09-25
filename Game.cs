using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace HangManGame 
{
    public class Game  
    {
        // In instantiating an object of this class the game should start
        // This file contains all logic after the game starts, and dictates when it ends
        
        public Mode mode { get; set; } 
        public bool won { get; set; } = false;
        public bool lost { get; set; } = false;
        public bool turnEnd { get; set; }
        public bool guessResult { get; set; }
        public int fails { get; set; } = 0;
        public string word { get; set; } // IMPORTANT: After this is declared knownLetters must be set to new List<char>(word.length)
        public List<Game.Mode> modes { get; set; } = new List<Mode>();
        public List<char> knownLetters { get; set; }
        public class Mode 
        {
            public string name { get; set; }
            // Acts as an argument for instantiating the game, data should then be used to add to logic (Initially we can start with a single mode)
            // Zakk - Considering this probably ties best into the categories stuff it's probably best if you work in here and then Harrison can make sure there's a space for it in the main logic
        }
    }
}