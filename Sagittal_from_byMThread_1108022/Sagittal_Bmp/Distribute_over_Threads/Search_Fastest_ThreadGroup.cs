using System.Collections.Generic;

namespace Sagittal_from_byMThread_1108022.Sagittal_Bmp.Distribute_over_Threads
{
    public class Search_Fastest_ThreadGroup
    {
        /// <summary>
        ///  From Intiger List find Smallest & Biggest Number  for Biggest number has Max Limit
        /// </summary>
        /// <param name="searchList"></param>
        /// <param name="bigestLimit">Bigeest Number must be equal or less this</param>
        /// <returns></returns>
        public (int, List<Group_varibale>) Fastest_ThreadGroup(List<List_of_Groups> searchList, int bigestLimit)
        {
            List<List_of_Groups> circle = searchList;
            List<Group_varibale> returnObj = null;

            int ListBigest = 0;

            #region Loop to find Lisit Smallest and Biggest numbers
            for (int pp = 0; pp < circle.Count; pp++)
            {
                if (ListBigest < circle[pp].threadCount && circle[pp].threadCount <= bigestLimit)
                {
                    ListBigest = circle[pp].threadCount;
                    returnObj = circle[pp].group_Varibale;
                }
            }
            #endregion

            return (ListBigest, returnObj);

        }

    }
}
