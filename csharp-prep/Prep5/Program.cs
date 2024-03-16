using System;

class Program
{
            static void DisplayWelcome() {
            Console.WriteLine("Welcome to the program!");
        }
        static string PromptUserName() {
            Console.Write("Please write your name: ");
            return  Console.ReadLine();
        }
        static int PromptUserNumber(){
            Console.Write("Please write your favorite number: ");
            int numberOfUser = int.Parse(Console.ReadLine());
            return numberOfUser;
            
        }
        static void DisplayResult(string userName, int userNumber){
            userNumber = userNumber * userNumber;
            Console.WriteLine($"Brother {userName}, the square of you number is {userNumber}.");
        }
    static void Main(string[] args)
    {
        string userName = "";
        int userNumber = 0;
        


        DisplayWelcome();
        userName = PromptUserName();
        userNumber = PromptUserNumber();
        DisplayResult(userName, userNumber);

    }
}