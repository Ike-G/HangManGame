using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace HangManGame 
{
    static class UI 
    {
        // After instantiation this determines the choices of the user with regards to modes/statistics
        static char guessLetter;
        static string[] asciiArt { get; } = 
        {
            "  +---+\n  |   |\n      |\n      |\n      |\n      |\n=========",
            "  +---+\n  |   |\n  O   |\n      |\n      |\n      |\n=========",
            "  +---+\n  |   |\n  O   |\n  |   |\n      |\n      |\n=========",
            "  +---+\n  |   |\n  O   |\n /|   |\n      |\n      |\n=========",
            "  +---+\n  |   |\n  O   |\n /|\\  |\n      |\n      |\n=========",
            "  +---+\n  |   |\n  O   |\n /|\\  |\n /    |\n      |\n=========",
            "  +---+\n  |   |\n  O   |\n /|\\  |\n / \\  |\n      |\n========="
        };
        
        static void UIStartUp(Game g) 
        {
            // Getting the game mode input and then sending that to the rest of the program
            string modeList = "";
            for (int i = 1; i-1 < g.modes.Count; i++) {
                modeList += $"{i}: {g.modes[i-1].name}\n";
            }
            Console.WriteLine($"Welcome to Hangman!\nBelow are the available game modes: \n\n{modeList}\n\nPlease enter the code of your preferred game mode: ");
            g.mode = g.modes[Int16.Parse(Console.ReadLine())];

            // After the game class finishes its logic it should return its status as well as whether the guess was valid or not 
            do {
                string displayData = g.word;
                if (g.turnEnd) {
                    if (g.guessResult) {
                        Console.WriteLine($"{UI.guessLetter} is valid!\n{renderWord(g)}");
                    } else {
                        Console.WriteLine($"{UI.guessLetter} is not valid.\n{asciiArt[g.fails]}\n{renderWord(g)}");
                    }
                }
            } while (!(g.won || g.lost));
            
            if (g.won) {
                Console.Write("Congratulations! You won.\n\nWould you like to play again? [y/n]: ");
                if (Console.ReadLine().Equals("y")) {
                    new Game();
                }
            } else {
                Console.Write("hah u ded");
            }
            
        }

        static void getGuess(bool cont = true) 
        {
            Console.Write("Please enter your guess: ");
            try {
                UI.guessLetter = Convert.ToChar(Console.ReadLine());
            } catch(Exception) {
                Console.WriteLine("Please enter a valid character");
                getGuess();
            }
        }

        static string renderWord(Game g) 
        {
            string rendered = "";
            for (int i = 0; i < g.knownLetters.Count; i++) {
                if (!g.knownLetters[i].Equals(' '))
                    rendered += Convert.ToString(g.knownLetters[i])+" ";
                else
                    rendered += "_ ";
            }
            return rendered;
        }
    }
}

