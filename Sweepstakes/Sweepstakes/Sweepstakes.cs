using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes 
    {
        string name;
        private Dictionary<int, IUser> Contestants = new Dictionary<int, IUser>();
        private List<ISubscriber> subscribers = new List<ISubscriber>();


        public Sweepstakes(string name)
        {
            this.name = name;
        
        }
        
        public IUser this[int index]
        {
            get
            {
                return Contestants[index];
            }
            set
            {
                Contestants[index] = value;
            }
        }

        public void RegisterContestant(Contestant contestant)
        {
            int registrationNumber = RegistrationNumber();
            contestant.RegistrationNumber = registrationNumber;
            Contestants.Add(registrationNumber, contestant);          
           
        }

        private int RegistrationNumber()
        {
            int RegistrationNumber = Contestants.Count + 1;
            return RegistrationNumber;

        }

        public string PickWinner()
        {
            int winningNumber = GetRandom();
            Contestant contestWinner = CastIUserAsContestant(Contestants[winningNumber], winningNumber);
            string winner = $"{contestWinner.FirstName}{contestWinner.LastName}";
            NotifySubscribers(winner);
            return winner;

        }

        private Contestant CastIUserAsContestant(IUser contestant, int i)       
        {
            Contestant castedContestant = null;
            Type userRole = Contestants[i].GetType();
            castedContestant = (Contestant)Contestants[i];
            return castedContestant;

        }


        private int GetRandom()
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, Contestants.Count + 1);
            return randomNumber;            

        }        

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"First Name:{contestant.FirstName}");
            Console.WriteLine($"Last Name:{contestant.LastName}");
            Console.WriteLine($"Email Address:{contestant.EmailAddress}");
        }

        public void Subscribe(ISubscriber subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            subscribers.Remove(subscriber);
        }

        private void NotifySubscribers(string name)
        {
            foreach (ISubscriber subscriber in subscribers)
            {
                subscriber.Notify(subscriber, name);
            }
        }

    }
}
