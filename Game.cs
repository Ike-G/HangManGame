using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace HangManGame 
{
    public partial class Game
    {
        public string word {get; set;}

        public static char[] wordArray(word)
        {
            
        }
        
        public static char[] guessWord(guessLetter, word, wordArray)
        {
            bool gameOver = false;
           
            char[] blankArray = word.ToCharArray();
            //for (int i = 0; i ) 
            int leftToGuess = wordArray().Length
            for (int i = 0; i < allowedGuesses; i++) 
            {
                if (char[] wordArray[i] = guessLetter)
                {
                    char[] blankArray[i] = guessLetter;
                    leftToGuess = leftToGuess - 1;
                    
                }
                if (char[] wordArray[i] != guessLetter); and (wordArray[i] = " " or wordArray[i] = "_")
                {
                    char[] blankArray[i] = "_";
                    int total += 1;
                }
                if (int total = leftToGuess) {
                    wrongGuesses += 1;
                }
                if (wrongGuesses = allowedGuesses)
                {
                    gameOver = true;
                }
            }

            // In instantiating an object of this class the game should start
        // This file contains all logic after the game starts, and dictates when it ends
        partial class Mode 
        {
            // Acts as an argument for instantiating the game, data should then be used to add to logic (Initially we can start with a single mode)
            // Zakk - Considering this probably ties best into the categories stuff it's probably best if you work in here and then Harrison can make sure there's a space for it in the main logic
        }
    }
}