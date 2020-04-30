using System;

namespace testCsharpOOP
{
    class Secretary : User
    {
        public Secretary (string userName, string passWord) : base (userName, passWord)
        {
        }
        public override void login(string userName, string passWord)
        {
            // TODO : Secretary login 
        }

        public override void initializeAppointmentController()
        {
            appointmentController = new SecretaryAppointmentController();
        }

        public void editAppointment ()
        {
            
        }
    }
}