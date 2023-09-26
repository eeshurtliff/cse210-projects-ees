public class EesResume{
    public string _eesName;
    public List<EesJob> _eesJobs = new List<EesJob>();

    public void EesDisplayResume(){
        Console.WriteLine($"Name: {_eesName}");
        Console.WriteLine("Jobs:");
        foreach (EesJob job in _eesJobs){
            job.EesDisplayDetails();
        }
    }
}