using System;
using System.Collections.Generic;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            int lives = 5;
            string[] HangmanAnswers = { "boogie", "taco", "extreme" };
            Random newAnswer = new Random();
            var tko = newAnswer.Next(0, 3);
            string hangmanAnswer = HangmanAnswers[tko];
            char[] answerArray = new char [hangmanAnswer.Length];
            Console.WriteLine($"Please guess a letter in the word. There are {answerArray.Length} letters in it.");

            for (int i = 0; i < hangmanAnswer.Length; i++)
                answerArray[i] = '_';
            while (true)
            {
                var hangmanGuess = Console.ReadKey().KeyChar; ;
                for (int l = 0; l < hangmanAnswer.Length; l++)
                {
                    if (hangmanGuess == hangmanAnswer[l])
                        answerArray[l] = hangmanGuess;
                }
            if (Array.IndexOf(answerArray, hangmanGuess) < 0)
            {
                lives -= 1;
            }
                Console.WriteLine("\n");
                Console.WriteLine(answerArray);
            Console.WriteLine(lives);
            }
            Console.ReadLine();
        }
    }
}
