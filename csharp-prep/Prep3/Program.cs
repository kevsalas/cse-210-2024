using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        Console.WriteLine($"What is the magic number? ");
        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
        int guessNumber = int.Parse(guess);
        int count = 1;
        while (guessNumber != number){
            count++;
            if (guessNumber > number){
                Console.WriteLine("Lower");
                Console.Write("What is your guess? ");
                guess = Console.ReadLine();
                guessNumber = int.Parse(guess);
                Console.WriteLine($"You have tried {count} times.");
                if(guessNumber == number){
                    Console.WriteLine("You Guessed it!");
                    Console.WriteLine("Do you want to try again?");
                    string answer = Console.ReadLine();
                    if (answer.ToLower() == "yes"){
                        return;
                    }
                }
                                     
            }
            else if (guessNumber < number){
                Console.WriteLine("Higher");
                Console.Write("What is your guess? ");
                guess = Console.ReadLine();
                guessNumber = int.Parse(guess);
                Console.WriteLine($"You have tried {count} times.");                
                if(guessNumber == number){
                    Console.WriteLine("You Guessed It!");
                    Console.WriteLine("Do you want to try again?");
                    string answer = Console.ReadLine();
                    if (answer.ToLower() == "yes"){
                        return;
                    }
                }
                                 
            }
           
        }
    }
}