using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Application
    {
        public MarketingFirm myMarketingFirm;

        public Application()
        {
           
        }

        public void Run()
        {
            SetupManagemenType();
            CreateSweepstakes();            
            DrawSweepstakes();

            
        }
        public void SetupManagemenType()
        {
            string managerType = UserInterface.GetManagementType();
            ISweepStakesManager manager = ManagerFactory.ChooseManager(managerType);
            myMarketingFirm = new MarketingFirm(manager);
        }
        public void CreateSweepstakes()
        {
            string name = UserInterface.GetSweepstakesName();
            Sweepstakes sweepstakes = new Sweepstakes(name);
            myMarketingFirm.InsertSweepstakes(sweepstakes);
            AddContestants();

        }
        public void AddContestants()
        {

        }
        public void DrawSweepstakes()
        {

        }
        
    }
}
