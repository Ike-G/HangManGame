using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace HangManGame 
{
    partial class UI 
    {
        // After instantiation this determines the choices of the user with regards to modes/statistics
        public char guessLetter { get; set; }
        public string[] asciiArt { get; } = 
        {
            "  +---+\n  |   |\n      |\n      |\n      |\n      |\n=========",
            "  +---+\n  |   |\n  O   |\n      |\n      |\n      |\n=========",
            "  +---+\n  |   |\n  O   |\n  |   |\n      |\n      |\n=========",
            "  +---+\n  |   |\n  O   |\n /|   |\n      |\n      |\n=========",
            "  +---+\n  |   |\n  O   |\n /|\\  |\n      |\n      |\n=========",
            "  +---+\n  |   |\n  O   |\n /|\\  |\n /    |\n      |\n=========",
            "  +---+\n  |   |\n  O   |\n /|\\  |\n / \\  |\n      |\n========="
        };
        
        public UI(Game g) 
        {
            // Getting the game mode input and then sending that to the rest of the program
            string modeList = "";
            for (int i = 1; i-1 < g.modes.Count; i++) {
                modeList += $"{i}: {g.modes[i-1]}\n";
            }
            Console.WriteLine($"Welcome to Hangman!\nBelow are the available game modes: \n\n{modeList}\n\nPlease enter the code of your preferred game mode: ");
            g.mode = g.modes[Int16.Parse(Console.ReadLine())];

            // Getting the guess data and displaying it 
            while (!g.finished) {
                string displayData = g.word;
                if (g.turnEnd) {
                    if (g.guessResult) {
                        Console.WriteLine("");
                    } else {
                        
                    }
                }

            }

        }

        public void getGuess(Boolean cont = true) 
        {
            if (cont) 
            {
                Console.Write("Please enter your guess: ");
                
            }
        }
    }
}

