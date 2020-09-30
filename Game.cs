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
        char[] blankArray = selectedWord.ToCharArray();
        int WrongGuesses = 0;
        int Total = 0;
        List<char> wordArray = new List<char>() {selectedWord};
        // for (int i = 0, i < blankArray.length; i++)
        //{
        //    blankArray[i] = "_" // to make teh blank slots under scores when printed. 
        //}
        // for (int i = 0, i < allowedGuesses, i++)
        //{
        //    oldArray == blankArray
        //    "guess" input == guessLetter ;
        //    blankArray == *BlankArrayGuesser*;
        //    if (oldArray = blankArray){
        //        wrongGuesses = wrongGuesses + 1;
        //    }
        //    if guesses == allowedGuesses{
        //        gameOver;
        //}
        // all that need to be done with this function is put it in a for i loop with allowed guesses with new guess letters every i value, 
        public static char[] BlankArrayGuesser(guessLetter, wordArray, blankArray)
        {
            for (int i = 0; i < wordArray().Length; i++)
            {
                if (wordArray[i] = UI.guessLetter;)
                {
                    blankArray[i] = UI.guessLetter;
                }
                if (wordArray[i] != guessLetter) and (wordArray[i] = " "; or wordArray[i] = "_")
                {
                    blankArray[i] = "_";
                }
            }
            return blankArray;
        }
        public static 

        // In instantiating an object of this class the game should start
        // This file contains all logic after the game starts, and dictates when it ends
        partial class Mode 
        {
            // Acts as an argument for instantiating the game, data should then be used to add to logic (Initially we can start with a single mode)
            // Zakk - Considering this probably ties best into the categories stuff it's probably best if you work in here and then Harrison can make sure there's a space for it in the main logic
        }
    }
}