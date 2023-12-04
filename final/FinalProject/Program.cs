using System;

class Program
{

// This function displays the menu and returns the user's choice to the main function
    static int EesMenu(){
            Console.WriteLine("Choose an option from the menu: ");
            Console.WriteLine("1. Load the Planner");
            Console.WriteLine("2. Save the Planner");
            Console.WriteLine("3. Add a new event");
            Console.WriteLine("4. View Planner");
            Console.WriteLine("5. Update an event");
            Console.WriteLine("6. Exit");
            Console.WriteLine();
            Console.WriteLine("Please enter the number of the option you chose: ");
            return EesGetOptionChoice(6);
        
    }


// takes a response and continues to ask for a response until the answer is in the range required for the question. 
// This is a separate function because it is needed multiple times in the program
    static int EesGetOptionChoice(int eesHighRange){
        bool eesGotResponse = false;
        int eesResponseNumber;
        do{
            Console.Write("> ");
            string eesUserResponse = Console.ReadLine();
        if (int.TryParse(eesUserResponse, out eesResponseNumber)){
             if (eesResponseNumber >= 1 && eesResponseNumber <= eesHighRange){
                    eesGotResponse = true;
                }else{
                    Console.WriteLine($"That number is not in the range 1-{eesHighRange}. Please try again. ");
                }
            }else{
                Console.WriteLine("That is not a number. Please try again. ");
            }
        }while (eesGotResponse == false);
        return eesResponseNumber;

    }
    



    static void EesCreateEvent(){
        Console.WriteLine("Choose an event to create: ");
        Console.WriteLine("1. Appointment: an event that is scheduled to happen at a specific time. ");
        Console.WriteLine("2. Task: an event that has a date it must be completed by. ");
        Console.WriteLine("Which event would you like to create? ");
        int eesChoice = EesGetOptionChoice(2);
        Console.WriteLine();

        if (eesChoice == 1){

        }else{   //2
            Console.WriteLine("Choose a type of task to create: ");
            Console.WriteLine("1. One time task");
            Console.WriteLine("2. Repeated task: repeated weekly ");
            Console.WriteLine("3. Complex task: made up of multiple smaller tasks ");
            int eesTaskChoice = EesGetOptionChoice(3);

            if (eesTaskChoice == 1){

            }else if (eesTaskChoice == 2){

            }else{   //3

            }
        }
        
    }



    static void Main(string[] args)
    {
        int eesUserChoice = EesMenu();
        if (eesUserChoice == 1){
            //1. Load the Planner

        }else if (eesUserChoice == 2){
            //2. Save the Planner

        }else if (eesUserChoice == 3){
            //3. Add a new event


        }else if (eesUserChoice == 4){
            //4. View Planner

        }else if (eesUserChoice == 5){
            //5. Update an event

        }else{
            Console.WriteLine("Thank you for using this planner. Come back soon! ");
        }

    }
}