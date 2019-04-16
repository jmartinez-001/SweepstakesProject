using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepStakesQueueManager : ISweepStakesManager
    {
        Queue<Sweepstakes> queueSweepStakes = new Queue<Sweepstakes>();

        public SweepStakesQueueManager()
        {

        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            queueSweepStakes.Enqueue(sweepstakes);
        }

        public Sweepstakes getSweepstakes()
        {
            
            return queueSweepStakes.Dequeue();
        }        


    }
}
