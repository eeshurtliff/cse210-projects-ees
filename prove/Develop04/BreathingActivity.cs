class BreathingActivity : Activity{
    private string _eesBreatheIn = "Breathe In...";
    private string _eesBreatheOut = "Breathe Out...";
    private int _eesPause;
    //private List<string> _eesCountdown = new List<string>{Range(1, _eesPause)};


    public BreathingActivity(string eesName, string eesDescription) : base(eesName, eesDescription){
        _eesName = eesName;
        _eesDescription = eesDescription;
        SetPause();

    }
    public void SetPause(){
        bool eesPauseAssigned = false;
        do{
            Console.Write("Would you like to breathe in 4 second intervals or 7 second intervals? ");
        
            int eesPauseTime = int.Parse(Console.ReadLine());
            if (eesPauseTime == 1 || eesPauseTime == 2){
                _eesPause = eesPauseTime;
                eesPauseAssigned = true;
            }
            else{
                Console.WriteLine("You must choose either 4 or 7.");
            }
        }while(eesPauseAssigned == false);

    }

    private void CreateCountdown(){
        for (int i = _eesPause; i > 0; i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        
        }
    }

    public void EesSpecificActivity(){
        Console.Write(_eesBreatheIn);
        CreateCountdown();
        Console.Write(_eesBreatheOut);
        CreateCountdown();

    }

}