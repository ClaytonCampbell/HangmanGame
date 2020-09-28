using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman
{
    public class WordGenerate
    {
        string[] HangmanAnswers = { "boogie", "taco", "extreme" };
        public string NewWord()
        {
            Random newAnswer = new Random();
            var tko = newAnswer.Next(0, 3);
            string hangmanAnswer = HangmanAnswers[tko];
            return hangmanAnswer;
        }
    }
}
