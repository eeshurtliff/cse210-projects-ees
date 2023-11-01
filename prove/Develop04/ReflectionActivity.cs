class ReflectionActivity : Activity{
    private List<string> _eesQuestions;
    private int _eesTimePerQuestion;


    public ReflectionActivity(string eesName, string eesDescription, int eesTimePerQuestion) : base(eesName, eesDescription){
        _eesTimePerQuestion = eesTimePerQuestion;
    }

}