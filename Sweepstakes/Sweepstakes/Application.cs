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
            SetupManagementType();
            CreateSweepstakes();
            DecisionTree();
            

            
        }
        public void SetupManagementType()
        {
            
            ISweepStakesManager manager = ManagerFactory.ChooseManager();
            myMarketingFirm = new MarketingFirm(manager);
        }
        public void CreateSweepstakes()
        {
            string name = UserInterface.GetSweepstakesName();
            Sweepstakes sweepstakes = new Sweepstakes(name);
            myMarketingFirm.InsertSweepstakes(sweepstakes);
            CreatePlusAddContestants(sweepstakes);

        }
        public void CreatePlusAddContestants(Sweepstakes sweepstakes)
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
            Sweepstakes Drawing = null;
            Drawing = myMarketingFirm.getSweepstakes();
            Console.WriteLine(Drawing.PickWinner());

        }
        public void DecisionTree()
        {
            string decision;
            decision = UserInterface.GetString("'Create' another Sweepstakes,'Draw' a winner from list of Sweepstakes or 'Quit'?");
            switch (decision)
            {
                case "Create":
                    CreateSweepstakes();
                    DecisionTree();
                    break;
                case "Draw":
                    DrawSweepstakes();
                    DecisionTree();
                    break;
                case "Quit":
                    break;
                default:
                    DecisionTree();
                    break;
            }
        }

    }
}
