using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace HangManGame 
{
    static class UI 
    {
        // After instantiation this determines the choices of the user with regards to modes/statistics
        public static char guessLetter;
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
        
        public static void UIStartUp(Game g) 
        {
            // Getting the game mode input and then sending that to the rest of the program
            string _catList = "";
            for (int i = 1; i-1 < g.catList.Length; i++) {
                _catList += $"{i}: {g.catList[i-1]}\n";
            }
            string _diffList = "";
            for (int i = 1; i-1 < g.diffList.Length; i++) {
                _diffList += $"{i}: {g.diffList[i-1]}\n";
            }
            bool cont = false;
            while (!cont) {
                Console.Write($"Welcome to Hangman!\nBelow are the available categories: \n{_catList}\nPlease enter the code of your preferred category: ");
                try {
                    int selectedCategory = Int16.Parse(Console.ReadLine())-1;
                    Console.WriteLine($"You have selected {g.catList[selectedCategory]}.");
                    g.mode.category = selectedCategory;
                    cont = true;
                } catch(Exception) {
                    Console.WriteLine("Invalid input. Please only enter a value out of those displayed.");
                }
            }
            cont = false;
            while (!cont) {
                Console.Write($"\nWhat is your preferred difficulty?\nBelow are the available difficulties: \n{_diffList}\nPlease enter the code of your preferred difficulty: ");
                try {
                    
                    int selectedDifficulty = Int16.Parse(Console.ReadLine())-1;
                    Console.WriteLine($"You have selected {g.diffList[selectedDifficulty]} difficulty.\n");
                    g.mode.difficulty = selectedDifficulty;
                    cont = true;
                } catch(Exception) {
                    Console.WriteLine("Invalid input. Please only enter a value out of those displayed.");
                }
            } 
            
            // After the game class finishes its logic it should return its status as well as whether the guess was valid or not 
            do {
                renderWord(g); // Word is rendered
                renderGuesses(g); // Previous guesses are rendered
                g.evaluateGuess(); // Guess is requested
                Console.WriteLine("\n==============================================================\n");
                if (g.guessResult) {
                    Console.WriteLine($"{UI.guessLetter} is valid!");
                } else {
                    Console.WriteLine($"{UI.guessLetter} is not valid.\n{asciiArt[g.fails]}");
                }
            } while (!(g.won || g.lost)); // Feedback must run once before code continues.
            
            if (g.won) {
                Console.Write("Congratulations! You won.\n\nWould you like to play again? [y/n]: ");
                if (Console.ReadLine().Equals("y")) {
                    Program.Main();
                }
            } else {
                Console.WriteLine("\nhah u ded");
                Console.WriteLine($"The word was {g.word}.");
            }
            
        }

        public static void getGuess(Game g, bool cont = true) 
        {
            Console.Write("Please enter your guess: ");
            try {
                UI.guessLetter = Char.ToLower(Convert.ToChar(Console.ReadLine()));
                if (g.guessHistory.Contains(UI.guessLetter)) {
                    Console.WriteLine("\nYou have already made that guess.");
                    throw new Exception();
                }
            } catch(Exception) {
                Console.WriteLine("Please try again.");
                getGuess(g);
            }
        }

        public static void renderWord(Game g) 
        {
            string rendered = "Current word: ";
            for (int i = 0; i < g.knownLetters.Length; i++) {
                if (!g.knownLetters[i].Equals('\0'))
                    rendered += Convert.ToString(g.knownLetters[i])+" ";
                else
                    rendered += "_ ";
            }
            Console.WriteLine(rendered);
        }

        public static void renderGuesses(Game g) 
        {
            string rendered = "\nPrevious guesses: ";
            foreach (char c in g.guessHistory) 
                rendered += $"{c} ";
            Console.WriteLine(rendered);
        }
    }
}

