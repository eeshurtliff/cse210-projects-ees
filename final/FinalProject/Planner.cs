class Planner{
    private List<Appointment> _eesAppointmentList = new List<Appointment>();
    private List<Task> _eesTaskList = new List<Task>();


//Creates an empty planner that can be filled in overTime
    public Planner(){

    }

//creates a planner with events already entered in
    public Planner(List<Appointment> eesAppointmentList, List<Task> eesTaskList){
        _eesAppointmentList = eesAppointmentList;
        _eesTaskList = eesTaskList;
    }


    public string EesDisplayPlanner(){
        return "";
    }
}