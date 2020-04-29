using System;
using System.Collections.Generic;

namespace testCsharpOOP
{
    class Doctor : User
    {
        public string doctorProfile;

        public override void login(string uName, string pWord)
        {
            // TODO : Doctor login 
        }

        public override void initializeAppointmentController()
        {
            appointmentController = new DoctorAppointmentController();
        }
    }
}