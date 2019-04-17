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
            AddContestants(sweepstakes);

        }
        public void AddContestants(Sweepstakes sweepstakes)
        {
            int contestants = UserInterface.GetNumberOfEntries();
            for (var i = 0; i < contestants; i++)
            {
                Contestant contestant;
                string firstName = UserInterface.GetContestantInfo("First Name");
                string lastName = UserInterface.GetContestantInfo("Last Name");
                string emailAddress = UserInterface.GetContestantInfo("Email Address");
                contestant = new Contestant(firstName, lastName, emailAddress);
                sweepstakes.RegisterContestant(contestant);
            }
        }
        public void DrawSweepstakes()
        {

        }
        
    }
}
