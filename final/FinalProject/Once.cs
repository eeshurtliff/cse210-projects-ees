class Once : Task {
    


    public Once(string eesType, string eesTitle, string eesDescription, List<string> eesSupplies, bool eesIsComplete, DateTime eesDueDate, DateTime eesPreferedDue, string eesTaskType) : base(eesType, eesTitle, eesDescription, eesSupplies, eesIsComplete, eesDueDate, eesPreferedDue, eesTaskType){
        
    }


    public override string EesDisplayTask()
    {
        return "";
    }
}