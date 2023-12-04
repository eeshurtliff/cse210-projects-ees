using System;

class Program
{


    static int EesMenu(){
        bool gotResponse = false;
        int eesResponseNumber;
        do{
            Console.WriteLine("1. Load the Planner");
            Console.WriteLine("2. Save the Planner");
            Console.WriteLine("3. Add a new event");
            Console.WriteLine("4. View Planner");
            Console.WriteLine("5. Update an event");
            Console.WriteLine("6. Exit");
            Console.WriteLine();
            Console.Write("Please enter the number of the option you chose: ");
            string eesUserResponse = Console.ReadLine();
            if (int.TryParse(eesUserResponse, out eesResponseNumber)){
                if (eesResponseNumber >= 1 && eesResponseNumber <= 6){
                    gotResponse = true;
                }else{
                    Console.WriteLine("That number is not an option. Please try again. ");
                }
            }else{
                Console.WriteLine("That is not a number. Please try again. ");
            }
        }while (gotResponse == false);
        return eesResponseNumber;
    }



    static void Main(string[] args)
    {
        int eesUserChoice = EesMenu();
        if (eesUserChoice == 1){

        }else if (eesUserChoice == 2){

        }else if (eesUserChoice == 3){

        }else if (eesUserChoice == 4){

        }else if (eesUserChoice == 5){

        }else{
            Console.WriteLine("Thank you for using this planner. Come back soon! ");
        }

    }
}