class Repeat : Task{
    private int _eesNumberOfWeeks;
    private int _eesWeeksCompleted;


    Repeat(string eesType, string eesTaskType, string eesTitle, string eesDescription, List<string> eesSupplies, bool eesIsComplete,  DateTime eesDueDate, DateTime eesPreferedDue, int eesNumberOfWeeks, int eesWeeksCompleted) : base(eesType, eesTitle, eesDescription, eesSupplies, eesIsComplete, eesDueDate, eesPreferedDue, eesTaskType){
        _eesNumberOfWeeks = eesNumberOfWeeks;
        _eesWeeksCompleted = eesWeeksCompleted;
    }


}