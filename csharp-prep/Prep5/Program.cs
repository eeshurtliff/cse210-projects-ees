using System;

class Program
{
    static void Main(string[] args){
        EeesDisplayWelcome();
        string EesUserName = EesPromptUserName();
        int EesNumber = EesPromptUserNumber();
        EesDisplayResult(EesUserName, EesSquareNumber(EesNumber));
        
    }
    static void EeesDisplayWelcome(){
        Console.WriteLine("Welcome to the Program!");
    }

    static string EesPromptUserName (){
        Console.Write("What is your name? ");
        string EesUserName = Console.ReadLine();
        return EesUserName;
    }

    static int EesPromptUserNumber(){
         Console.Write("What is your favorite number? ");
        string EesUserNumber = Console.ReadLine();
        int EesNumber = int.Parse(EesUserNumber);
        return EesNumber;
    }

    static int EesSquareNumber(int EesNumber){
        int EesSquared = EesNumber * EesNumber;
        
        return EesSquared;
       
    }

    static void EesDisplayResult(string EesUsername, int EesSquaredNumber){
        Console.WriteLine($"{EesUsername}, the square of your number is {EesSquaredNumber} ");
    }
}