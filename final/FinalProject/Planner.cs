class Planner{
    private List<Appointment> _eesAppointmentList = new List<Appointment>();
    private List<Task> _eesTaskList = new List<Task>();
    private List<Event> _eesFullList = new List<Event>();


//Creates an empty planner that can be filled in overTime
    public Planner(){

    }

//creates a planner with events already entered in
    public Planner(List<Appointment> eesAppointmentList, List<Task> eesTaskList){
        _eesAppointmentList = eesAppointmentList;
        _eesTaskList = eesTaskList;
    }


    public void EesAddToAppointmentList(Appointment eesNewAppointment){
        
        _eesAppointmentList.Add(eesNewAppointment);
        
    }

    public List<Appointment> EesGetAppointments(){
        _eesAppointmentList.Sort((x, y) => DateTime.Compare(x.EesGetFirstTime(), y.EesGetFirstTime()));
        return _eesAppointmentList;
    }


    public void EesAddToFullList(Event eesEvent){
        _eesFullList.Add(eesEvent);
    }


    public List<Event> EesGetFullList(){
        _eesFullList.Sort((x, y) => DateTime.Compare(x.EesGetFirstTime(), y.EesGetFirstTime()));
        return _eesFullList;
    }


    public void EesAddToTaskList(Task eesNewTask){
        _eesTaskList.Add(eesNewTask);
    }

    public List<Task> EesGetTasks(){
        _eesTaskList.Sort((x, y) => DateTime.Compare(x.EesGetFirstTime(), y.EesGetFirstTime()));
        return _eesTaskList;
    }

       
    public void EesDisplayPlanner(){
       


        
    }
}