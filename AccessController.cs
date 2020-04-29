using System;
using System.Collections.Generic;

namespace testCsharpOOP
{
    class AccessController
    {
        public UserController userController;
        private User currentUser;
        
        public AppointmentController GetAppointmentController()
        {
            return currentUser.GetAppointmentController();
        }

        public void changeCurrentUser(User newUser)
        {
            currentUser = newUser;
        }
    }
}