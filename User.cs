using System;
namespace testCsharpOOP
{
    abstract class User
    {
        public string id {get; set;}
        public string name {get; set;}
        public string userName {get; set;}
        public string password {get; set;}

        public abstract void login(string uName, string pWord);
    }
}