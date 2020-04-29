using System;
using System.Collections.Generic;

namespace testCsharpOOP
{
    class Patient : User
    {
        public string patientRemarks;
        
        public override void login(string uName, string pWord)
        {
            // TODO : Patient login 
        }

        public override void initializeAppointmentController()
        {
            appointmentController = new PatientAppointmentController();
        }
    }
}