using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace Sagittal_from_byMThread_1108022.Axial_Bmp
{
    /// <summary>
    /// 1  Arrange Files in numerical order , without this files will be arrenged as 0,1,10,11,12...19, 2,20,21.
    /// 2  Read all files form folder and save in List
    /// </summary>
    public class myArrageFiles
    {
        //Purpose : this method show all files with size, creation date, time
        public List<string> ShowFileDetails(string folderPath)
        {
            // Project Source :  https://www.c-sharpcorner.com/Resources/732/how-to-read-files-in-a-folder-or-directory-in-C-Sharp.aspx
            // Change this path to the directory you want to read
            string path = folderPath;
            DirectoryInfo dir = new DirectoryInfo(path);
            Console.WriteLine("File Name                       Size        Creation Date and Time");
            Console.WriteLine("=================================================================");
            List<string> nameList = new List<string>();
            foreach (FileInfo flInfo in dir.GetFiles())
            {
                String name = flInfo.Name;
                nameList.Add(name);/////by Abhi
                long size = flInfo.Length;
                DateTime creationTime = flInfo.CreationTime;
                Console.WriteLine("{0, -30:g} {1,-12:N0} {2} ", name, size, creationTime);
            }
            Console.ReadLine();

            return nameList;
        }

        //Purpose : this method read all files form folder and save in List
        public List<string> ReadFileNamesAndSave(string folderPath)
        {
            // Project Source :  https://www.c-sharpcorner.com/Resources/732/how-to-read-files-in-a-folder-or-directory-in-C-Sharp.aspx
            // Change this path to the directory you want to read
            string path = folderPath;
            DirectoryInfo dir = new DirectoryInfo(path);
            List<string> nameList = new List<string>();
            foreach (FileInfo flInfo in dir.GetFiles())
            {
                String name = flInfo.Name;
                nameList.Add(name);/////by Abhi
            }

            return nameList;
        }


        //Purpose : Arrange Files in numerical order , without this files will be arrenged as 0,1,10,11,12...19, 2,20,21....
        public class StrCmpLogicalComparer : Comparer<string>
        {
            [DllImport("Shlwapi.dll", CharSet = CharSet.Unicode)]
            private static extern int StrCmpLogicalW(string x, string y);

            public override int Compare(string x, string y)
            {
                return StrCmpLogicalW(x, y);
            }
        }

        public List<string> ArrangeFilesInSequence(string folderPath)
        {
            // ShowFileDetails() Mthod   is retuning all files names in List but not in sequence******
            // List<string> returnNameList = ShowFileDetails(folderPath);
            List<string> returnNameList = ReadFileNamesAndSave(folderPath);

            //Purpose : Arrange Files in numerical order , without this files will be arrenged as 0,1,10,11,12...19, 2,20,21....
            returnNameList.Sort(new StrCmpLogicalComparer());

            return returnNameList;
        }

    }
}
