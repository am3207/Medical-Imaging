using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sagittal_from_byMThread_1108022.Sagittal_Bmp.Distribute_over_Threads
{
    public class Devide_in_Groups11
    {

        /// <summary>
        /// Distribute members in Fixed Size  Groups
        /// </summary>
        /// <param name="teamSize"></param>
        /// <param name="toalMembers"></param>
        /// <returns></returns>
        public int Find_numOf_Groups(int teamSize, int toalMembers)
        {
            int input = toalMembers;

            //? Calculation Main
            int remind = input % teamSize;
            int round_11 = input / teamSize;
            if (remind < teamSize)
                round_11++;

            return round_11;
        }

    }
}
