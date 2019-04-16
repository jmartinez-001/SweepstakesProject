using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        ISweepStakesManager SweepstakesManager;


        public MarketingFirm(ISweepStakesManager sweepStakesManager)
        {
            this.SweepstakesManager = sweepStakesManager;
        }
    }
}
