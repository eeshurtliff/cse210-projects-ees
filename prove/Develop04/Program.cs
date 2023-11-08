using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        int eesMenuChoice = 0;
        while (eesMenuChoice != 4){
            eesMenuChoice = eesMenu();
            if (eesMenuChoice == 1){
                BreathingActivity eesActivity = new BreathingActivity("Breathing Activity", "This Activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing. ");
                
            }
            else if (eesMenuChoice == 2){
                string eesReflectionDescription = "this activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life. ";
                List<string> eesReflectionPrompts = new List<string>{
                    "Think of a time when you stood up for someone else. ",
                    "Think of a time when you did something really difficult. ",
                    "Think of a time when you helped someone in need. ",
                    "Think of a time when you did something truly selfless. "
                };
                ReflectionActivity eesActivity = new ReflectionActivity("Reflection Activity", eesReflectionDescription, eesReflectionPrompts, 4 );
            }
            else if (eesMenuChoice == 3){
                string eesListingDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area. ";
                List<string> eesListingPrompts = new List<string>{
                    "Who are people that you appreciate? ",
                    "What are personal strengths of yours? ",
                    "Who are people that you have helped this week? ",
                    "When have you felt the Holy Ghost this month? ", 
                    "Who are some of your personal heroes? "
                };
                ListingActivity eesActivity = new ListingActivity("Listing Activity", eesListingDescription, eesListingPrompts);
            }
            else if (eesMenuChoice == 4){
                Console.WriteLine("Thank you for participating in the mindfulness activities! ");

            }
            else{
                Console.WriteLine("That was not a menu option. Please select a number from the menu. ");
            }
            eesActivity.EesRunActivity();
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