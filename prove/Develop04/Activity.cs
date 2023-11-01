class Activity{
    protected string _eesName;
    protected string _eesDescription;
    protected int _eesDuration;
    protected List<string> _eesPrompts = new List<string>();
    private List<string> _eesAnimationItems;




    public Activity(string eesName, string eesDescription){
        _eesName = eesName;
        _eesDescription = eesDescription;
        EesStartingMessage();
    }
    public void EesStartingMessage(){
        Console.WriteLine($" Welcome to the{_eesName}. "); 
        Console.WriteLine();
        Console.WriteLine($"{_eesDescription} ");
        Console.WriteLine();
        Console.WriteLine("How long, in seconds, would you like your session to last? ");
        _eesDuration = int.Parse(Console.ReadLine());
        Console.WriteLine($"Your activity will last for {_eesDuration} seconds.");
    }

    public void EesEndingMessage(){
        Console.WriteLine("Great Job!");
    }           



}