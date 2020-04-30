using System;
namespace testCsharpOOP
{
    abstract class User
    {
        public string id {get; set;}
        public string name {get; set;}
        public string userName {get; set;}
        public string password {get; set;}
        protected AppointmentController appointmentController;

        public User (string userName, string passWord)
        {
            this.userName = userName;
            this.password = passWord;
        }

        public abstract void login(string userName, string passWord);

        public abstract void initializeAppointmentController();

        public AppointmentController GetAppointmentController()
        {
            return appointmentController;
        }
    }
}