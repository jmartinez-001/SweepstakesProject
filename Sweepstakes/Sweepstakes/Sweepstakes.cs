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
            IUser contestWinner = Contestants[winningNumber];
            return ($"{contestWinner.FirstName}{contestWinner.LastName} is the lucky winner of the {this.name} sweepstakes!");

        }

        private int GetRandom()
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, Contestants.Count + 1);
            return randomNumber;
            

        }

        

        void PrintContestantInfo(Contestant contestant)
        {

        }
    }
}
