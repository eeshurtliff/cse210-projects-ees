using System;
using System.Collections.Concurrent;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        int eesCorrect = 0;
        Random randomGenerator = new Random();
        int eesMagicNumber = randomGenerator.Next(1,11);
        
        do {
            Console.Write("What is your guess? ");
            string eesUserGuess = Console.ReadLine();
            int eesGuess = int.Parse(eesUserGuess);
            if (eesGuess < eesMagicNumber){
                Console.WriteLine("Higher");
            }
            else if (eesGuess > eesMagicNumber){
                Console.WriteLine("Lower");
            }
            else {
                Console.WriteLine("You guessed it!");
                eesCorrect = 1;
            } 

        } while (eesCorrect == 0);
    }
}