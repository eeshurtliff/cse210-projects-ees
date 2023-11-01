using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Assignment newAssignment = new Assignment("Joseph", "Fractions");
        Console.WriteLine(newAssignment.GetSummary());
        MathAssignment newMath = new MathAssignment("Kolton", "Division", "2.3", "All Odd");
        Console.WriteLine(newMath.GetSummary());
        Console.WriteLine(newMath.GetHomework());
        Console.WriteLine();
        WritingAssignment writing = new WritingAssignment("Zach", "Poems", "The Importance of Poetry");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}