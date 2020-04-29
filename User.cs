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

        public abstract void login(string uName, string pWord);

        public abstract void initializeAppointmentController();

        public AppointmentController GetAppointmentController()
        {
            return appointmentController;
        }
    }
}