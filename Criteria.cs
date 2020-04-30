using System;
using System.Collections.Generic;

namespace testCsharpOOP
{
     interface ICriteria
    {   
        void checkCriteria();

        List<User> getUserList();
    }

    class AgeCriteria : ICriteria
    {
        List<User> userList;
        public void checkCriteria()
        {

        }

        public List<User> getUserList()
        {
            return userList;
        }
    }
    class GenderCriteria : ICriteria
    {
        List<User> userList;
        public void checkCriteria()
        {

        }

        public List<User> getUserList()
        {
            return userList;
        }
    }
}