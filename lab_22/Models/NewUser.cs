using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab_22.Models
{


    // creating new object to be passed into the view 
    //create from models folder beause its a model for data
    public class NewUser
    {
        private string name;
        private string lastName;
        private string email;
        private string phoneNumber;
        private string password;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public NewUser()
        {
                
        }

        public NewUser(string _name, string _lastName, string _email,string _phoneNumber, string _password)
        {
            Name = _name;
            LastName = _lastName;
            Email = _email;
            PhoneNumber = _phoneNumber;
            Password = _password;
        }


    }
}