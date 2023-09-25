using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> eesNumbers = new List<int>();
        int eesNumber;
        do {
        Console.Write("What number should be added to the list? (0 to stop) ");
        string eesUserResponce = Console.ReadLine();
        eesNumber = int.Parse(eesUserResponce);
        eesNumbers.Add(eesNumber);

        } while (eesNumber != 0);

        //the average
        int eesTotal = 0;
        int eesCount = 0;
        foreach (int eesOneNumber in eesNumbers){
           
            eesCount += 1;
            eesTotal = eesTotal + eesOneNumber;
            

        }
        int eesAverage = eesTotal / eesCount;
        
        // the largest number
        int eesMaximum = 0;
        foreach (int eesOneNumber in eesNumbers){
            if (eesOneNumber > eesMaximum) {
                eesMaximum = eesOneNumber;
            } 

        }

        // the smallest positive number
        int eesMinimum = 999999999;
        foreach (int eesOneNumber in eesNumbers){
            if (eesOneNumber > 0) {
                if (eesOneNumber < eesMinimum) {
                    eesMinimum = eesOneNumber;
                } 

            }

        }

        


        //printing all of the findings
        Console.WriteLine($"The sum is: {eesTotal}");
        Console.WriteLine($"The average is: {eesAverage}");
        Console.WriteLine($"The largest number is: {eesMaximum}");
        Console.WriteLine($"The smallest positive number is: {eesMinimum}");

        eesNumbers.Sort();
        Console.WriteLine($"The sorted list is: ");
        for (int i = 0; i < eesNumbers.Count; i++) {
            int eesOneNumber = eesNumbers[i];
            Console.WriteLine(eesOneNumber);
        }
    }

}