using System;
using System.Collections.Generic;

namespace testCsharpOOP
{
    abstract class UserController
    {
        public Dictionary<string, User> users;

        public abstract void AddUser(User u);

        public abstract void DeleteUser(string userID);   

        public User GetUser(string userID)
        {
            return users[userID];
        }

    }
}