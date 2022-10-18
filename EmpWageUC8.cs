using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empwage
{
    internal class empwagecomputing
    {
        public const int is_part_times = 1;
        public const int is_full_times = 2;
        public static int computeEmpWage(string company, int emprateperhour, int numofworkingdays, int maxhoursinmonth)
        {

            int emphrs = 0;
            int totalemphrs = 0;
            int totalworkingdays = 0;

            while (totalemphrs <= maxhoursinmonth && totalworkingdays < numofworkingdays)
            {
                totalworkingdays++;
                Random random = new Random();
                int empcheck = random.Next(0, 3);

                switch (empcheck)
                {
                    case is_part_times:
                        emphrs = 4;
                        break;
                    case is_full_times:
                        emphrs = 8;
                        break;
                    default:
                        emphrs = 0;
                        break;
                }
                totalemphrs += emphrs;
                Console.WriteLine("day#:" + totalworkingdays + " emp hrs : " + emphrs);
            }
            int totalempwage = totalemphrs * emprateperhour;
            Console.WriteLine("total emp wagefor company : " + company + " is:" + totalempwage);
            return totalempwage;
        }
    }
}
