abstract class Event{

    /// <summary>
    ///The Event class holds everything that Appointments and Tasks have in common
    /// </summary>
    protected string _eesType;
    protected string _eesTitle;
    protected string _eesDescription;
    protected List<string> _eesSupplies = new List<string>();
    



    public Event(string eesType, string eesTitle, string eesDescription, List<string> eesSupplies){
        _eesType = eesType;
        _eesTitle = eesTitle;
        _eesDescription = eesDescription;
        _eesSupplies = eesSupplies;
       

    }

    public string eesGetType(){
        return _eesType;
    }

    public abstract DateTime EesGetFirstTime();

    
   
    

    public abstract void EesRecordEvent();

    public string EesListToString(){
        string eesSupplyList = "";
        foreach (string eesSupply in _eesSupplies){
            string eesTrimmedSupply = eesSupply.Trim();
            eesSupplyList += eesTrimmedSupply + "*";
        }
        //eesSupplyList += ">";
        return eesSupplyList;
    }

    public string EesDateTimeToString(DateTime eesNewDate){
        return eesNewDate.ToString("MM/dd/yyyy hh:mm tt");

    }

    public abstract override string ToString();

    public abstract string EesDisplayInPlanner();






}