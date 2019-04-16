using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            Contestant JonJones = new Contestant("Jon", "Jones", "jon1@gmail.com");
            Contestant JimJones = new Contestant("Jim", "Jones", "jim1@gmail.com");
            Contestant MaryJones = new Contestant("Mary", "Jones", "mary1@gmail.com");
            MarketingFirm Orange = new MarketingFirm();
            Sweepstakes WinIpad = new Sweepstakes("WinIpad");
            Sweepstakes WinTV = new Sweepstakes("WinTV");
            WinIpad.RegisterContestant(JonJones);
            WinTV.RegisterContestant(JonJones);
            WinIpad.RegisterContestant(JimJones);
            WinIpad.RegisterContestant(MaryJones);
            WinTV.RegisterContestant(MaryJones);
            Console.WriteLine(WinIpad.PickWinner());
            Console.WriteLine(WinTV.PickWinner());

        }
    }
}
