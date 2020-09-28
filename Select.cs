using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman
{
    public class Start
    {
        public int Select()
        {
            int lives = 1;
            while (lives == 1)
            {
                Console.WriteLine("Select your difficulty!\n1) Easy\n2) Normal\n 3) Hard");
                string difficulty = Console.ReadLine();
                switch (difficulty.ToLower())
                {
                    case "1":
                    case "easy":
                        lives = 10;
                        return lives;

                    case "2":
                    case "normal":
                        lives = 7;
                        return lives;

                    case "3":
                    case "hard":
                        lives = 5;
                        return lives;

                    default:
                        Console.WriteLine("Please select 1, 2, or 3 as a difficulty.");
                        return lives;
                }
            }
            return lives;
        }
    }
}
