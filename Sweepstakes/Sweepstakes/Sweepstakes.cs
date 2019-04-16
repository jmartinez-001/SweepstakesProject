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


        
        }

        public void RegisterContestant(Contestant contestant)
        {
            Contestants.Add(RegistrationNumber, contestant);

        }
        
        string PickWinner()
        {

        }
        
        void PrintContestantInfo(Contestant contestant)
        {

        }
    }
}
