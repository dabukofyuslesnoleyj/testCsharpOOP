using System;
using System.Collections.Generic;

namespace testCsharpOOP
{
    class Patient : User
    {
        public string patientRemarks {get; set;}
        
        public override void login(string uName, string pWord)
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