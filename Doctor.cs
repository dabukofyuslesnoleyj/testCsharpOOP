using System;
using System.Collections.Generic;

namespace testCsharpOOP
{
    class Doctor : User
    {
        public string doctorProfile {get; set;}
        public List <TimeSpan> timeslots;

        public Doctor (string userName, string passWord) : base (userName, passWord)
        {
        }

        public override void login(string userName, string passWord)
        {
            // TODO : Doctor login 
        }

        public override void initializeAppointmentController()
        {
            appointmentController = new DoctorAppointmentController();
        }

        public void cancelAppointment ()
        {

        }
    }
}