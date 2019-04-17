using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public interface ISubscriber
    {
        //Attempted to implement observer design pattern through an ISubscriber interface to keep the peripheral ability of the Notify method inherent to ISubscriber. 
        //Complications arose when notifying contestants of a their status in drawing. ISubcriber did not have the firstname, lastname etc.. properties of IUser. 
        //I made the design decision to have ISubscriber and IUser both have properties that referance the firstname, lastname etc.. variables of the Contestant class.
        //Rather than have IUser have a Notify subscriber ability. This allows one to change the implementation independantly of the interface.

        string FirstName { get; set; }
        string LastName { get; set; }
        string EmailAddress { get; set; }
        int RegistrationNumber { get; set; }

        void Notify(ISubscriber subscriber, string name);


    }
}
