using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Sagittal_from_byMThread_1108022.Axial_Bmp
{
    public class Axial_arrange
    {
        //this list hold arranged images list 1,2,3,.....700 
        List<string> itemAxialimageName = null;// all Axial iamges in order , example 666 images 
        string bSlash = @"\";
        string AxialFolderPath = null;


        // Purpose : Select Axial iamge folder path & load Axial images
        /*Step-1---------*/
        /// <summary>
        /// Test
        /// </summary>
        public (List<string>, string) LoadAxialimages()
        {
            // From Folder Browser -user will select Folder

            FolderBrowserDialog openFileDlg = new FolderBrowserDialog();
            var result = openFileDlg.ShowDialog();
            if (result.ToString() != string.Empty)
            {
                //Folder Address 
                AxialFolderPath = openFileDlg.SelectedPath;
                System.Windows.MessageBox.Show("", AxialFolderPath);
            }


            myArrageFiles arrageFiles = new myArrageFiles();
            itemAxialimageName = arrageFiles.ArrangeFilesInSequence(AxialFolderPath); // returing file name "I10(01).bmp" ,"I10(02).bmp"......so on without complite path 


            return (itemAxialimageName, AxialFolderPath);
        }


        //Purpose : Arrange Files in numerical order , without this files will be arrenged as 0,1,10,11,12...19, 2,20,21....
        private class StrCmpLogicalComparer : Comparer<string>
        {
            [DllImport("Shlwapi.dll", CharSet = CharSet.Unicode)]
            private static extern int StrCmpLogicalW(string x, string y);

            public override int Compare(string x, string y)
            {
                return StrCmpLogicalW(x, y);
            }
        }
    }
}
