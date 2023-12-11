class Appointment : Event{
    protected DateTime _eesStartTime;
    protected DateTime _eesEndTime;

    protected bool _eesIsComplete;
    


    public Appointment(string eesType, string eesTitle, string eesDescription, List<string> eesSupplies, DateTime eesStartTime, DateTime eesEndTime, bool eesIsComplete) : base(eesType, eesTitle, eesDescription, eesSupplies){
        _eesStartTime = eesStartTime;
        _eesEndTime = eesEndTime;
        _eesIsComplete = eesIsComplete;
    }


    public override DateTime EesGetFirstTime(){
        return _eesStartTime;
    }


    public override void EesRecordEvent(){
        _eesIsComplete = true;
    }




    public override string ToString(){

        return $"{_eesType}:: {_eesTitle}, {_eesDescription}, {base.EesListToString()}, {_eesStartTime}, {_eesEndTime}, {_eesIsComplete} ";
    }

    public override string EesDisplayInPlanner(){
        string eesPrintedComplete;
        if (_eesIsComplete){
            eesPrintedComplete = "[x]";
        }else{
            eesPrintedComplete = "[ ]";
        }

        return $"{eesPrintedComplete} Your \"{_eesTitle}\" {_eesType} is from {_eesStartTime} to {_eesEndTime}. ";
    }
}