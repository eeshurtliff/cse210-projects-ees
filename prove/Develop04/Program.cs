using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        int eesMenuChoice = eesMenu();
        if (eesMenuChoice == 1){
            Activity activity = new BreathingActivity("Breathing Activity", "This Activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing. ");
            
        }
    }


    static int eesMenu(){
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Start breathing activity");
        Console.WriteLine("  2. Start reflecting activity");
        Console.WriteLine("  3. Start listing activity");
        Console.WriteLine("  4. Quit");
        Console.Write("Select a choice from the menu: ");
        int eesMenuChoice = int.Parse(Console.ReadLine());
        return eesMenuChoice;
    }
}