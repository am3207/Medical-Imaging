using System;
using System.Collections.Generic;
using System.Threading;
using Sagittal_from_byMThread_1108022.Sagittal_Bmp.Distribute_over_Threads;

namespace Sagittal_from_byMThread_1108022.Sagittal_Bmp
{

    public class Initiate_MultiThread_SagittalGenera
    {
        /// <summary>
        /// Run one Method in Different Thread for  fast processing
        /// </summary>
        /// <param name="Dicom_file_count"></param>
        /// <param name="Percentage_of_TotalThread_beUse"> value 0.5 to 0.8. </param>
        /// <param name="Method_for_MultiThread"> Method will be run in different Thread.</param>

        public void Initiate_Multithread(Group_Varibale_MultiThread _Varibale_MultiThread, Action<int, Group_Varibale_MultiThread, List<Group_varibale>> Method_for_MultiThread)
        {
            #region Find Total Thread from Hardware 

            #region Inputs for Multithread
            int CPU_ThreadCount = Environment.ProcessorCount;
            double Percentage_of_Thread_beUse = _Varibale_MultiThread.Percentage_of_TotalThread_beUse;

            #region Deciding Working Thread Count out of total Threads count
            double inUse_Thread_count = CPU_ThreadCount * Percentage_of_Thread_beUse;
            int Num_of_Thread_inUse = (int)Math.Round(inUse_Thread_count);
            #endregion

            #endregion

            #endregion

            #region  Distribute Total Cornal Images  over Each Active Thread 

            int total_SagittalSlice = _Varibale_MultiThread.Axial_width_pix / _Varibale_MultiThread.VoxelThickness_in_Pixel;

            Coronal_MultiThread_VsGroup _MultiThread_VsGroup = new Coronal_MultiThread_VsGroup();
            List<Group_varibale> group_Varibales = _MultiThread_VsGroup.BestCombination(total_SagittalSlice, Num_of_Thread_inUse);

            #endregion

            #region Calling Same Method from MultiThread depends on Thread Count
            if (Num_of_Thread_inUse == 4 || Num_of_Thread_inUse > 4)
            {

                #region Thread 1
                Thread thread1 = new Thread(() => Method_for_MultiThread(1, _Varibale_MultiThread, group_Varibales));
                thread1.Start();
                #endregion

                #region Thread 2
                // Thread thread2 = new Thread(() => Method_for_MultiThread(2, startNum2, endNum2));
                Thread thread2 = new Thread(() => Method_for_MultiThread(2, _Varibale_MultiThread, group_Varibales));
                thread2.Start();
                #endregion

                #region Thread 3
                // Thread thread3 = new Thread(() => Method_for_MultiThread(3, startNum3, endNum3));
                Thread thread3 = new Thread(() => Method_for_MultiThread(3, _Varibale_MultiThread, group_Varibales));
                thread3.Start();
                #endregion

                #region Thread 4
                Thread thread4 = new Thread(() => Method_for_MultiThread(4, _Varibale_MultiThread, group_Varibales));
                thread4.Start();
                #endregion
            }
            if (Num_of_Thread_inUse == 5 || Num_of_Thread_inUse > 5)
            {
                #region Thread 5
                Thread thread5 = new Thread(() => Method_for_MultiThread(5, _Varibale_MultiThread, group_Varibales));
                thread5.Start();
                #endregion
            }
            if (Num_of_Thread_inUse == 6 || Num_of_Thread_inUse > 6)
            {
                #region Thread 6
                Thread thread6 = new Thread(() => Method_for_MultiThread(6, _Varibale_MultiThread, group_Varibales));
                thread6.Start();
                #endregion
            }
            if (Num_of_Thread_inUse == 10 || Num_of_Thread_inUse > 10)
            {
                #region Thread 7
                Thread thread7 = new Thread(() => Method_for_MultiThread(7, _Varibale_MultiThread, group_Varibales));
                thread7.Start();
                #endregion

                #region Thread 8
                Thread thread8 = new Thread(() => Method_for_MultiThread(8, _Varibale_MultiThread, group_Varibales));
                thread8.Start();
                #endregion

                #region Thread 9
                Thread thread9 = new Thread(() => Method_for_MultiThread(9, _Varibale_MultiThread, group_Varibales));
                thread9.Start();
                #endregion

                #region Thread 10
                Thread thread10 = new Thread(() => Method_for_MultiThread(10, _Varibale_MultiThread, group_Varibales));
                thread10.Start();
                #endregion
            }
            if (Num_of_Thread_inUse == 11 || Num_of_Thread_inUse > 11)
            {
                #region Thread 11
                Thread thread11 = new Thread(() => Method_for_MultiThread(11, _Varibale_MultiThread, group_Varibales));
                thread11.Start();
                #endregion
            }
            if (Num_of_Thread_inUse == 12 || Num_of_Thread_inUse > 12)
            {
                #region Thread 12
                Thread thread12 = new Thread(() => Method_for_MultiThread(12, _Varibale_MultiThread, group_Varibales));
                thread12.Start();
                #endregion
            }
            #endregion

        }

    }

}
