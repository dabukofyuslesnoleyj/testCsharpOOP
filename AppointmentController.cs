using System;
using System.Collections.Generic;

namespace testCsharpOOP
{
    abstract class AppointmentController
    {
        public Dictionary<string, Appointment> appointments;

        public abstract void AddAppointment(Appointment a);

        public abstract void DeleteAppointment(string appointmentID);    
        
    }

    class DoctorAppointmentController : AppointmentController
    {
        public override void AddAppointment(Appointment a)
        {
            
        }

        public override void DeleteAppointment(string appointmentID)
        {

        }
    }

    class PatientAppointmentController : AppointmentController
    {
        public override void AddAppointment(Appointment a)
        {

        }

        public override void DeleteAppointment(string appointmentID)
        {

        }
    }

    class SecretaryAppointmentController : AppointmentController
    {
        public override void AddAppointment(Appointment a)
        {

        }

        public override void DeleteAppointment(string appointmentID)
        {

        }
    }
}