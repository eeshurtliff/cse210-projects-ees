class Once : Task {
    


    public Once(string eesType, string eesTitle, string eesDescription, List<string> eesSupplies, bool eesIsComplete, DateTime eesDueDate, DateTime eesPreferedDue, string eesTaskType) : base(eesType, eesTitle, eesDescription, eesSupplies, eesIsComplete, eesDueDate, eesPreferedDue, eesTaskType){
        
    }

    


    public override string EesDisplayInPlanner()
    {
        string eesPrintedComplete;
        if (_eesIsComplete){
            eesPrintedComplete = "[x]";
        }else{
            eesPrintedComplete = "[ ]";
        }

        return $"{eesPrintedComplete} Your \"{_eesTitle}\" {_eesType} is planned to be complete by {_eesPreferedDue} and is officially due on {_eesDueDate}. ";
    }
}