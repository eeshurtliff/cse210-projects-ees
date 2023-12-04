class Appointment : Event{
    protected DateTime _eesStartTime;
    protected DateTime _eesEndTime;

    protected bool _eesIsComplete;
    


    public Appointment(string eesType, string eesTitle, string eesDescription, List<string> eesSupplies, DateTime eesStartTime, DateTime eesEndTime, bool eesIsComplete) : base(eesType, eesTitle, eesDescription, eesSupplies){
        _eesStartTime = eesStartTime;
        _eesEndTime = eesEndTime;
        _eesIsComplete = eesIsComplete;
    }


    public override void EesRecordEvent(){

    }


    public override string EesToString(){
        return $"{_eesType}: {_eesTitle}, {_eesDescription}, {_eesSupplies}, {_eesStartTime}, {_eesEndTime}, {_eesIsComplete} ";
    }

    public string EesDisplayAppointment(){
        string eesPrintedComplete;
        if (_eesIsComplete){
            eesPrintedComplete = "[x]";
        }else{
            eesPrintedComplete = "[ ]";
        }
        
        return $"{eesPrintedComplete} Your \"{_eesTitle}\" {_eesType} is from {_eesStartTime} to {_eesEndTime}. ";
    }
}