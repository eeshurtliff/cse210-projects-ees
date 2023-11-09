using System;

class ReflectionActivity : Activity{
    private List<string> _eesQuestions = new List<string>{
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    private int _eesTimePerQuestion;


    public ReflectionActivity(string eesName, string eesDescription, List<string> eesPrompts, int eesTimePerQuestion) : base(eesName, eesDescription, eesPrompts){
        _eesTimePerQuestion = eesTimePerQuestion;
    }

    

    public void EesRunActivity(){

        base.EesStartingMessage();
        
        Console.WriteLine("Please read the following prompt:");
        int eesRandomPrompt = base.EesReturnRandomNumber(_eesPrompts);
        string eesChosenPrompt = _eesPrompts[eesRandomPrompt];
        Console.WriteLine($"{eesChosenPrompt}");
        Console.Write("Press enter to continue.");
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Now ponder on each of the following questions as they are related to this experience.");
        Thread.Sleep(2000);
        Console.Write("You may begin in: ");
        EesCreateCountdown(5);
        DateTime eesStartActivity = DateTime.Now;
        DateTime eesEndTime = eesStartActivity.AddSeconds(_eesDuration);
        Console.Clear();

        while(DateTime.Now < eesEndTime){
        
            int eesRandom = base.EesReturnRandomNumber(_eesQuestions);
            string eesChosenQuestion = _eesQuestions[eesRandom];
            Console.Write($"--- {eesChosenQuestion} ---");
            base.EesCreateAnimation(_eesTimePerQuestion);
            Console.WriteLine();
        }


        base.EesEndingMessage();
        Thread.Sleep(2000);
        Console.Clear();
    } 
}