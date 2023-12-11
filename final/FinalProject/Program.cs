using System;

class Program
{

// This function displays the menu and returns the user's choice to the main function
    static int EesMenu(){
            Console.WriteLine("Choose an option from the menu: ");
            Console.WriteLine("1. Load the Planner");
            Console.WriteLine("2. Save the Planner");
            Console.WriteLine("3. Add a new event");
            Console.WriteLine("4. View Planner");
            Console.WriteLine("5. Mark event complete");
            Console.WriteLine("6. Exit");
            Console.WriteLine();
            Console.WriteLine("Please enter the number of the option you chose: ");
            return EesGetOptionChoice(6);
        
    }


// takes a response and continues to ask for a response until the answer is in the range required for the question. 
// This is a separate function because it is needed multiple times in the program
    static int EesGetOptionChoice(int eesHighRange){
        bool eesGotResponse = false;
        int eesResponseNumber;
        do{
            Console.Write("> ");
            string eesUserResponse = Console.ReadLine();
        if (int.TryParse(eesUserResponse, out eesResponseNumber)){
             if (eesResponseNumber >= 1 && eesResponseNumber <= eesHighRange){
                    eesGotResponse = true;
                }else{
                    Console.WriteLine($"That number is not in the range 1-{eesHighRange}. Please try again. ");
                }
            }else{
                Console.WriteLine("That is not a number. Please try again. ");
            }
        }while (eesGotResponse == false);
        return eesResponseNumber;

    }

    static int EesGetDayOfMonth(int eesMonth){
        int eesNewDay;
        List<int> eesListForThirty = new List<int>{4, 6, 9, 11};
        List<int> eesListForThirtyOne = new List<int>{1, 3, 5, 7, 8, 10, 12};
        if (eesListForThirty.Contains(eesMonth) ){
            eesNewDay = EesGetOptionChoice(30);

        }else if (eesListForThirtyOne.Contains(eesMonth)){
            eesNewDay = EesGetOptionChoice(31);
        }else{
            eesNewDay = EesGetOptionChoice(28);
        }
        return eesNewDay;
    }



    static List<int> EesGetTime(){
        int eesStartHour;
        int eesStartMinute;
        List<int> eesFinalStartTime = new List<int>();
        bool eesGotTime = false;
        do{
            Console.Write("> ");
            string eesStartTime = Console.ReadLine();
                if (eesStartTime.Contains(":")){
                    List<string> eesStartTimeParts = eesStartTime.Split(new char [] {':', ' '}).ToList();
                    string eesStartHourString = eesStartTimeParts[0];
                    string eesStartMinuteString = eesStartTimeParts[1];
                    if (int.TryParse(eesStartHourString, out eesStartHour ) && int.TryParse(eesStartMinuteString, out eesStartMinute)){
                        if (eesStartTime.Contains("am") || eesStartTime.Contains("a.m.") || eesStartTime.Contains("pm") || eesStartTime.Contains("p.m.") || eesStartTime.Contains("AM") || eesStartTime.Contains("A.M.") || eesStartTime.Contains("P.M.")  || eesStartTime.ToLower().Contains("PM")){
                            if (eesStartHour >= 1 && eesStartHour <= 12 && eesStartMinute >= 0 && eesStartMinute <= 59){
                                string eesStartDeterminer = eesStartTimeParts[2];
                                if (eesStartDeterminer.ToLower() == "am" || eesStartDeterminer.ToLower() == "a.m."){
                                    eesFinalStartTime.Add(eesStartHour);
                                    eesFinalStartTime.Add(eesStartMinute);
                                    eesGotTime = true;
                                }else{
                                    
                                    eesStartHour += 12;
                                    if (eesStartHour > 24){
                                        eesStartHour -= 24;
                                    }

                                    eesFinalStartTime.Add(eesStartHour);
                                    eesFinalStartTime.Add(eesStartMinute);
                                    eesGotTime = true;
                                    
                                }
                            }else{
                                Console.WriteLine("Please enter a time in military (00:00) or standard (12:00 am) format. ");
                            }
                        }else{  //military time
                            if (eesStartHour >= 0 && eesStartHour <= 24 && eesStartMinute >= 0 && eesStartMinute <= 59){
                                eesFinalStartTime.Add(eesStartHour);
                                eesFinalStartTime.Add(eesStartMinute);
                                eesGotTime = true;
                            }else{
                                Console.WriteLine("Please enter a time in military (00:00) or standard (12:00 am) format. ");
                            }
                        }
                    }else{
                        Console.WriteLine("Please enter a time in military (00:00) or standard (12:00 am) format. ");
                    }
                }else{
                     Console.WriteLine("Please enter a time in military (00:00) or standard (12:00 am) format. ");
                }

        }while (eesGotTime == false);

        return eesFinalStartTime;
    }



    static void EesCreateEvent(Planner eesPlanner){
        Console.WriteLine("Choose an event to create: ");
        Console.WriteLine("1. Appointment: an event that is scheduled to happen at a specific time. ");
        Console.WriteLine("2. Task: an event that has a date it must be completed by. ");
        Console.WriteLine("Which event would you like to create? ");
        int eesChoice = EesGetOptionChoice(2);
        Console.WriteLine();

        // ask for information needed for appointments and all task types
        Console.WriteLine("What is the title of your event? ");
        Console.Write(">");
        string eesNewTitle = Console.ReadLine();

        Console.WriteLine("What is the description of your event? ");
        Console.Write(">");
        string eesNewDescription = Console.ReadLine();

        Console.WriteLine("What will you need to bring to the event? (separate the items by commas): ");
        Console.Write(">");
        string eesNewSuppliesString = Console.ReadLine();
        List<string> eesNewSupplies = eesNewSuppliesString.Split(",").ToList();

        Console.WriteLine("What month is the event in?(Please enter the number) ");
        int eesNewMonth = EesGetOptionChoice(12);

        // variables used in both appoinments and tasks
        string eesYear = DateTime.Now.ToString("yyyy");

        if (eesChoice == 1){
            int eesNewDay;
            List<int> eesStartTime;
            List<int> eesEndTime;
            DateTime eesStart = new DateTime();
            DateTime eesEnd = new DateTime();
            Console.WriteLine("Does this appointment last more than one day?(y/n) ");
            bool eesGotAnswer = false;
            do{
                Console.Write(">");
                string eesLengthOfDays = Console.ReadLine().ToLower();
                if (eesLengthOfDays == "no" || eesLengthOfDays == "n"){
                   
                    Console.WriteLine("What day of the month is it on? (Please enter in number form)");
                    eesNewDay = EesGetDayOfMonth(eesNewMonth);
                    Console.WriteLine("What time does the appointment start? (00:00) ");
                    eesStartTime = EesGetTime();
                    Console.WriteLine("What time does the appointment end? (00:00) ");
                    eesEndTime = EesGetTime();

                    eesStart = new DateTime(int.Parse(eesYear), eesNewMonth, eesNewDay, eesStartTime[0], eesStartTime[1], 0 );
                    eesEnd = new DateTime(int.Parse(eesYear), eesNewMonth, eesNewDay, eesEndTime[0], eesEndTime[1], 0 );

                    eesGotAnswer = true;

              // sets up appointment that lasts multiple days
                }else if (eesLengthOfDays == "yes" || eesLengthOfDays == "y"){
                    Console.WriteLine("What day does this appointment begin? (please enter in number form) ");
                    int eesStartDay = EesGetDayOfMonth(eesNewMonth);
                    
                    Console.WriteLine("What time does the appointment start? (00:00) ");
                    eesStartTime = EesGetTime();
                    Console.WriteLine(eesStartTime);

                    Console.WriteLine("What day does this appointment begin? (please enter in number form) ");
                    int eesEndDay;
                    do{
                        eesEndDay = EesGetDayOfMonth(eesNewMonth);
                        if (eesEndDay < eesStartDay){
                            Console.WriteLine("The appointment's end day cannot be before it's start day. ");
                        }
                    }while (eesEndDay < eesStartDay);

                    Console.WriteLine("What time does the appointment end? (00:00)");
                    eesEndTime = EesGetTime();

                    eesStart = new DateTime(int.Parse(eesYear), eesNewMonth, eesStartDay, eesStartTime[0], eesStartTime[1], 0 );
                    eesEnd = new DateTime(int.Parse(eesYear), eesNewMonth, eesEndDay, eesEndTime[0], eesEndTime[1], 0 );

                    eesGotAnswer = true;
                }else{
                    Console.WriteLine("Please answer yes or no. ");
                }
            }while(eesGotAnswer == false);
            
            Appointment eesNewEvent = new Appointment("appointment", eesNewTitle, eesNewDescription, eesNewSupplies, eesStart, eesEnd, false);
            eesPlanner.EesAddToAppointmentList(eesNewEvent);
            eesPlanner.EesAddToFullList(eesNewEvent);   

        }else{   //2
            int eesDueDay;
            int eesPreferedDay;
            List<int> eesDueTime;
            List<int> eesPreferedTime;
            DateTime eesDue = new DateTime();
            DateTime eesPrefered = new DateTime();

            Console.WriteLine("Choose a type of task to create: ");
            Console.WriteLine("1. One time task");
            Console.WriteLine("2. Repeated task: repeated weekly ");
            // Console.WriteLine("3. Complex task: made up of multiple smaller tasks ");
            int eesTaskChoice = EesGetOptionChoice(2);

            Console.WriteLine("What day of the month is it due? (Please enter in number form)");
            eesDueDay = EesGetDayOfMonth(eesNewMonth);
            Console.WriteLine($"What time is the task due on {eesNewMonth}/{eesDueDay}? (00:00) ");
            eesDueTime = EesGetTime();

            Console.WriteLine("What day of the month would you like to finish it? (Please enter in number form)");
            eesPreferedDay = EesGetDayOfMonth(eesNewMonth);
            Console.WriteLine($"What time would you like to finish the task on {eesNewMonth}/{eesPreferedDay}? (00:00) ");
            eesPreferedTime = EesGetTime();

            eesDue = new DateTime(int.Parse(eesYear), eesNewMonth, eesDueDay, eesDueTime[0], eesDueTime[1], 0 );
            eesPrefered = new DateTime(int.Parse(eesYear), eesNewMonth, eesPreferedDay, eesPreferedTime[0], eesPreferedTime[1], 0 );

            Console.WriteLine("");
            if (eesTaskChoice == 1){
                Once eesNewEvent = new Once("task", eesNewTitle, eesNewDescription, eesNewSupplies, false, eesDue, eesPrefered, "once");
                eesPlanner.EesAddToTaskList(eesNewEvent);
                eesPlanner.EesAddToFullList(eesNewEvent);   

            }else{ // if (eesTaskChoice == 2){
                Console.WriteLine("How many weeks will this task repeat? (max=10) ");
                int eesRepeatNumber = EesGetOptionChoice(10);
                Repeat eesNewEvent = new Repeat("task",  eesNewTitle, eesNewDescription, eesNewSupplies, false, eesDue, eesPrefered, "repeat", eesRepeatNumber, 0);
                eesPlanner.EesAddToTaskList(eesNewEvent);
                eesPlanner.EesAddToFullList(eesNewEvent);   
             }
        }
             
    }





    static void eesDisplayEvents(Planner eesPlanner, int eesUserChoice){
        // Console.WriteLine("Please select a choice for what you would like to view: ");
        // Console.WriteLine("1. View entire planner ");
        // Console.WriteLine("2. View all Appointments ");
        // Console.WriteLine("3. View all Tasks ");
        // Console.WriteLine("Which option would you like to choose? ");
        // int eesUserChoice = EesGetOptionChoice(3);
        if (eesUserChoice == 1){
            int eesI = 1;
            List<Event> eesFull = eesPlanner.EesGetFullList();
            Console.WriteLine(" --2023 Planner--");
            DateTime eesCurrentDate = DateTime.Now;
            string eesDay = eesCurrentDate.ToString("dddd dd MM yyyy");
            List<string> eesDayList = eesDay.Split(new char [] { ' '}).ToList();
            int eesDayIndex = 1;
            int eesMonthIndex = 2;

             int eesDayDate = int.Parse(eesDayList[eesDayIndex]);
            int eesDayMonth = int.Parse(eesDayList[eesMonthIndex]);
            // prints the current date to start the callendar
            Console.WriteLine(eesCurrentDate.ToString("dddd, dd MMMM yyyy"));

            foreach (Event eesEvent in eesFull){
               
                DateTime eesNewDate = eesEvent.EesGetFirstTime();
                List<string> eesNewDateList = eesNewDate.ToString("dddd dd MM yyyy").Split(new char[] { ' '}).ToList();

                int eesNewDateDay = int.Parse(eesNewDateList[eesDayIndex]);
                int eesNewMonth = int.Parse(eesNewDateList[eesMonthIndex]);

                if (eesNewMonth == eesDayMonth){
                    if (eesDayDate < eesNewDateDay){
                        Console.WriteLine();
                        eesCurrentDate = eesNewDate;
                        Console.WriteLine(eesCurrentDate.ToString("dddd, dd MMMM yyyy"));
                    }

                }else{
                    eesCurrentDate = eesNewDate;
                    Console.WriteLine(eesCurrentDate.ToString("dddd, dd MMMM yyyy"));
                    Console.WriteLine();
                }
                
                Console.WriteLine($"{eesI}. {eesEvent.EesDisplayInPlanner()}");
                eesI += 1;






            }
        }else if (eesUserChoice == 2){

             int eesI = 1;
            List<Appointment> eesFull = eesPlanner.EesGetAppointments();
            Console.WriteLine(" --2023 Appointments--");
            DateTime eesCurrentDate = DateTime.Now;
            string eesDay = eesCurrentDate.ToString("dddd dd MM yyyy");
            List<string> eesDayList = eesDay.Split(new char [] {',', ' '}).ToList();
            int eesDayIndex = 1;
            int eesMonthIndex = 2;

             int eesDayDate = int.Parse(eesDayList[eesDayIndex]);
            int eesDayMonth = int.Parse(eesDayList[eesMonthIndex]);
            // prints the current date to start the callendar
            Console.WriteLine(eesCurrentDate.ToString("dddd, dd MMMM yyyy"));

            foreach (Appointment eesEvent in eesFull){
                
                DateTime eesNewDate = eesEvent.EesGetFirstTime();
                List<string> eesNewDateList = eesNewDate.ToString("dddd dd MM yyyy").Split(new char[] {',', ' '}).ToList();

                int eesNewDateDay = int.Parse(eesNewDateList[eesDayIndex]);
                int eesNewMonth = int.Parse(eesNewDateList[eesMonthIndex]);

                if (eesNewMonth == eesDayMonth){
                    if (eesDayDate < eesNewDateDay){
                        Console.WriteLine();
                        eesCurrentDate = eesNewDate;
                        Console.WriteLine(eesCurrentDate.ToString("dddd, dd MMMM yyyy"));
                    }

                }else{
                    eesCurrentDate = eesNewDate;
                    Console.WriteLine(eesCurrentDate.ToString("dddd, dd MMMM yyyy"));
                    Console.WriteLine();
                }
                
                Console.WriteLine($"{eesI}. {eesEvent.EesDisplayInPlanner()}");
                eesI += 1;
            }


        }else{

            int eesI = 1;
            List<Task> eesFull = eesPlanner.EesGetTasks();
            Console.WriteLine(" --2023 Tasks--");
            DateTime eesCurrentDate = DateTime.Now;
            string eesDay = eesCurrentDate.ToString("dddd dd MM yyyy");
            List<string> eesDayList = eesDay.Split(new char [] {',', ' '}).ToList();
            int eesDayIndex = 1;
            int eesMonthIndex = 2;

            int eesDayDate = int.Parse(eesDayList[eesDayIndex]);
            int eesDayMonth = int.Parse(eesDayList[eesMonthIndex]);
            // prints the current date to start the callendar
            Console.WriteLine(eesCurrentDate.ToString("dddd dd MMMM yyyy"));

            foreach (Task eesEvent in eesFull){
                
                DateTime eesNewDate = eesEvent.EesGetFirstTime();
                List<string> eesNewDateList = eesNewDate.ToString("dddd, dd MM yyyy").Split(new char[] {',', ' '}).ToList();

                int eesNewDateDay = int.Parse(eesNewDateList[eesDayIndex]);
                int eesNewMonth = int.Parse(eesNewDateList[eesMonthIndex]);

                // if the date has not been printed, print it
                if (eesNewMonth == eesDayMonth){
                    if (eesDayDate < eesNewDateDay){
                        Console.WriteLine();
                        eesCurrentDate = eesNewDate;
                        Console.WriteLine(eesCurrentDate.ToString("dddd, dd MMMM yyyy"));
                    }

                }else{
                    eesCurrentDate = eesNewDate;
                    Console.WriteLine(eesCurrentDate.ToString("dddd, dd MMMM yyyy"));
                    Console.WriteLine();
                }
                
                Console.WriteLine($"{eesI}. {eesEvent.EesDisplayInPlanner()}");
                eesI += 1;
            }


        }

    }

    static void EesUpdateEvent(Planner eesPlanner, int eesViewChoice){
        int eesChoiceLimit;
            Console.WriteLine("Which event would you like to check off? ");
            int eesMarkChoice;

            if (eesViewChoice == 1){
                List<Event> eesChosenList = eesPlanner.EesGetFullList();
                eesChoiceLimit = eesChosenList.Count();
                
                eesMarkChoice = EesGetOptionChoice(eesChoiceLimit);

                Event eesChosen = eesChosenList[eesMarkChoice -1];
                eesChosen.EesRecordEvent();

            }else if (eesViewChoice == 2){
                List<Appointment> eesChosenList = eesPlanner.EesGetAppointments();
                eesChoiceLimit = eesChosenList.Count();
              
                eesMarkChoice = EesGetOptionChoice(eesChoiceLimit);

                Appointment eesChosen = eesChosenList[eesMarkChoice -1];
                eesChosen.EesRecordEvent();
            }else{
                List<Task> eesChosenList = eesPlanner.EesGetTasks();
                eesChoiceLimit = eesChosenList.Count();
                
                eesMarkChoice = EesGetOptionChoice(eesChoiceLimit);

                Task eesChosen = eesChosenList[eesMarkChoice -1];
                eesChosen.EesRecordEvent();
            }

            Console.WriteLine("Congratulations on checking something off the list! ");

            
            


            
    }
    


    static void Main(string[] args)
    {
        Planner eesPlanner = new Planner();
        SaveAndLoad eesSaveAndLoad = new SaveAndLoad("saved.txt");
        int eesUserChoice = 0;
        do{
        eesUserChoice = EesMenu();
        if (eesUserChoice == 1){
            //1. Load the Planner
            eesSaveAndLoad.EesLoadPlanner(eesPlanner);
            Thread.Sleep(1000);
            Console.WriteLine("Your events have been loaded from the file. ");
            Console.WriteLine();
            Thread.Sleep(1000);

        }else if (eesUserChoice == 2){
            //2. Save the Planner
            eesSaveAndLoad.EesSaveToFile(eesPlanner);
            Thread.Sleep(1000);
            Console.WriteLine("Your planner has been saved. ");
            Console.WriteLine();
            Thread.Sleep(1000);

        }else if (eesUserChoice == 3){
            //3. Add a new event
            EesCreateEvent(eesPlanner);
            Console.WriteLine("Your event has been created. ");
            Thread.Sleep(1000);


        }else if (eesUserChoice == 4){
            //4. View Planner
            Console.WriteLine("Please select a choice for what you would like to view: ");
            Console.WriteLine("1. View entire planner ");
            Console.WriteLine("2. View all Appointments ");
            Console.WriteLine("3. View all Tasks ");
            Console.WriteLine("Which option would you like to choose? ");
            int eesViewChoice = EesGetOptionChoice(3);
            eesDisplayEvents(eesPlanner, eesViewChoice);
            Console.WriteLine();
            Thread.Sleep(3000);

        }else if (eesUserChoice == 5){
            //5. Update an event
            Console.WriteLine("First, select the event you would like to mark completed. ");

            Console.WriteLine("Please select a choice for what you would like to view: ");
            Console.WriteLine("1. View entire planner ");
            Console.WriteLine("2. View all Appointments ");
            Console.WriteLine("3. View all Tasks ");
            Console.WriteLine("Which option would you like to choose? ");
            int eesViewChoice = EesGetOptionChoice(3);

            eesDisplayEvents(eesPlanner, eesViewChoice);
            Thread.Sleep(3000);

            EesUpdateEvent(eesPlanner, eesViewChoice);

            Console.WriteLine();
            Thread.Sleep(1000);


        }else{
            Console.WriteLine("Thank you for using this planner. Come back soon! ");
        }

        }while (eesUserChoice != 6);

    }
}




//resourses:
//https://stackoverflow.com/questions/5011467/convert-string-to-liststring-in-one-line
// - used to convert type string[] to type List<string>