class Task : Event{
    protected DateTime _eesDueDate;
    protected DateTime _eesPreferedDue;


    public Task(string eesType, string eesTitle, string eesDescription, List<string> eesSupplies, bool eesIsComplete, DateTime eesDueDate, DateTime eesPreferedDue) : base(eesType, eesTitle, eesDescription, eesSupplies, eesIsComplete){
        _eesDueDate = eesDueDate;
        _eesPreferedDue = eesPreferedDue;
    }


}