using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        EesJob job1 = new EesJob();
        job1._eesCompany = "Microsoft";
        job1._eesJobTitle = "Software Engineer";
        job1. _eesStartYear = 2019;
        job1._eesEndYear = 2022;

        

        EesJob job2 = new EesJob();
        job2._eesCompany = "Apple";
        job2._eesJobTitle = "Manager";
        job2._eesStartYear = 2022;
        job2._eesEndYear = 2023;

        


        EesResume myResume = new EesResume();
        myResume._eesName = "Allison Rose";

        myResume._eesJobs.Add(job1);
        myResume._eesJobs.Add(job2);

        myResume.EesDisplayResume();

    }


    

    // public class Resume{
    //     string _name;
    //     List<Jobs> _jobs;
    // }
}