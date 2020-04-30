using System;

namespace testCsharpOOP
{
    class Admin : User
    {    
        public Admin (string userName, string passWord) : base (userName, passWord)
        {
        }
        public override void login(string userName, string passWord)
        {
            // TODO : Admin login 
        }

        public override void initializeAppointmentController()
        {
            appointmentController = new AdminAppointmentController();
        }
    }
}