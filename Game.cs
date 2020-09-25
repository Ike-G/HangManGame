using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace HangManGame 
{
    public partial class Game  
    {
        // In instantiating an object of this class the game should start
        // This file contains all logic after the game starts, and dictates when it ends
        
        public Mode mode { get; set; } 
        public Boolean finished { get; set; } = false;
        public Boolean turnEnd { get; set; }
        public Boolean guessResult { get; set; }
        public string word { get; set; }
        public void test() {
            
        }
        partial class Mode 
        {
            // Acts as an argument for instantiating the game, data should then be used to add to logic (Initially we can start with a single mode)
            // Zakk - Considering this probably ties best into the categories stuff it's probably best if you work in here and then Harrison can make sure there's a space for it in the main logic
        }
    }
}