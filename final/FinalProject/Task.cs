class Task : Event{
    protected DateTime _eesDueDate;
    protected DateTime _eesPreferedDue;
    protected string _eesTaskType;


    public Task(string eesType, string eesTitle, string eesDescription, List<string> eesSupplies, bool eesIsComplete, DateTime eesDueDate, DateTime eesPreferedDue, string eesTaskType) : base(eesType, eesTitle, eesDescription, eesSupplies, eesIsComplete){
        _eesDueDate = eesDueDate;
        _eesPreferedDue = eesPreferedDue;
        _eesTaskType = eesTaskType;
    }

    public override string EesToString(){
        return "";
    }

    public override void EesRecordEvent()
    {
        
    }


}