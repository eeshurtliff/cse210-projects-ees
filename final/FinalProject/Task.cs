abstract class Task : Event{
    protected DateTime _eesDueDate;
    protected DateTime _eesPreferedDue;
    protected string _eesTaskType;

    protected bool _eesIsComplete;


    public Task(string eesType, string eesTitle, string eesDescription, List<string> eesSupplies, bool eesIsComplete, DateTime eesDueDate, DateTime eesPreferedDue, string eesTaskType) : base(eesType, eesTitle, eesDescription, eesSupplies){
        _eesDueDate = eesDueDate;
        _eesPreferedDue = eesPreferedDue;
        _eesTaskType = eesTaskType;
        _eesIsComplete = eesIsComplete;
    }

    public override string EesToString(){
        return "";
    }

    public override void EesRecordEvent()
    {
        
    }

    public abstract string EesDisplayTask();


}