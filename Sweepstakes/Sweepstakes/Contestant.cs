using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant : IUser
    {
        private string firstName;
        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }
        private string lastName;
        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }
        private string emailAddress;
        public string EmailAddress
        {
            get
            {
                return emailAddress;
            }

            set
            {
                emailAddress = value;
            }
        }
        private int registrationNumber;
        public int RegistrationNumber
        {
            get
            {
                return registrationNumber;
            }

            set
            {
                registrationNumber = value;
            }
        }

        public Contestant(string FirstName, string LastName, string EmailAddress)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
            this.emailAddress = EmailAddress;
            int RegistrationNumber;
        }

        public void Notify(IUser user)
        {

        }
    }
}
