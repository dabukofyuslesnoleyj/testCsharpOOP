using System;

namespace testCsharpOOP
{
    class Secretary : User
    {
        
        public override void login(string uName, string pWord)
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