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
    
    
    public override DateTime EesGetFirstTime(){
        return _eesPreferedDue;
    }

    public override string ToString(){
        return $"{_eesType}:: {_eesTaskType}, {_eesTitle}, {_eesDescription}, {base.EesListToString()}, {_eesPreferedDue}, {_eesDueDate}, {_eesIsComplete} ";
    }

    public override void EesRecordEvent()
    {
        _eesIsComplete = true;
    }

    //public over string EesDisplayInPlanner();


}