using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class UserInterface
    {
        public static string GetString(string input)
        {
            Console.WriteLine(input);
            var result = Console.ReadLine();
            return result;
        }

        public static string GetManagementType()
        {
            string managerType;
            managerType = UserInterface.GetString("How would you like to manage the Sweepstakes'? Choose 'Queue', first in first out; or 'Stack', last in first out.");
            return managerType;
        }

        public static string GetSweepstakesName()
        {
            string name;
            name = UserInterface.GetString("Enter name of sweepstakes to create. (Format: Win(enter giveaway)).");
            return name;
        }

    }
}
