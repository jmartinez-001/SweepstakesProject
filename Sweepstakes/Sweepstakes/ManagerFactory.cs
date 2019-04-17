using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class ManagerFactory
    {
        public static ISweepStakesManager ChooseManager()
        {
            ISweepStakesManager managerType = null;
            string manager = UserInterface.GetManagementType();
            switch (manager)
            {
                case "Stack":
                    managerType = new SweepStakesStackManager();
                    break;
                case "Queue":
                    managerType = new SweepStakesQueueManager();
                    break;
                default:
                    Console.WriteLine("Not a valid sweepstakes management type");
                    ChooseManager();
                    break;
            }
            return managerType;
        }
    }
}
