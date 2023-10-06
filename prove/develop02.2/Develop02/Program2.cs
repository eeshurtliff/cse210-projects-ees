using System;
using System.Diagnostics.Contracts;


class Program
{
    static void Main(string[] args)
    {
        EesJournal eesMyJournal = new EesJournal();
        int eesChoice;
        do{
            eesChoice = EesCreateMenu();
            if (eesChoice == 1){
                EesEntry eesEntry1 = new EesEntry();
                eesEntry1.EesChoosePrompt() = eesPromptNumber;
                eesEntry1.eesPrompt = eesChoice.Prompt[eesPromptNumber];
                
                

                eesEntry1.EesFormatEntry();
                eesMyJournal._eesEntry.Add(eesEntry1);

                
            }
            else if (eesChoice ==2){
                eesMyJournal.DisplayJournal();
            }
            else if (eesChoice == 3){
                Console.WriteLine("Which file would you like to save your Journal to? ");
                string eesUserFile = Console.ReadLine();
            }
            else if (eesChoice == 4){

            }
            else if (eesChoice == 5){

            }
        }while(eesChoice != 5);


    }
    static int EesCreateMenu(){
        Console.WriteLine("Welcome to the Electronic journal");
        Console.WriteLine("Please select an option from the menu: ");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Save Journal to file");
        Console.WriteLine("4. Load Journal from a file");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        string eesUserResponse = Console.ReadLine();
        int eesUserChoice = int.Parse(eesUserResponse);
        return eesUserChoice;
    }

    // static void EesSaveFile(string fileName){
    //     using (StreamWriter writer = new StreamWriter(fileName)){
    //         writer.Write(eesMyJournal.DisplayJournal());
    //     }
    // }
}