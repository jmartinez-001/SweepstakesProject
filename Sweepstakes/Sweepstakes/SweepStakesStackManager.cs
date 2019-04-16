using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes 
{
    class SweepStakesStackManager : ISweepStakesManager
    {
        Stack<Sweepstakes> stackSweepstakes = new Stack<Sweepstakes>();

        public SweepStakesStackManager()
        {

        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            stackSweepstakes.Push(sweepstakes);
        }

        public Sweepstakes getSweepstakes()
        {
            return stackSweepstakes.Pop();
        }
        

    }
}
