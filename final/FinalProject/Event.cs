abstract class Event{

    /// <summary>
    ///The Event class holds everything that Appointments and Tasks have in common
    /// </summary>
    protected string _eesType;
    protected string _eesTitle;
    protected string _eesDescription;
    protected List<string> _eesSupplies = new List<string>();
    protected bool _eesIsComplete;



    public Event(string eesType, string eesTitle, string eesDescription, List<string> eesSupplies, bool eesIsComplete){
        _eesType = eesType;
        _eesTitle = eesTitle;
        _eesDescription = eesDescription;
        _eesSupplies = eesSupplies;
        _eesIsComplete = eesIsComplete;

    }

    public abstract void EesRecordEvent();

    public abstract string EesToString();






}