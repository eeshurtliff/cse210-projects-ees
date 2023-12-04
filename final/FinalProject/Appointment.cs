class Appointment : Event{
    protected DateTime _eesStartTime;
    protected DateTime _eesEndTime;

    protected bool _eesIsComplete;
    


    public Appointment(string eesType, string eesTitle, string eesDescription, List<string> eesSupplies, bool eesIsComplete, DateTime eesStartTime, DateTime eesEndTime) : base(eesType, eesTitle, eesDescription, eesSupplies){
        _eesStartTime = eesStartTime;
        _eesEndTime = eesEndTime;
        _eesIsComplete = eesIsComplete;
    }


    public override void EesRecordEvent(){

    }


    public override string EesToString(){
        return "";
    }

    public string EesDisplayAppointment(){
        return "";
    }
}