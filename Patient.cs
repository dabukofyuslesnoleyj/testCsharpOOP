using System;
using System.Collections.Generic;

namespace testCsharpOOP
{
    class Patient : User
    {
        public string patientRemarks {get; set;}

        public Patient (string userName, string passWord) : base (userName, passWord)
        {
        }

        public override void login(string userName, string passWord)
        {
            // TODO : Patient login 
        }

        public override void initializeAppointmentController()
        {
            appointmentController = new PatientAppointmentController();
        }

        public void createAppointment()
        {

        }

        public void cancelAppointment()
        {
            
        }
    }
}