class ListingActivity : Activity{
    private List<string> _eesUserInputs = new List<string>();

    public ListingActivity(string eesName, string eesDescription, List<string> eesPrompts) : base(eesName, eesDescription, eesPrompts){
        
    }


    public void EesSpecificActivity(){
        Console.Write(">");
        string eesNewInput = Console.ReadLine();
        _eesUserInputs.Add(eesNewInput);
    }

    public void EesRunActivity(){

        EesStartingMessage();
        DateTime eesStartActivity = DateTime.Now;
        DateTime eesEndTime = eesStartActivity.AddSeconds(_eesDuration);
        
        Console.WriteLine("Please read the following prompt:");
        int eesRandomPrompt = base.EesReturnRandomNumber(_eesPrompts);
        string eesChosenPrompt = _eesPrompts[eesRandomPrompt];
        Console.WriteLine("eesChosenPrompt");
        Thread.Sleep(1000);
        Console.Write("You may begin in: ");
        EesCreateCountdown(5);

        while(DateTime.Now < eesEndTime){
            Console.Write(">");
            string eesNewInput = Console.ReadLine();
            _eesUserInputs.Add(eesNewInput);
        }
        Console.WriteLine($"You entered in {_eesUserInputs.Count()} items. ");


        EesEndingMessage();
        Thread.Sleep(2000);
        Console.Clear();
    } 
}