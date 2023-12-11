class SaveAndLoad {
    private string _eesFilename;
    private bool _eesIsLoaded;


    public SaveAndLoad(string eesFilename){
        _eesFilename = eesFilename;
    }



    private void EesGetFileData(){
        
        string[] eesLines = System.IO.File.ReadAllLines(_eesFilename);

        foreach (string eesLine in eesLines)
        {
            string[] parts = eesLine.Split(",");

            string firstName = parts[0];
            string lastName = parts[1];
        }

    }

//checks to see if anything is in the file. If not, it saves the planner to the file. If something is in the file, it checks to make sure
//The data in the file has been loaded before saving. 
    public void EesSaveToFile(Planner eesPlanner){


        List<string> eesLines = System.IO.File.ReadAllLines(_eesFilename).ToList();

        // if (filename.Exists)
        using (StreamWriter eesOutputFile = new StreamWriter(_eesFilename, false))
        {
            if (eesLines.Count() != 0){
                //check to see if the data from the file has been loaded. If it has, continue. If not, require the user to load the file first. 
                if (_eesIsLoaded){
                    List<Appointment> eesAppointments = eesPlanner.EesGetAppointments();
                    List<Task> eesTasks = eesPlanner.EesGetTasks();

                    eesOutputFile.WriteLine("Appointments: ");
                    foreach (Appointment eesAppointment in eesAppointments){
                        eesOutputFile.WriteLine(eesAppointment.ToString());
                    }
                    
                    eesOutputFile.WriteLine("Tasks: ");
                    foreach (Task eesTask in eesTasks){
                        eesOutputFile.WriteLine(eesTask.ToString());
                    }
                }else{
                    Console.WriteLine("This file has data that has not been loaded into the program. Please load the file before saving new data. ");
                }
                
                
            }else{

                List<Appointment> eesAppointments = eesPlanner.EesGetAppointments();
                List<Task> eesTasks = eesPlanner.EesGetTasks();

                eesOutputFile.WriteLine("Appointments: ");
                foreach (Appointment eesAppointment in eesAppointments){
                    eesOutputFile.WriteLine(eesAppointment.ToString());
                }
                
                eesOutputFile.WriteLine("Tasks: ");
                foreach (Task eesTask in eesTasks){
                    eesOutputFile.WriteLine(eesTask.ToString());
                }

                
            }
        
        }
    }
//reads all of the lines in the file, then runs through each line to create the event and add it to the planner lists. 
    public void EesLoadPlanner(Planner eesPlanner){

        //If the file has already been loaded, it does not need to be loaded again. 
        if (_eesIsLoaded == false){
        
            string[] eesLines = System.IO.File.ReadAllLines(_eesFilename);


            foreach (string eesLine in eesLines)
            {
                if (eesLine != "Appointments: " && eesLine != "Tasks: "){

                    List<string> eesSupplies = new List<string>();
                    string[] eesParts = eesLine.Split("::");

                    string eesType = eesParts[0];
                    string[] eesDescriptors = eesParts[1].Trim().Split(',');
                    string eesSuppliesAsString = eesDescriptors[2];
                    string[] eesSuppliesSplit = eesSuppliesAsString.Trim().Split('*');
                    foreach (string eesSupply in eesSuppliesSplit){
                        eesSupplies.Add(eesSupply);
                    }
                    
                    string eesTitle = eesDescriptors[0];
                    string eesDescription = eesDescriptors[1];

                    if (eesType == "appointment"){
                        String eesFirstTimeString = eesDescriptors[3];
                        DateTime eesFirstTime = EesStringToDateTime(eesFirstTimeString);

                        String eesSecondTimeString = eesDescriptors[4];
                        DateTime eesSecondTime = EesStringToDateTime(eesSecondTimeString);

                        bool eesIsComplete = bool.Parse(eesDescriptors[5]);

                        Appointment eesNewEvent = new Appointment(eesType, eesTitle, eesDescription, eesSupplies, eesFirstTime, eesSecondTime, eesIsComplete);
                        eesPlanner.EesAddToAppointmentList(eesNewEvent);
                        eesPlanner.EesAddToFullList(eesNewEvent);  


                        
                        
                    }else{

                        bool eesIsComplete = bool.Parse(eesDescriptors[3]);

                        String eesFirstTimeString = eesDescriptors[4];
                        DateTime eesFirstTime = EesStringToDateTime(eesFirstTimeString);

                        String eesSecondTimeString = eesDescriptors[5];
                        DateTime eesSecondTime = EesStringToDateTime(eesSecondTimeString);

                        string eesTaskType = eesDescriptors[6];

                        if (eesTaskType == "repeat"){
                            int eesWeeksTotal = int.Parse(eesDescriptors[7]);
                            int eesWeeksCompleted = int.Parse(eesDescriptors[8]);

                            Repeat eesNewEvent = new Repeat("task",  eesTitle, eesDescription, eesSupplies, eesIsComplete, eesSecondTime, eesFirstTime, eesTaskType, eesWeeksTotal, eesWeeksCompleted);
                            eesPlanner.EesAddToTaskList(eesNewEvent);
                            eesPlanner.EesAddToFullList(eesNewEvent);   
                        }else{

                            Once eesNewEvent = new Once("task", eesTitle, eesDescription, eesSupplies, eesIsComplete, eesSecondTime, eesFirstTime, eesTaskType);
                            eesPlanner.EesAddToTaskList(eesNewEvent);
                            eesPlanner.EesAddToFullList(eesNewEvent);   
                        }



                    }
                }
            }
        }
        _eesIsLoaded = true;
    }


    private DateTime EesStringToDateTime(string eesNewDate){
        //splits up the datetime string and recreates it as a DateTime type
        string[] eesSplitDateTime = eesNewDate.Trim().Split(' ');
        string eesDate = eesSplitDateTime[0];
        string eesTime = eesSplitDateTime[1];
        string eesAmPm = eesSplitDateTime[2];

        string[] eesSplitDate = eesDate.Split('/');
        int eesMonth = int.Parse(eesSplitDate[0]);
        int eesDay = int.Parse(eesSplitDate[1]);
        int eesYear = int.Parse(eesSplitDate[2]);

        string[] eesSplitTime = eesTime.Split(":");
        int eesHour = int.Parse(eesSplitTime[0]);
        int eesMinute = int.Parse(eesSplitTime[1]);

        if (eesAmPm == "PM"){
            eesHour += 12;
        }

        DateTime eesCompleteDate = new DateTime(eesYear, eesMonth, eesDay, eesHour, eesMinute, 0);
        return eesCompleteDate;

        

    }

}
    