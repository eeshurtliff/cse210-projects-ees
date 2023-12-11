class Repeat : Task{
    private int _eesNumberOfWeeks;
    private int _eesWeeksCompleted;


    public Repeat(string eesType, string eesTitle, string eesDescription, List<string> eesSupplies, bool eesIsComplete,  DateTime eesDueDate, DateTime eesPreferedDue, string eesTaskType,int eesNumberOfWeeks, int eesWeeksCompleted) : base(eesType, eesTitle, eesDescription, eesSupplies, eesIsComplete, eesDueDate, eesPreferedDue, eesTaskType){
        _eesNumberOfWeeks = eesNumberOfWeeks;
        _eesWeeksCompleted = eesWeeksCompleted;
    }

    public override void EesRecordEvent(){
        if (base._eesIsComplete == false){
            _eesWeeksCompleted += 1;
            if (_eesNumberOfWeeks == _eesWeeksCompleted){
                base._eesIsComplete = true;
            }
        }
    }

    public override string ToString(){
        return $"{_eesType}:: {_eesTaskType}, {_eesTitle}, {_eesDescription}, {base.EesListToString()}, {_eesPreferedDue}, {_eesDueDate}, {_eesNumberOfWeeks}, {_eesWeeksCompleted}, {_eesIsComplete} ";
    }

    public override string EesDisplayInPlanner(){
        string eesPrintedComplete;
        if (_eesIsComplete){
            eesPrintedComplete = "[x]";
        }else{
            eesPrintedComplete = "[ ]";
        }

        return $"{eesPrintedComplete} Your \"{_eesTitle}\" {_eesType} is planned to be complete by {_eesPreferedDue} and is officially due on {_eesDueDate}. This goal has been completed for {_eesNumberOfWeeks} out of {_eesWeeksCompleted} weeks. ";
    }


}