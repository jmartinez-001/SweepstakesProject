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

            SweepStakesQueueManager Queue = new SweepStakesQueueManager();
            SweepStakesStackManager Stack = new SweepStakesStackManager();

            MarketingFirm OrangeFirm = new MarketingFirm(Stack);
            MarketingFirm BlueFirm = new MarketingFirm(Queue);
            
            Sweepstakes WinIpad = new Sweepstakes("WinIpad");
            Sweepstakes WinTV = new Sweepstakes("WinTV");

            OrangeFirm.InsertSweepstakes(WinIpad);
            OrangeFirm.InsertSweepstakes(WinTV);

            BlueFirm.InsertSweepstakes(WinIpad);
            BlueFirm.InsertSweepstakes(WinTV);

            WinIpad.RegisterContestant(JonJones);
            WinTV.RegisterContestant(JonJones);
            WinIpad.RegisterContestant(JimJones);
            WinIpad.RegisterContestant(MaryJones);
            WinTV.RegisterContestant(MaryJones);
            Sweepstakes Drawing;
            Drawing = OrangeFirm.getSweepstakes();
            Console.WriteLine(Drawing.PickWinner());
            Drawing = BlueFirm.getSweepstakes();
            Console.WriteLine(Drawing.PickWinner());
            Console.ReadLine();
            //Console.WriteLine(WinTV.PickWinner());

        }
    }
}
