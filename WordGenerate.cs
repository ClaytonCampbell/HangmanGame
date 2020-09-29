using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman
{
    public class WordGenerate
    {
        string[] HangmanAnswers = { "turbo", "taco", "extreme", "headphones", "juggle", "xylophone", "paparazzi" };
        public string NewWord()
        {
            Random newAnswer = new Random();
            var tko = newAnswer.Next(0, 7);
            string hangmanAnswer = HangmanAnswers[tko];
            return hangmanAnswer;
        }
    }
}
