using System;
using System.Collections.Generic;

namespace testCsharpOOP
{
    static class UserFactory
    {

        public static User GenerateUser(string userName, string passWord, string type)
        {
            switch (type)
            {
                case "Patient" : return new Patient(userName, passWord);
                case "Doctor" : return new Doctor(userName, passWord);
                case "Secretary" : return new Secretary(userName, passWord);
                case "Admin" : return new Admin(userName, passWord);
                default : return null;
            }
        }

    }
}