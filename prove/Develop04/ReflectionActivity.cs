class ReflectionActivity : Activity{
    private List<string> _eesQuestions = new List<string>{
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        ""
    };
    private int _eesTimePerQuestion;


    public ReflectionActivity(string eesName, string eesDescription, int eesTimePerQuestion) : base(eesName, eesDescription){
        _eesTimePerQuestion = eesTimePerQuestion;
    }

    public void EesSpecificActivity(){
        int eesRandom = base.EesReturnRandomNumber(_eesQuestions);
    }
}