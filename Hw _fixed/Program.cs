using System;

enum Menu{ RegisterNewStudent = 1, RegisterNewTeacher, GetListPersons , LogIn }
namespace Hw__fixed
{
    class Program
    {
        static PersonList personList;
        static void Main(string[] args) {
            Event events = new Event("", "");
            PreparePersonListWhenProgramIsLoading();
            PrepareEventList(events);
            PrepareJoinEventList();
            PrintMenuScreen();
        }
        static void PreparePersonListWhenProgramIsLoading() {
            Program.personList = new PersonList();
        }
        static void PrintMenuScreen() {
            Console.Clear();
            PrintHeader();
            PrintListMenu();
            InputMenuFromKeyboard();
        }
        static void PrintHeader() {
            Console.WriteLine("Welcome to registration new user school application.");
            Console.WriteLine("-----------------------------------------------------");
        }
        static void PrintListMenu() {
            Console.WriteLine("1. Register new student.");
            Console.WriteLine("2. Register new teacher.");
            Console.WriteLine("3. Get List Persons ");
            Console.WriteLine("4. Log in");
        }
        static void InputMenuFromKeyboard() {
            Console.WriteLine("Please Select Menu");
            Menu menu = (Menu)(int.Parse(Console.ReadLine()));

            PresentMenu(menu);
        }
        static void PresentMenu(Menu menu) {
            if (menu == Menu.RegisterNewStudent)
            { ShowInputRegisterNewStudentScreen(); }
            else if (menu == Menu.RegisterNewTeacher)
            { ShowInputRegisterNewTeacherScreen(); }
            else if (menu == Menu.GetListPersons)
            { ShowGetListPersonScreen(); }
            else if (menu == Menu.LogIn)
            { ShowLogInScreen(); }
            else
            { ShowMessageInputMenuIsIncorrect(); }
        }
        static void ShowInputRegisterNewStudentScreen() {
            Console.Clear();
            PrintHeaderRegisterStudent();

            int totalStudent = TotalNewStudent();
            InputNewStudentFromKeyboard(totalStudent);
        }
        static void ShowInputRegisterNewTeacherScreen() {
            Console.Clear();
            PrintHeaderRegisterTeacher();

            int totalTeacher = TotalNewTeacher();
            InputNewTeacherFromKeyboard(totalTeacher);
        }
        static void ShowGetListPersonScreen() {
            Console.Clear();
            Program.personList.FetchcPersonList();

            InputExitFromKeyBoard();
        }
        static void InputExitFromKeyBoard() {
            string text = "";
            while (text != "exit")
            {
                Console.WriteLine("Input: ");
                text = Console.ReadLine();
            }

            PrintMenuScreen();
        }
        static void PrintHeaderRegisterStudent() {
            Console.WriteLine("Register new student.");
            Console.WriteLine("----------------------");
        }
        static void PrintHeaderRegisterTeacher() {
            Console.WriteLine("Register new teacher.");
            Console.WriteLine("----------------------");
        }
        static int TotalNewStudent() {
            Console.WriteLine("Input Total new student: ");

            return int.Parse(Console.ReadLine());
        }
        static int TotalNewTeacher() {
            Console.WriteLine("Input Total new Teacher: ");

            return int.Parse(Console.ReadLine());
        }
        static void InputNewStudentFromKeyboard(int totalStudent) {
            for (int i = 0; i < totalStudent; i++)
            {
                Console.Clear();
                PrintHeaderRegisterStudent();

                Student student = CreateNewStudent();
                Program.personList.AddNewPerson(student);
            }
            Console.Clear();
            PrintMenuScreen();
        }
        static void InputNewTeacherFromKeyboard(int totalStudent) {
            for (int i = 0; i < totalStudent; i++)
            {
                Console.Clear();
                PrintHeaderRegisterTeacher();

                Teacher teacher = CreateNewTeacher();
                Program.personList.AddNewPerson(teacher);
            }
            Console.Clear();
            PrintMenuScreen();
        }
        static Student CreateNewStudent() {
            string ID;
            return new Student(InputName(),
                InputAddress(),
                InputCitizenId(),
                ID = InputStudentId(),
                ID);
        }
        static Teacher CreateNewTeacher() {
            string ID;
            return new Teacher(InputName(),
                InputAddress(),
                InputCitizenId(),
                ID = InputEmployeeId(),
                ID);
        }
        static void ShowMessageInputMenuIsIncorrect() {
            Console.Clear();
            Console.WriteLine("Menu Incorrect Please try again.");
            InputMenuFromKeyboard();
        }
        static string InputName() {
            Console.Write("Name: ");

            return Console.ReadLine();
        }
        static string InputAddress() {
            Console.Write("Address: ");

            return Console.ReadLine();
        }
        static string InputCitizenId() {
            Console.Write("Citizen ID: ");

            return Console.ReadLine();
        }
        static string InputStudentId() {
            Console.Write("Student ID: ");

            return Console.ReadLine();
        }
        static string InputEmployeeId() {
            Console.Write("Employee ID: ");

            return Console.ReadLine();
        }
        static void ShowLogInScreen() {
            Console.Clear();

            ShowLogInHeader();
            YouRegisterYet();
        }
        static void ShowLogInHeader() {
            Console.WriteLine("Log In.");
            Console.WriteLine("---------------");
        }
        static string InputYourIDToLogIn() {
            Console.Write("ID: ");

            return Console.ReadLine();
        }
        static string InputYouPasswordIsYourcitizenID() {
            Console.WriteLine("** Your password is your citizen ID. **");
            Console.Write("Password: ");

            return Console.ReadLine();
        }
        static void YouRegisterYet() {
            string IDLogIn = InputYourIDToLogIn();
            string PasswordLogIn = InputYouPasswordIsYourcitizenID();
            bool CheackID = personList.CheckValidUserID(IDLogIn);
            bool CheckPassword = personList.CheckValidPasswordID(PasswordLogIn);
            if (CheackID == true)
            {
                if (CheckPassword == true) 
                { ProfileUser(personList.FindByID(IDLogIn)); }
                else
                {
                    ShowMessageYourpasswordIsIncorrect();
                    ShowLogInScreen();
                }
            }
            else
            {
                ShowYourIDIsNotFound();
                PrintMenuScreen();
            }
        }
        static void ShowMessageYourpasswordIsIncorrect() {
            Console.WriteLine("Your password is incorrect.");
            Console.WriteLine("Please Try Again.");
            Console.ReadLine();
        }
        static void ShowYourIDIsNotFound() {
            Console.WriteLine("Your ID is not found.");
            Console.WriteLine("Please Register Before.");
            Console.ReadLine();
        }
        static void ProfileUser(Person person) {
            Console.Clear();

            ProfileHeader();
            ShowInfomation(person);
            ShowEventScreen(person);
        }
        static void ProfileHeader() {
            Console.WriteLine("User Profile.");
            Console.WriteLine("-------------");
        }
        static void ShowInfomation(Person person) {
            Console.WriteLine("Name: {0}", person.Getname());
            if (person is Student)
            {
                Console.WriteLine("Job: Student");
                Console.WriteLine("Student ID: {0}", person.GetID());
            }
            else if (person is Teacher)
            {
                Console.WriteLine("Job: Teacher");
                Console.WriteLine("Teacher ID: {0}", person.GetID());
            }
            Console.WriteLine("-----------------------------------");
        }
        static void ShowEventScreen(Person person) {
            JoinEventHeader();
            ShowEventThatUserJoin();
            GoToRegisterEventScreen(person);
        }
        static void JoinEventHeader() {
            Console.WriteLine("Join Event");
            Console.WriteLine("--------------");
        }
        static void GoToRegisterEventScreen(Person person) {
            Console.WriteLine("Press 1 to Register Event");
            Console.WriteLine("Press any keys to go back to menu screen");
            if (InputFromKeyboardToRegisterEvent() == 1)
            {
                Console.Clear();
                ShowRegisterEventScreen();
                PeopleRegisterTheEvent(person);
            }
            else
            { PrintMenuScreen(); }
        }
        static int InputFromKeyboardToRegisterEvent()
        { return int.Parse(Console.ReadLine()); }
        static void ShowEventThatUserJoin()
        {
            joinEventList.FetchcJoinEventList();
        }
        static void ShowRegisterEventScreen() {
            ShowEventThatPeopleCanRegister();
        }
        static void ShowEventThatPeopleCanRegister() {
            Program.eventList.FetchcEventList();
        }
        static int PreesKeyNumberOfEventThatYouWantToJoin() {
            Console.Write("Please Input Number of Event that you want to join: ");
            return int.Parse(Console.ReadLine());
        }
        static void PeopleRegisterTheEvent(Person person) {
            bool ValidNumberOfEvent = false;
            do
            {
                Event events = new Event("", "");
                int keyOfEvents = PreesKeyNumberOfEventThatYouWantToJoin();
                events = Program.eventList.returnEventOut(keyOfEvents);
                if (keyOfEvents == Program.eventList.IndexEventPlus1(events))
                {
                    RegisterEvent(events);
                    DeleateEvetThatRegister(events);
                    ValidNumberOfEvent = true;
                }
                else
                {
                    Console.Clear();

                    Console.WriteLine("Not found Event");
                    Console.WriteLine("Please try again.");
                }
            } while (ValidNumberOfEvent == false);
            ProfileUser(person);
        }
        static EventList eventList;
        static void PrepareEventList(Event events) {
            Program.eventList = new EventList();
            Program.eventList.AddNewEvent(events.OrientationEvent());
            Program.eventList.AddNewEvent(events.SportEvent());
            Program.eventList.AddNewEvent(events.GeneralElectionEvent());
        }
        static JoinEventList joinEventList;
        static void PrepareJoinEventList() {
            Program.joinEventList = new JoinEventList();
        }
        static void RegisterEvent(Event events) {
            Program.joinEventList.AddNewJoinEvent(events);
        }
        static void DeleateEvetThatRegister(Event events) {
            Program.eventList.RemoveEvent(events);
        }
        //static void InputEventInList(string EventName, string EventDate) {
        //    Event events = new Event(EventName, EventDate);
        //    Program.eventList.AddNewEvent(events);
        //}
        //static string InputEventName() {
        //    return Console.ReadLine();
        //}
        //static string OnputEventDate() {
        //    return Console.ReadLine();
        //}
    }
}
