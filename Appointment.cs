using System;
namespace testCsharpOOP
{
    class Appointment
    {
        public string id {get; set;}
        public DateTime dateReserved;
        public DateTime startTime;
        public DateTime endTime;
        public Doctor doctor {get; set;}
        public Patient patient {get; set;}
        
    }
}