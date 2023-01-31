using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sagittal_from_byMThread_1108022.Sagittal_Bmp.Distribute_over_Threads
{
    /// <summary>
    /// Encapsule  6 varibales in 1:  int  Dicom_file_count , double  Percentage_of_TotalThread_beUse ,  int  sliceThickness_in_Pixel
    ///  string   AxialFolderPath ,  string   CoronalFolderPath ,  string-List    ArrangedAxialImages
    /// </summary>
    public class Group_Varibale_MultiThread
    {
        // public int Dicom_file_count { get;set;}
        public int Axial_height_pix { get; set; }
        public int Axial_width_pix { get; set; }
        public double Percentage_of_TotalThread_beUse { get; set; } = 0.7;
        public int VoxelThickness_in_Pixel { get; set; } = 3;

        public string AxialFolderPath { get; set; }
        public string SagittalFolderPath { get; set; }
        public string Sagittal_blank_imagePath { get; set; }

        public List<string> ArrangedAxialImages { get; set; }


    }
}
