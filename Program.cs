using System;
using System.Collections.Generic;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Start _difficulty = new Start();
            int lives = _difficulty.Select();
            WordGenerate _wg = new WordGenerate();
            string hangmanAnswer = _wg.NewWord();
            char[] answerArray = new char [hangmanAnswer.Length];
            Console.WriteLine($"Please guess a letter in the word. There are {answerArray.Length} letters in it.");

            for (int i = 0; i < hangmanAnswer.Length; i++)
                answerArray[i] = '#';
                var g = true;
            {
                while (g)
                {
                    char hangmanGuess = Console.ReadKey().KeyChar;
                    for (int l = 0; l < hangmanAnswer.Length; l++)
                    {
                        if (hangmanGuess == hangmanAnswer[l])
                            answerArray[l] = hangmanGuess;
                    }
                    if (Array.IndexOf(answerArray, hangmanGuess) < 0)
                    {
                        lives -= 1;
                        if (lives == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("You've lost all your parts. \nGame Over.");
                            Console.ReadLine();
                            g = false;
                        }
                    }
                    Console.WriteLine("\n");
                    Console.WriteLine(answerArray);
                    Console.WriteLine(lives);
                    string result = new string(answerArray);
                    if (result == hangmanAnswer)
                    {
                        Console.Clear();
                        Console.WriteLine("You've won the game!");
                        Console.ReadLine();
                        g = false;
                    }
                }
            }
        }
    }
}
