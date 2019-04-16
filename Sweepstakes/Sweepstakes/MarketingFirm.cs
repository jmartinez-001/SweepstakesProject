using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        //List<ISweepStakesManager> Managers;
        ISweepStakesManager SweepstakesManager;


        public MarketingFirm(ISweepStakesManager sweepStakesManager)
        {
            //Managers = new List<ISweepStakesManager>();
            this.SweepstakesManager = sweepStakesManager;
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            SweepstakesManager.InsertSweepstakes(sweepstakes);
        }

        public Sweepstakes getSweepstakes()
        {

            return SweepstakesManager.getSweepstakes();
        }
    }
}
