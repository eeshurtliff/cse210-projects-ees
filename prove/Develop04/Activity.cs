using System;

class Activity{
    protected string _eesName;
    protected string _eesDescription;
    protected int _eesDuration;
    protected List<string> _eesPrompts = new List<string>();
    private List<string> _eesAnimationItems = new List<string>{"|", "/", "-", "\\"};



    public Activity(string eesName, string eesDescription){
        _eesName = eesName;
        _eesDescription = eesDescription;
        //EesStartingMessage();
    }


    public Activity(string eesName, string eesDescription, List<string> eesPrompts){
        _eesName = eesName;
        _eesDescription = eesDescription;
        _eesPrompts = eesPrompts;
    }
    protected void EesCreateAnimation(int time){
        DateTime eesStartTime = DateTime.Now;
        DateTime eesEndTime = eesStartTime.AddSeconds(time);
        int i = 0;
        while (DateTime.Now < eesEndTime){
            string s = _eesAnimationItems[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i > _eesAnimationItems.Count()){
                i = 0;
            }


        }
        // foreach (string item in _eesAnimationItems){
        //     Console.Write(item);
        //     Thread.Sleep(1000);
        //     Console.Write("\b \b");

        // }
    }

    protected void EesCreateCountdown(int eesNumber){
        for (int i = eesNumber; i > 0; i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        
        }
    }

    protected int EesReturnRandomNumber(List<string> eesList){
        Random eesGenerator = new Random();
        int eesNumber = eesGenerator.Next(0, eesList.Count());
        return eesNumber;
    }
    protected void EesStartingMessage(){
        Console.WriteLine($" Welcome to the{_eesName}. "); 
        Console.WriteLine();
        Console.WriteLine($"{_eesDescription} ");
        Console.WriteLine();
        Thread.Sleep(2000);
        Console.Write("How long, in seconds, would you like your session to last? ");
        
        _eesDuration = int.Parse(Console.ReadLine());

        
        Thread.Sleep(1000);
        Console.WriteLine($"Your activity will last for {_eesDuration} seconds.");
        Console.WriteLine();
        Thread.Sleep(2000);
        Console.WriteLine("Get ready...");
        Console.WriteLine();
        Thread.Sleep(2000);
    }

    protected void EesEndingMessage(){
        Console.WriteLine("Well done!");
        Console.WriteLine();
        Thread.Sleep(2000);
        Console.WriteLine($"You have completed another {_eesDuration} seconds of {_eesName}");
        Thread.Sleep(2000);
        
    }          


    // public void RunActivity(){

    //     EesStartingMessage();
    //     DateTime eesStartActivity = DateTime.Now;
    //     DateTime eesEndTime = eesStartActivity.AddSeconds(_eesDuration);
    //     if (_eesPrompts != null){
    //         Console.WriteLine("Please read the following prompt:");
    //     }

    //     while(DateTime.Now < eesEndTime){
    //         if (_eesName == "Breathing Activity"){
    //             BreathingActivity.EesSpecificActivity();
    //         }else if (_eesName == "Reflection Activity"){

    //         }else{

    //         }
    //     }


    //     EesEndingMessage();
    // } 





}