using System;
using System.Diagnostics.Contracts;
using System.IO;


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
                int eesPromptNumber = eesEntry1.EesChoosePrompt();
                eesEntry1._eesPrompt = eesEntry1.EesPrompts[eesPromptNumber];
                
                eesEntry1.EesFormatEntry();
                eesMyJournal._eesEntry.Add(eesEntry1);

                
            }
            else if (eesChoice ==2){
                eesMyJournal.DisplayJournal();
            }
            else if (eesChoice == 3){
                Console.WriteLine("Which file would you like to save your Journal to? ");
                string eesUserFile = Console.ReadLine();
                EesSaveFile(eesUserFile, eesMyJournal);
            }
            else if (eesChoice == 4){
                Console.Write(eesMyJournal.FormatJournal());
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

    static void EesSaveFile(string fileName, EesJournal eesMyJournal){

        using (StreamWriter writer = new StreamWriter(fileName, true)){
            writer.Write(eesMyJournal.FormatJournal());
        }
    }



    // Lisa's code
    static void LhSelectEntry()
    {
        //get dat from super
        Console.Write("Enter the date you want to select (MM/DD/YYYY): ");
        string lhDateInput = Console.ReadLine();
        //check if input is valid 
        if (!lhDateInput.Contains("/") || lhDateInput.Length != 10)
        {
            Console.WriteLine("Invalid Date Format.");
            return;
        }
        //look for file
        string lhFilePath = "journal.csv";
        //check to see if file exists
        if (!File.Exists(lhFilePath))
        {
            Console.WriteLine("The journal.csv file does not exist.");
            return;
        }
        //read the jounral.csv file and look for the date the user gave
        var LhLines = File.ReadLines(lhFilePath);
        var LhEntry = LhLines.FirstOrDefault(line => line.StartsWith(lhDateInput));
        //if entry found display date, prompt, entry
        if (LhEntry != null)
        {
            var LhFeilds = LhEntry.Split(',');
            Console.WriteLine("Date: {0}", LhFeilds[0]);
            Console.WriteLine("Prompt: {0}", LhFeilds[1]);
            Console.WriteLine("Journal entry: {0}", LhFeilds[2]);
        }
        else
        {
            //if no date found
            Console.WriteLine("No Jounral Entry found for the date {0}.", lhDateInput);
        }
    }
}