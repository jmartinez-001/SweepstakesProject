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
            
            
            Contestants.Add(RegistrationNumber(), contestant);
            

        }

        private int RegistrationNumber()
        {

            int RegistrationNumber = Contestants.Count + 1;
            return RegistrationNumber;

        }

        public string PickWinner()
        {
            int winningNumber = GetRandom();

            Contestant contestWinner = CastAsContestant(Contestants[winningNumber], winningNumber);

            string winner = ($"{contestWinner.FirstName}{contestWinner.LastName}");
            

            return winner;

        }

        private Contestant CastAsContestant(IUser contestant, int i)       
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
    }
}
