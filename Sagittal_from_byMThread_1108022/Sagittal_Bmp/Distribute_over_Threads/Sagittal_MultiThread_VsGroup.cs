using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sagittal_from_byMThread_1108022.Sagittal_Bmp.Distribute_over_Threads
{
    class Sagittal_MultiThread_VsGroup
    {
    }

    /// <summary>
    ///  From Total Active Threads Qty and  Image Total Qty, distribute Image Qty/Thread  so Image processing time  shortest
    /// </summary>
    public class Coronal_MultiThread_VsGroup
    {

        public List<Group_varibale> group11 = null;
        public List<Group_varibale> group22 = null;
        public List<Group_varibale> group33 = null;
        public List<Group_varibale> group44 = null;
        public List<Group_varibale> group55 = null;
        public List<Group_varibale> group66 = null;
        public List<Group_varibale> group77 = null;
        public List<Group_varibale> group88 = null;
        public List<Group_varibale> group99 = null;
        public List<Group_varibale> group110 = null;
        public List<Group_varibale> group121 = null;




        /// <summary>
        /// Will Show all Combination of Threads vs Coronal Image Group
        /// </summary>
        /// <param name="total_SagittalSlice"></param>
        /// <param name="thread_num">Total Threads number  , ex 12 Thread out of 18  </param>
        /// <returns></returns>
        public List<Group_varibale> AllCombination(int total_SagittalSlice, int thread_num)
        {
            #region Distributing Sagittal Slices Count in Multithread fator  11
            group11 = new List<Group_varibale>();
            if (total_SagittalSlice / thread_num <= 11)
            {
                #region Add Round number of 11 in different Threads 
                int groupSum_till_thisThread = 0;
                for (int c = 1; c <= thread_num; c++)
                {
                    groupSum_till_thisThread = 11 * c;

                    if (groupSum_till_thisThread <= total_SagittalSlice)
                    {
                        group11.Add(new Group_varibale() { ID = c, MembersCount = 11, Group_Count_devidedBy11 = 1 });
                    }

                }
                #endregion

                #region Add less Than < 11 in last Thread
                int totalCount_beforeThis_Thread = 0;
                for (int z = 0; z < group11.Count; z++)
                {
                    totalCount_beforeThis_Thread = totalCount_beforeThis_Thread + group11[z].MembersCount;
                }
                if (total_SagittalSlice - totalCount_beforeThis_Thread > 0)
                {
                    int memberCount = total_SagittalSlice - totalCount_beforeThis_Thread;

                    Devide_in_Groups11 _Groups = new Devide_in_Groups11();
                    int num0f_Group11_forRemind = _Groups.Find_numOf_Groups(11, memberCount);

                    group11.Add(new Group_varibale() { ID = group11.Count + 1, MembersCount = memberCount, Group_Count_devidedBy11 = num0f_Group11_forRemind });
                }

                #endregion
            }
            #endregion


            #region Distributing Coronal Slices Count in Multithread fator  22
            group22 = new List<Group_varibale>();
            if (total_SagittalSlice / thread_num <= 22)
            {
                #region Add Round number of 11 in different Threads 
                int groupSum_till_thisThread = 0;
                for (int c = 1; c <= thread_num; c++)
                {
                    groupSum_till_thisThread = 22 * c;

                    if (groupSum_till_thisThread <= total_SagittalSlice)
                    {
                        group22.Add(new Group_varibale() { ID = c, MembersCount = 22, Group_Count_devidedBy11 = 2 });
                    }

                }
                #endregion

                #region Add less Than < 22 in last Thread
                int totalCount_beforeThis_Thread = 0;
                for (int z = 0; z < group22.Count; z++)
                {
                    totalCount_beforeThis_Thread = totalCount_beforeThis_Thread + group22[z].MembersCount;
                }

                if (total_SagittalSlice - totalCount_beforeThis_Thread > 0)
                {
                    int memberCount = total_SagittalSlice - totalCount_beforeThis_Thread;

                    Devide_in_Groups11 _Groups = new Devide_in_Groups11();
                    int num0f_Group11_forRemind = _Groups.Find_numOf_Groups(11, memberCount);

                    group22.Add(new Group_varibale() { ID = group22.Count + 1, MembersCount = memberCount, Group_Count_devidedBy11 = num0f_Group11_forRemind });
                }
                #endregion
            }
            #endregion


            #region Distributing Coronal Slices Count in Multithread fator  33
            group33 = new List<Group_varibale>();
            if (total_SagittalSlice / thread_num <= 33)
            {
                #region Add Round number of 11 in different Threads 
                int groupSum_till_thisThread = 0;
                for (int c = 1; c <= thread_num; c++)
                {
                    groupSum_till_thisThread = 33 * c;

                    if (groupSum_till_thisThread <= total_SagittalSlice)
                    {
                        group33.Add(new Group_varibale() { ID = c, MembersCount = 33, Group_Count_devidedBy11 = 3 });
                    }

                }
                #endregion

                #region Add less Than < 33 in last Thread
                int totalCount_beforeThis_Thread = 0;
                for (int z = 0; z < group33.Count; z++)
                {
                    totalCount_beforeThis_Thread = totalCount_beforeThis_Thread + group33[z].MembersCount;
                }
                if (total_SagittalSlice - totalCount_beforeThis_Thread > 0)
                {
                    int memberCount = total_SagittalSlice - totalCount_beforeThis_Thread;

                    Devide_in_Groups11 _Groups = new Devide_in_Groups11();
                    int num0f_Group11_forRemind = _Groups.Find_numOf_Groups(11, memberCount);

                    group33.Add(new Group_varibale() { ID = group33.Count + 1, MembersCount = memberCount, Group_Count_devidedBy11 = num0f_Group11_forRemind });
                }
                #endregion
            }
            #endregion


            #region Distributing Coronal Slices Count in Multithread fator  44
            group44 = new List<Group_varibale>();
            if (total_SagittalSlice / thread_num <= 44)
            {
                #region Add Round number of 44 in different Threads 
                int groupSum_till_thisThread = 0;
                for (int c = 1; c <= thread_num; c++)
                {
                    groupSum_till_thisThread = 44 * c;

                    if (groupSum_till_thisThread <= total_SagittalSlice)
                    {
                        group44.Add(new Group_varibale() { ID = c, MembersCount = 44, Group_Count_devidedBy11 = 4 });
                    }

                }
                #endregion

                #region Add less Than < 44 in last Thread
                int totalCount_beforeThis_Thread = 0;
                for (int z = 0; z < group44.Count; z++)
                {
                    totalCount_beforeThis_Thread = totalCount_beforeThis_Thread + group44[z].MembersCount;
                }
                if (total_SagittalSlice - totalCount_beforeThis_Thread > 0)
                {
                    int memberCount = total_SagittalSlice - totalCount_beforeThis_Thread;

                    Devide_in_Groups11 _Groups = new Devide_in_Groups11();
                    int num0f_Group11_forRemind = _Groups.Find_numOf_Groups(11, memberCount);

                    group44.Add(new Group_varibale() { ID = group44.Count + 1, MembersCount = memberCount, Group_Count_devidedBy11 = num0f_Group11_forRemind });
                }
                #endregion
            }
            #endregion


            #region Distributing Coronal Slices Count in Multithread fator  55
            group55 = new List<Group_varibale>();
            if (total_SagittalSlice / thread_num <= 55)
            {
                #region Add Round number of 55 in different Threads 
                int groupSum_till_thisThread = 0;
                for (int c = 1; c <= thread_num; c++)
                {
                    groupSum_till_thisThread = 55 * c;

                    if (groupSum_till_thisThread <= total_SagittalSlice)
                    {
                        group55.Add(new Group_varibale() { ID = c, MembersCount = 55, Group_Count_devidedBy11 = 5 });
                    }

                }
                #endregion

                #region Add less Than < 55 in last Thread
                int totalCount_beforeThis_Thread = 0;
                for (int z = 0; z < group55.Count; z++)
                {
                    totalCount_beforeThis_Thread = totalCount_beforeThis_Thread + group55[z].MembersCount;
                }
                if (total_SagittalSlice - totalCount_beforeThis_Thread > 0)
                //group55.Add(new Group_varibale() { ID = group55.Count + 1, MembersCount = total_SagittalSlice - totalCount_beforeThis_Thread, Group_Count_devidedBy11 = 1 });
                {
                    int memberCount = total_SagittalSlice - totalCount_beforeThis_Thread;

                    Devide_in_Groups11 _Groups = new Devide_in_Groups11();
                    int num0f_Group11_forRemind = _Groups.Find_numOf_Groups(11, memberCount);

                    group55.Add(new Group_varibale() { ID = group55.Count + 1, MembersCount = memberCount, Group_Count_devidedBy11 = num0f_Group11_forRemind });
                }
                #endregion
            }
            #endregion

            #region Distributing Coronal Slices Count in Multithread fator  66
            group66 = new List<Group_varibale>();
            if (total_SagittalSlice / thread_num <= 66)
            {
                #region Add Round number of 66 in different Threads 
                int groupSum_till_thisThread = 0;
                for (int c = 1; c <= thread_num; c++)
                {
                    groupSum_till_thisThread = 66 * c;

                    if (groupSum_till_thisThread <= total_SagittalSlice)
                    {
                        group66.Add(new Group_varibale() { ID = c, MembersCount = 66, Group_Count_devidedBy11 = 6 });
                    }

                }
                #endregion

                #region Add less Than < 66 in last Thread
                int totalCount_beforeThis_Thread = 0;
                for (int z = 0; z < group66.Count; z++)
                {
                    totalCount_beforeThis_Thread = totalCount_beforeThis_Thread + group66[z].MembersCount;
                }
                if (total_SagittalSlice - totalCount_beforeThis_Thread > 0)
                {
                    int memberCount = total_SagittalSlice - totalCount_beforeThis_Thread;

                    Devide_in_Groups11 _Groups = new Devide_in_Groups11();
                    int num0f_Group11_forRemind = _Groups.Find_numOf_Groups(11, memberCount);

                    group66.Add(new Group_varibale() { ID = group66.Count + 1, MembersCount = memberCount, Group_Count_devidedBy11 = num0f_Group11_forRemind });
                }
                #endregion
            }
            #endregion


            #region Distributing Coronal Slices Count in Multithread fator  77
            group77 = new List<Group_varibale>();
            if (total_SagittalSlice / thread_num <= 77)
            {
                #region Add Round number of 77 in different Threads 
                int groupSum_till_thisThread = 0;
                for (int c = 1; c <= thread_num; c++)
                {
                    groupSum_till_thisThread = 77 * c;

                    if (groupSum_till_thisThread <= total_SagittalSlice)
                    {
                        group77.Add(new Group_varibale() { ID = c, MembersCount = 77, Group_Count_devidedBy11 = 7 });
                    }

                }
                #endregion

                #region Add less Than < 77 in last Thread
                int totalCount_beforeThis_Thread = 0;
                for (int z = 0; z < group77.Count; z++)
                {
                    totalCount_beforeThis_Thread = totalCount_beforeThis_Thread + group77[z].MembersCount;
                }
                if (total_SagittalSlice - totalCount_beforeThis_Thread > 0)
                //group77.Add(new Group_varibale() { ID = group77.Count + 1, MembersCount = total_SagittalSlice - totalCount_beforeThis_Thread, Group_Count_devidedBy11 = 1 });
                {
                    int memberCount = total_SagittalSlice - totalCount_beforeThis_Thread;

                    Devide_in_Groups11 _Groups = new Devide_in_Groups11();
                    int num0f_Group11_forRemind = _Groups.Find_numOf_Groups(11, memberCount);

                    group77.Add(new Group_varibale() { ID = group77.Count + 1, MembersCount = memberCount, Group_Count_devidedBy11 = num0f_Group11_forRemind });
                }
                #endregion
            }
            #endregion


            #region Distributing Coronal Slices Count in Multithread fator  88
            group88 = new List<Group_varibale>();
            if (total_SagittalSlice / thread_num <= 88)
            {
                #region Add Round number of 88 in different Threads 
                int groupSum_till_thisThread = 0;
                for (int c = 1; c <= thread_num; c++)
                {
                    groupSum_till_thisThread = 88 * c;

                    if (groupSum_till_thisThread <= total_SagittalSlice)
                    {
                        group88.Add(new Group_varibale() { ID = c, MembersCount = 88, Group_Count_devidedBy11 = 8 });
                    }

                }
                #endregion

                #region Add less Than < 88 in last Thread
                int totalCount_beforeThis_Thread = 0;
                for (int z = 0; z < group88.Count; z++)
                {
                    totalCount_beforeThis_Thread = totalCount_beforeThis_Thread + group88[z].MembersCount;
                }
                if (total_SagittalSlice - totalCount_beforeThis_Thread > 0)
                //group88.Add(new Group_varibale() { ID = group88.Count + 1, MembersCount = total_SagittalSlice - totalCount_beforeThis_Thread, Group_Count_devidedBy11 = 1 });
                {
                    int memberCount = total_SagittalSlice - totalCount_beforeThis_Thread;

                    Devide_in_Groups11 _Groups = new Devide_in_Groups11();
                    int num0f_Group11_forRemind = _Groups.Find_numOf_Groups(11, memberCount);

                    group88.Add(new Group_varibale() { ID = group88.Count + 1, MembersCount = memberCount, Group_Count_devidedBy11 = num0f_Group11_forRemind });
                }
                #endregion
            }
            #endregion


            #region Distributing Coronal Slices Count in Multithread fator  99
            group99 = new List<Group_varibale>();
            if (total_SagittalSlice / thread_num <= 99)
            {
                #region Add Round number of 99 in different Threads 
                int groupSum_till_thisThread = 0;
                for (int c = 1; c <= thread_num; c++)
                {
                    groupSum_till_thisThread = 99 * c;

                    if (groupSum_till_thisThread <= total_SagittalSlice)
                    {
                        group99.Add(new Group_varibale() { ID = c, MembersCount = 99, Group_Count_devidedBy11 = 9 });
                    }

                }
                #endregion

                #region Add less Than < 99 in last Thread
                int totalCount_beforeThis_Thread = 0;
                for (int z = 0; z < group99.Count; z++)
                {
                    totalCount_beforeThis_Thread = totalCount_beforeThis_Thread + group99[z].MembersCount;
                }
                if (total_SagittalSlice - totalCount_beforeThis_Thread > 0)
                {
                    int memberCount = total_SagittalSlice - totalCount_beforeThis_Thread;

                    Devide_in_Groups11 _Groups = new Devide_in_Groups11();
                    int num0f_Group11_forRemind = _Groups.Find_numOf_Groups(11, memberCount);

                    group99.Add(new Group_varibale() { ID = group99.Count + 1, MembersCount = memberCount, Group_Count_devidedBy11 = num0f_Group11_forRemind });
                }
                #endregion
            }
            #endregion


            #region Distributing Coronal Slices Count in Multithread fator  110
            group110 = new List<Group_varibale>();
            if (total_SagittalSlice / thread_num <= 110)
            {
                #region Add Round number of 110 in different Threads 
                int groupSum_till_thisThread = 0;
                for (int c = 1; c <= thread_num; c++)
                {
                    groupSum_till_thisThread = 110 * c;

                    if (groupSum_till_thisThread <= total_SagittalSlice)
                    {
                        group110.Add(new Group_varibale() { ID = c, MembersCount = 110, Group_Count_devidedBy11 = 10 });
                    }

                }
                #endregion

                #region Add less Than <110 in last Thread
                int totalCount_beforeThis_Thread = 0;
                for (int z = 0; z < group110.Count; z++)
                {
                    totalCount_beforeThis_Thread = totalCount_beforeThis_Thread + group110[z].MembersCount;
                }
                if (total_SagittalSlice - totalCount_beforeThis_Thread > 0)
                {
                    int memberCount = total_SagittalSlice - totalCount_beforeThis_Thread;

                    Devide_in_Groups11 _Groups = new Devide_in_Groups11();
                    int num0f_Group11_forRemind = _Groups.Find_numOf_Groups(11, memberCount);

                    group110.Add(new Group_varibale() { ID = group110.Count + 1, MembersCount = memberCount, Group_Count_devidedBy11 = num0f_Group11_forRemind });
                }
                #endregion
            }
            #endregion

            #region Distributing Coronal Slices Count in Multithread fator  121
            group121 = new List<Group_varibale>();
            if (total_SagittalSlice / thread_num <= 121)
            {
                #region Add Round number of 121 in different Threads 
                int groupSum_till_thisThread = 0;
                for (int c = 1; c <= thread_num; c++)
                {
                    groupSum_till_thisThread = 121 * c;

                    if (groupSum_till_thisThread <= total_SagittalSlice)
                    {
                        group121.Add(new Group_varibale() { ID = c, MembersCount = 121, Group_Count_devidedBy11 = 11 });
                    }

                }
                #endregion

                #region Add less Than <110 in last Thread
                int totalCount_beforeThis_Thread = 0;
                for (int z = 0; z < group121.Count; z++)
                {
                    totalCount_beforeThis_Thread = totalCount_beforeThis_Thread + group121[z].MembersCount;
                }
                if (total_SagittalSlice - totalCount_beforeThis_Thread > 0)
                {
                    int memberCount = total_SagittalSlice - totalCount_beforeThis_Thread;

                    Devide_in_Groups11 _Groups = new Devide_in_Groups11();
                    int num0f_Group11_forRemind = _Groups.Find_numOf_Groups(11, memberCount);

                    group121.Add(new Group_varibale() { ID = group121.Count + 1, MembersCount = memberCount, Group_Count_devidedBy11 = num0f_Group11_forRemind });
                }
                #endregion
            }
            #endregion


            #region Thread Count vs 11 factor which will give fastest speed 

            List<List_of_Groups> list_Of_Groups = new List<List_of_Groups>();
            if (group11.Count > 0)
                list_Of_Groups.Add(new List_of_Groups() { group_Varibale = group11, threadCount = group11.Count });

            if (group22.Count > 0)
                list_Of_Groups.Add(new List_of_Groups() { group_Varibale = group22, threadCount = group22.Count });

            if (group33.Count > 0)
                list_Of_Groups.Add(new List_of_Groups() { group_Varibale = group33, threadCount = group33.Count });

            if (group44.Count > 0)
                list_Of_Groups.Add(new List_of_Groups() { group_Varibale = group44, threadCount = group44.Count });

            if (group55.Count > 0)
                list_Of_Groups.Add(new List_of_Groups() { group_Varibale = group55, threadCount = group55.Count });

            if (group66.Count > 0)
                list_Of_Groups.Add(new List_of_Groups() { group_Varibale = group66, threadCount = group66.Count });

            if (group77.Count > 0)
                list_Of_Groups.Add(new List_of_Groups() { group_Varibale = group77, threadCount = group77.Count });

            if (group88.Count > 0)
                list_Of_Groups.Add(new List_of_Groups() { group_Varibale = group88, threadCount = group88.Count });

            if (group99.Count > 0)
                list_Of_Groups.Add(new List_of_Groups() { group_Varibale = group99, threadCount = group99.Count });

            if (group110.Count > 0)
                list_Of_Groups.Add(new List_of_Groups() { group_Varibale = group110, threadCount = group110.Count });


            if (group121.Count > 0)
                list_Of_Groups.Add(new List_of_Groups() { group_Varibale = group121, threadCount = group121.Count });


            Search_Fastest_ThreadGroup search_ = new Search_Fastest_ThreadGroup();

            #endregion



            return search_.Fastest_ThreadGroup(list_Of_Groups, thread_num).Item2;

        }

        /// <summary>
        /// Bring Maximum Thread With Distrbuted Coronal count so we get fastest Image process Speed
        /// </summary>
        /// <param name="total_SagittalSlice"></param>
        /// <param name="thread_num"></param>
        /// <returns></returns>
        public List<Group_varibale> BestCombination(int total_SagittalSlice, int thread_num)
        {
            #region Distributing Coronal Slices Count in Multithread fator  11
            group11 = new List<Group_varibale>();
            //? Main Logic 
            if (total_SagittalSlice / thread_num <= 11)
            {
                #region Add Round number of 11 in different Threads 
                int groupSum_till_thisThread = 0;
                for (int c = 1; c <= thread_num; c++)
                {
                    groupSum_till_thisThread = 11 * c;

                    if (groupSum_till_thisThread <= total_SagittalSlice)
                    {
                        group11.Add(new Group_varibale() { ID = c, MembersCount = 11, Group_Count_devidedBy11 = 1 });
                    }

                }
                #endregion

                #region Add less Than < 11 in last Thread
                int totalCount_beforeThis_Thread = 0;
                for (int z = 0; z < group11.Count; z++)
                {
                    totalCount_beforeThis_Thread = totalCount_beforeThis_Thread + group11[z].MembersCount;
                }
                if (total_SagittalSlice - totalCount_beforeThis_Thread > 0)
                {
                    int memberCount = total_SagittalSlice - totalCount_beforeThis_Thread;

                    Devide_in_Groups11 _Groups = new Devide_in_Groups11();
                    int num0f_Group11_forRemind = _Groups.Find_numOf_Groups(11, memberCount);

                    group11.Add(new Group_varibale() { ID = group11.Count + 1, MembersCount = memberCount, Group_Count_devidedBy11 = num0f_Group11_forRemind });
                }

                #endregion
            }
            #endregion


            #region Distributing Coronal Slices Count in Multithread fator  22
            group22 = new List<Group_varibale>();
            //? Main Logic 
            if (total_SagittalSlice / thread_num <= 22)
            {
                #region Add Round number of 11 in different Threads 
                int groupSum_till_thisThread = 0;
                for (int c = 1; c <= thread_num; c++)
                {
                    groupSum_till_thisThread = 22 * c;

                    if (groupSum_till_thisThread <= total_SagittalSlice)
                    {
                        group22.Add(new Group_varibale() { ID = c, MembersCount = 22, Group_Count_devidedBy11 = 2 });
                    }

                }
                #endregion

                #region Add less Than < 22 in last Thread
                int totalCount_beforeThis_Thread = 0;
                for (int z = 0; z < group22.Count; z++)
                {
                    totalCount_beforeThis_Thread = totalCount_beforeThis_Thread + group22[z].MembersCount;
                }

                if (total_SagittalSlice - totalCount_beforeThis_Thread > 0)
                //group22.Add(new Group_varibale() { ID = group22.Count + 1, MembersCount = total_SagittalSlice - totalCount_beforeThis_Thread, Group_Count_devidedBy11 = 1 });
                {
                    int memberCount = total_SagittalSlice - totalCount_beforeThis_Thread;

                    Devide_in_Groups11 _Groups = new Devide_in_Groups11();
                    int num0f_Group11_forRemind = _Groups.Find_numOf_Groups(11, memberCount);

                    group22.Add(new Group_varibale() { ID = group22.Count + 1, MembersCount = memberCount, Group_Count_devidedBy11 = num0f_Group11_forRemind });
                }
                #endregion
            }
            #endregion


            #region Distributing Coronal Slices Count in Multithread fator  33
            group33 = new List<Group_varibale>();
            //?Main Logic
            if (total_SagittalSlice / thread_num <= 33)
            {
                #region Add Round number of 11 in different Threads 
                int groupSum_till_thisThread = 0;
                for (int c = 1; c <= thread_num; c++)
                {
                    groupSum_till_thisThread = 33 * c;

                    if (groupSum_till_thisThread <= total_SagittalSlice)
                    {
                        group33.Add(new Group_varibale() { ID = c, MembersCount = 33, Group_Count_devidedBy11 = 3 });
                    }

                }
                #endregion

                #region Add less Than < 33 in last Thread
                int totalCount_beforeThis_Thread = 0;
                for (int z = 0; z < group33.Count; z++)
                {
                    totalCount_beforeThis_Thread = totalCount_beforeThis_Thread + group33[z].MembersCount;
                }
                if (total_SagittalSlice - totalCount_beforeThis_Thread > 0)
                //group33.Add(new Group_varibale() { ID = group33.Count + 1, MembersCount = total_SagittalSlice - totalCount_beforeThis_Thread, Group_Count_devidedBy11 = 1 });
                {
                    int memberCount = total_SagittalSlice - totalCount_beforeThis_Thread;

                    Devide_in_Groups11 _Groups = new Devide_in_Groups11();
                    int num0f_Group11_forRemind = _Groups.Find_numOf_Groups(11, memberCount);

                    group33.Add(new Group_varibale() { ID = group33.Count + 1, MembersCount = memberCount, Group_Count_devidedBy11 = num0f_Group11_forRemind });
                }
                #endregion
            }
            #endregion


            #region Distributing Coronal Slices Count in Multithread fator  44
            group44 = new List<Group_varibale>();
            //? Main Logic
            if (total_SagittalSlice / thread_num <= 44)
            {
                #region Add Round number of 44 in different Threads 
                int groupSum_till_thisThread = 0;
                for (int c = 1; c <= thread_num; c++)
                {
                    groupSum_till_thisThread = 44 * c;

                    if (groupSum_till_thisThread <= total_SagittalSlice)
                    {
                        group44.Add(new Group_varibale() { ID = c, MembersCount = 44, Group_Count_devidedBy11 = 4 });
                    }

                }
                #endregion

                #region Add less Than < 44 in last Thread
                int totalCount_beforeThis_Thread = 0;
                for (int z = 0; z < group44.Count; z++)
                {
                    totalCount_beforeThis_Thread = totalCount_beforeThis_Thread + group44[z].MembersCount;
                }
                if (total_SagittalSlice - totalCount_beforeThis_Thread > 0)
                //group44.Add(new Group_varibale() { ID = group44.Count + 1, MembersCount = total_SagittalSlice - totalCount_beforeThis_Thread, Group_Count_devidedBy11 = 1 });
                {
                    int memberCount = total_SagittalSlice - totalCount_beforeThis_Thread;

                    Devide_in_Groups11 _Groups = new Devide_in_Groups11();
                    int num0f_Group11_forRemind = _Groups.Find_numOf_Groups(11, memberCount);

                    group44.Add(new Group_varibale() { ID = group44.Count + 1, MembersCount = memberCount, Group_Count_devidedBy11 = num0f_Group11_forRemind });
                }
                #endregion
            }
            #endregion


            #region Distributing Coronal Slices Count in Multithread fator  55
            group55 = new List<Group_varibale>();
            //? Main Logic 
            if (total_SagittalSlice / thread_num <= 55)
            {
                #region Add Round number of 55 in different Threads 
                int groupSum_till_thisThread = 0;
                for (int c = 1; c <= thread_num; c++)
                {
                    groupSum_till_thisThread = 55 * c;

                    if (groupSum_till_thisThread <= total_SagittalSlice)
                    {
                        group55.Add(new Group_varibale() { ID = c, MembersCount = 55, Group_Count_devidedBy11 = 5 });
                    }

                }
                #endregion

                #region Add less Than < 55 in last Thread
                int totalCount_beforeThis_Thread = 0;
                for (int z = 0; z < group55.Count; z++)
                {
                    totalCount_beforeThis_Thread = totalCount_beforeThis_Thread + group55[z].MembersCount;
                }
                if (total_SagittalSlice - totalCount_beforeThis_Thread > 0)
                //group55.Add(new Group_varibale() { ID = group55.Count + 1, MembersCount = total_SagittalSlice - totalCount_beforeThis_Thread, Group_Count_devidedBy11 = 1 });
                {
                    int memberCount = total_SagittalSlice - totalCount_beforeThis_Thread;

                    Devide_in_Groups11 _Groups = new Devide_in_Groups11();
                    int num0f_Group11_forRemind = _Groups.Find_numOf_Groups(11, memberCount);

                    group55.Add(new Group_varibale() { ID = group55.Count + 1, MembersCount = memberCount, Group_Count_devidedBy11 = num0f_Group11_forRemind });
                }
                #endregion
            }
            #endregion


            #region Distributing Coronal Slices Count in Multithread fator  66
            group66 = new List<Group_varibale>();
            //? Main Logic
            if (total_SagittalSlice / thread_num <= 66)
            {
                #region Add Round number of 66 in different Threads 
                int groupSum_till_thisThread = 0;
                for (int c = 1; c <= thread_num; c++)
                {
                    groupSum_till_thisThread = 66 * c;

                    if (groupSum_till_thisThread <= total_SagittalSlice)
                    {
                        group66.Add(new Group_varibale() { ID = c, MembersCount = 66, Group_Count_devidedBy11 = 6 });
                    }

                }
                #endregion

                #region Add less Than < 66 in last Thread
                int totalCount_beforeThis_Thread = 0;
                for (int z = 0; z < group66.Count; z++)
                {
                    totalCount_beforeThis_Thread = totalCount_beforeThis_Thread + group66[z].MembersCount;
                }
                if (total_SagittalSlice - totalCount_beforeThis_Thread > 0)
                {
                    int memberCount = total_SagittalSlice - totalCount_beforeThis_Thread;

                    Devide_in_Groups11 _Groups = new Devide_in_Groups11();
                    int num0f_Group11_forRemind = _Groups.Find_numOf_Groups(11, memberCount);

                    group66.Add(new Group_varibale() { ID = group66.Count + 1, MembersCount = memberCount, Group_Count_devidedBy11 = num0f_Group11_forRemind });
                }
                #endregion
            }

            //for(int j=0;j<group66.Count;j++)
            //{
            //  MessageBox.Show(group66[j].ID +" : " + group66[j].MembersCount + " : " + group66[j].Group_Count_devidedBy11.ToString());

            //}
            #endregion


            #region Distributing Coronal Slices Count in Multithread fator  77
            group77 = new List<Group_varibale>();
            //? Main Logic
            if (total_SagittalSlice / thread_num <= 77)
            {
                #region Add Round number of 77 in different Threads 
                int groupSum_till_thisThread = 0;
                for (int c = 1; c <= thread_num; c++)
                {
                    groupSum_till_thisThread = 77 * c;

                    if (groupSum_till_thisThread <= total_SagittalSlice)
                    {
                        group77.Add(new Group_varibale() { ID = c, MembersCount = 77, Group_Count_devidedBy11 = 7 });
                    }

                }
                #endregion

                #region Add less Than < 77 in last Thread
                int totalCount_beforeThis_Thread = 0;
                for (int z = 0; z < group77.Count; z++)
                {
                    totalCount_beforeThis_Thread = totalCount_beforeThis_Thread + group77[z].MembersCount;
                }
                if (total_SagittalSlice - totalCount_beforeThis_Thread > 0)
                //group77.Add(new Group_varibale() { ID = group77.Count + 1, MembersCount = total_SagittalSlice - totalCount_beforeThis_Thread, Group_Count_devidedBy11 = 1 });
                {
                    int memberCount = total_SagittalSlice - totalCount_beforeThis_Thread;

                    Devide_in_Groups11 _Groups = new Devide_in_Groups11();
                    int num0f_Group11_forRemind = _Groups.Find_numOf_Groups(11, memberCount);

                    group77.Add(new Group_varibale() { ID = group77.Count + 1, MembersCount = memberCount, Group_Count_devidedBy11 = num0f_Group11_forRemind });
                }
                #endregion
            }
            #endregion


            #region Distributing Coronal Slices Count in Multithread fator  88
            group88 = new List<Group_varibale>();
            //? Main Logic
            if (total_SagittalSlice / thread_num <= 88)
            {
                #region Add Round number of 88 in different Threads 
                int groupSum_till_thisThread = 0;
                for (int c = 1; c <= thread_num; c++)
                {
                    groupSum_till_thisThread = 88 * c;

                    if (groupSum_till_thisThread <= total_SagittalSlice)
                    {
                        group88.Add(new Group_varibale() { ID = c, MembersCount = 88, Group_Count_devidedBy11 = 8 });
                    }

                }
                #endregion

                #region Add less Than < 88 in last Thread
                int totalCount_beforeThis_Thread = 0;
                for (int z = 0; z < group88.Count; z++)
                {
                    totalCount_beforeThis_Thread = totalCount_beforeThis_Thread + group88[z].MembersCount;
                }
                if (total_SagittalSlice - totalCount_beforeThis_Thread > 0)
                //group88.Add(new Group_varibale() { ID = group88.Count + 1, MembersCount = total_SagittalSlice - totalCount_beforeThis_Thread, Group_Count_devidedBy11 = 1 });
                {
                    int memberCount = total_SagittalSlice - totalCount_beforeThis_Thread;

                    Devide_in_Groups11 _Groups = new Devide_in_Groups11();
                    int num0f_Group11_forRemind = _Groups.Find_numOf_Groups(11, memberCount);

                    group88.Add(new Group_varibale() { ID = group88.Count + 1, MembersCount = memberCount, Group_Count_devidedBy11 = num0f_Group11_forRemind });
                }
                #endregion
            }
            #endregion


            #region Distributing Coronal Slices Count in Multithread fator  99
            group99 = new List<Group_varibale>();
            //?Main Logic
            if (total_SagittalSlice / thread_num <= 99)
            {
                #region Add Round number of 99 in different Threads 
                int groupSum_till_thisThread = 0;
                for (int c = 1; c <= thread_num; c++)
                {
                    groupSum_till_thisThread = 99 * c;

                    if (groupSum_till_thisThread <= total_SagittalSlice)
                    {
                        group99.Add(new Group_varibale() { ID = c, MembersCount = 99, Group_Count_devidedBy11 = 9 });
                    }

                }
                #endregion

                #region Add less Than < 99 in last Thread
                int totalCount_beforeThis_Thread = 0;
                for (int z = 0; z < group99.Count; z++)
                {
                    totalCount_beforeThis_Thread = totalCount_beforeThis_Thread + group99[z].MembersCount;
                }
                if (total_SagittalSlice - totalCount_beforeThis_Thread > 0)
                //group99.Add(new Group_varibale() { ID = group99.Count + 1, MembersCount = total_SagittalSlice - totalCount_beforeThis_Thread, Group_Count_devidedBy11 = 1 });
                {
                    int memberCount = total_SagittalSlice - totalCount_beforeThis_Thread;

                    Devide_in_Groups11 _Groups = new Devide_in_Groups11();
                    int num0f_Group11_forRemind = _Groups.Find_numOf_Groups(11, memberCount);

                    group99.Add(new Group_varibale() { ID = group99.Count + 1, MembersCount = memberCount, Group_Count_devidedBy11 = num0f_Group11_forRemind });
                }
                #endregion
            }
            #endregion


            #region Distributing Coronal Slices Count in Multithread fator  110
            group110 = new List<Group_varibale>();
            //? Main Logic
            if (total_SagittalSlice / thread_num <= 110)
            {
                #region Add Round number of 110 in different Threads 
                int groupSum_till_thisThread = 0;
                for (int c = 1; c <= thread_num; c++)
                {
                    groupSum_till_thisThread = 110 * c;

                    if (groupSum_till_thisThread <= total_SagittalSlice)
                    {
                        group110.Add(new Group_varibale() { ID = c, MembersCount = 110, Group_Count_devidedBy11 = 10 });
                    }

                }
                #endregion

                #region Add less Than <110 in last Thread
                int totalCount_beforeThis_Thread = 0;
                for (int z = 0; z < group110.Count; z++)
                {
                    totalCount_beforeThis_Thread = totalCount_beforeThis_Thread + group110[z].MembersCount;
                }
                if (total_SagittalSlice - totalCount_beforeThis_Thread > 0)
                //group110.Add(new Group_varibale() { ID = group110.Count + 1, MembersCount = total_SagittalSlice - totalCount_beforeThis_Thread, Group_Count_devidedBy11 = 1 });
                {
                    int memberCount = total_SagittalSlice - totalCount_beforeThis_Thread;

                    Devide_in_Groups11 _Groups = new Devide_in_Groups11();
                    int num0f_Group11_forRemind = _Groups.Find_numOf_Groups(11, memberCount);

                    group110.Add(new Group_varibale() { ID = group110.Count + 1, MembersCount = memberCount, Group_Count_devidedBy11 = num0f_Group11_forRemind });
                }
                #endregion
            }

            #endregion


            #region Distributing Coronal Slices Count in Multithread fator  121
            group121 = new List<Group_varibale>();
            //? Main Logic
            if (total_SagittalSlice / thread_num <= 121)
            {
                #region Add Round number of 121 in different Threads 
                int groupSum_till_thisThread = 0;
                for (int c = 1; c <= thread_num; c++)
                {
                    groupSum_till_thisThread = 121 * c;

                    if (groupSum_till_thisThread <= total_SagittalSlice)
                    {
                        group121.Add(new Group_varibale() { ID = c, MembersCount = 121, Group_Count_devidedBy11 = 11 });
                    }

                }
                #endregion

                #region Add less Than <110 in last Thread
                int totalCount_beforeThis_Thread = 0;
                for (int z = 0; z < group121.Count; z++)
                {
                    totalCount_beforeThis_Thread = totalCount_beforeThis_Thread + group121[z].MembersCount;
                }
                if (total_SagittalSlice - totalCount_beforeThis_Thread > 0)
                //group121.Add(new Group_varibale() { ID = group121.Count + 1, MembersCount = total_SagittalSlice - totalCount_beforeThis_Thread, Group_Count_devidedBy11 = 1 });
                {
                    int memberCount = total_SagittalSlice - totalCount_beforeThis_Thread;

                    Devide_in_Groups11 _Groups = new Devide_in_Groups11();
                    int num0f_Group11_forRemind = _Groups.Find_numOf_Groups(11, memberCount);

                    group121.Add(new Group_varibale() { ID = group121.Count + 1, MembersCount = memberCount, Group_Count_devidedBy11 = num0f_Group11_forRemind });
                }
                #endregion
            }
            #endregion


            #region Thread Count vs 11 factor which will give fastest speed 

            List<List_of_Groups> list_Of_Groups = new List<List_of_Groups>();
            if (group11.Count > 0)
                list_Of_Groups.Add(new List_of_Groups() { group_Varibale = group11, threadCount = group11.Count });

            if (group22.Count > 0)
                list_Of_Groups.Add(new List_of_Groups() { group_Varibale = group22, threadCount = group22.Count });

            if (group33.Count > 0)
                list_Of_Groups.Add(new List_of_Groups() { group_Varibale = group33, threadCount = group33.Count });

            if (group44.Count > 0)
                list_Of_Groups.Add(new List_of_Groups() { group_Varibale = group44, threadCount = group44.Count });

            if (group55.Count > 0)
                list_Of_Groups.Add(new List_of_Groups() { group_Varibale = group55, threadCount = group55.Count });

            if (group66.Count > 0)
                list_Of_Groups.Add(new List_of_Groups() { group_Varibale = group66, threadCount = group66.Count });

            if (group77.Count > 0)
                list_Of_Groups.Add(new List_of_Groups() { group_Varibale = group77, threadCount = group77.Count });

            if (group88.Count > 0)
                list_Of_Groups.Add(new List_of_Groups() { group_Varibale = group88, threadCount = group88.Count });

            if (group99.Count > 0)
                list_Of_Groups.Add(new List_of_Groups() { group_Varibale = group99, threadCount = group99.Count });

            if (group110.Count > 0)
                list_Of_Groups.Add(new List_of_Groups() { group_Varibale = group110, threadCount = group110.Count });

            if (group121.Count > 0)
                list_Of_Groups.Add(new List_of_Groups() { group_Varibale = group121, threadCount = group121.Count });


            Search_Fastest_ThreadGroup search_ = new Search_Fastest_ThreadGroup();

            #endregion

            return search_.Fastest_ThreadGroup(list_Of_Groups, thread_num).Item2;

        }

        public void See_AllGroup_Count()
        {
            Console.WriteLine(" Group11 Count={0}", group11.Count);
            Console.WriteLine(" Group22 Count={0}", group22.Count);
            Console.WriteLine(" Group33 Count={0}", group33.Count);
            Console.WriteLine(" Group44 Count={0}", group44.Count);
            Console.WriteLine(" Group55 Count={0}", group55.Count);
            Console.WriteLine(" Group66 Count={0}", group66.Count);
            Console.WriteLine(" Group77 Count={0}", group77.Count);
            Console.WriteLine(" Group88 Count={0}", group88.Count);
            Console.WriteLine(" Group99 Count={0}", group99.Count);
            Console.WriteLine(" Group110 Count={0}", group110.Count);
            Console.WriteLine(" Group121 Count={0}", group121.Count);
        }


        public void Clear_AllGroup_Count()
        {
            group11.Clear();
            group22.Clear();
            group33.Clear();
            group44.Clear();
            group55.Clear();
            group66.Clear();
            group77.Clear();
            group88.Clear();
            group99.Clear();
            group110.Clear();
            group121.Clear();

            Console.WriteLine("\n Value after Clear list");

            Console.WriteLine(" Group11 Count={0}", group11.Count);
            Console.WriteLine(" Group22 Count={0}", group22.Count);
            Console.WriteLine(" Group33 Count={0}", group33.Count);
            Console.WriteLine(" Group44 Count={0}", group44.Count);
            Console.WriteLine(" Group55 Count={0}", group55.Count);
            Console.WriteLine(" Group66 Count={0}", group66.Count);
            Console.WriteLine(" Group77 Count={0}", group77.Count);
            Console.WriteLine(" Group88 Count={0}", group88.Count);
            Console.WriteLine(" Group99 Count={0}", group99.Count);
            Console.WriteLine(" Group110 Count={0}", group110.Count);
            Console.WriteLine(" Group121 Count={0}", group121.Count);
        }
    }

}
