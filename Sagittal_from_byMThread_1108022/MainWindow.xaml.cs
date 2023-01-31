using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using Sagittal_from_byMThread_1108022.Axial_Bmp;
using Sagittal_from_byMThread_1108022.Axial_Bmp.mm_to_Pixel;
using Sagittal_from_byMThread_1108022.Sagittal_Bmp.Distribute_over_Threads;
using Sagittal_from_byMThread_1108022.Sagittal_Bmp;
using System.IO;

namespace Sagittal_from_byMThread_1108022
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        #region  Axial Data for generating Coronal Images
        //  10.11 am  02.08.2022 by Abhishek 
        public int AxialWidth { get; set; } = 512; // comes from DICOM Tag
        public int AxialImage_TotalCount { get; set; } // comes from DICOM Tag
        public int AxialImage_Height { get; set; } = 666; // comes from DICOM Tag
        /// <summary>
        ///  in mm , from DICOM Tag
        /// </summary>
        public double Slice_Thickness { get; set; } = 1.25; // comes from DICOM Tag
        #endregion

        #region  Purpose : Select Axial iamge folder path & load Axial images-----Step-1
        List<string> ArrangedAxialimages = null;
        string bSlash = @"\";
        string AxialFolderPath = null;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Axial_arrange axial = new Axial_arrange();
            var Return = axial.LoadAxialimages();
            ArrangedAxialimages = Return.Item1;
            AxialFolderPath = Return.Item2;


            //? 10.16 am  02.08.2022 by Abhishek to create Coronal Image Height
            AxialImage_TotalCount = ArrangedAxialimages.Count;
        }
        #endregion

        #region  Purpose :  by Mouse scroll change Axial images------Step-2
        int num = 0;
        private void axial_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            ImageStackScroll(e.Delta, inputImage2, ArrangedAxialimages);
        }
        private void ImageStackScroll(int MouseWheelEventArgs, System.Windows.Controls.Image image, List<string> ArrangedImages)
        {
            if (MouseWheelEventArgs > 0)
                num++;

            else if (MouseWheelEventArgs < 0)
                num--;

            if (num < 0)
                num = 0;

            else if (num >= ArrangedImages.Count) // Replacing 26.2.22 "itemsAxial" by "itemAxialimageName", as out of memory due to storing complite image path in "itemsAxial",where "itemAxialimageName" only image name 
                num = ArrangedImages.Count - 1;


            Uri fileUri = new Uri(AxialFolderPath + bSlash + ArrangedAxialimages[num]);
            image.Source = new BitmapImage(fileUri);
        }
        #endregion

        #region Purpose: Sagittal Images generation by Multithread from Axial Images------Step-3

        string SagittalFolderPath = null;
        private void Sagittal_Click(object sender, RoutedEventArgs e)
        {
            SagittalFolderPath = @"C:\Users\91993\Desktop\SegittalImagesLockBitUnsafe\";

            #region  Unit Conversion : Slice Thickness 
            mm_to_Pixel to_Pixel = new mm_to_Pixel(Slice_Thickness);
            int sliceThickness_in_Pixel = to_Pixel.GetValue_inInt_96ppi();
            #endregion

            #region  Multi Thread Coronal Generation
            #region Varibale Encapsulation & Assign--- Step-1
            Group_Varibale_MultiThread varibale_MultiThread = new Group_Varibale_MultiThread();

            varibale_MultiThread.Axial_height_pix = AxialImage_Height;
            varibale_MultiThread.Axial_width_pix = AxialWidth;

            varibale_MultiThread.AxialFolderPath = AxialFolderPath;
            varibale_MultiThread.ArrangedAxialImages = ArrangedAxialimages;
            varibale_MultiThread.SagittalFolderPath = SagittalFolderPath;

            Voxel_Thick voxel_Thickness = new Voxel_Thick();
            varibale_MultiThread.VoxelThickness_in_Pixel = voxel_Thickness.Thickness(sliceThickness_in_Pixel, Voxel_Thick.Scan_Types.Sprial);

            varibale_MultiThread.Percentage_of_TotalThread_beUse = 0.7;
            #endregion

            #region Create a Blank Sagittal Image--Step-2
            // Reason for Selecting PixelFormat.Format32bppArgb  :  as Axial image is 32BPPArgb
            int height_sagittal = varibale_MultiThread.VoxelThickness_in_Pixel * AxialImage_TotalCount;

            Bitmap sagittal_Blank = new Bitmap(AxialImage_Height, height_sagittal, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            sagittal_Blank.Save(@"C:\Users\91993\Desktop\BlankSagittal.bmp");
            varibale_MultiThread.Sagittal_blank_imagePath = @"C:\Users\91993\Desktop\BlankSagittal.bmp";

            #endregion

            #region Main Logic -- Step-3
            Main_Sagittal_Generation main_Sagittal = new Main_Sagittal_Generation();

            Initiate_MultiThread_SagittalGenera multiThread_SagittalGenera = new Initiate_MultiThread_SagittalGenera();
            multiThread_SagittalGenera.Initiate_Multithread(varibale_MultiThread, main_Sagittal.MultipleSagittal);
            #endregion

            #region Delete Blank Coronal -- Step-4 / Last 
            sagittal_Blank.Dispose();
            #endregion
            #endregion

        }
        #endregion

        private void del_sagittal_balank_Click(object sender, RoutedEventArgs e)
        {
            File.Delete(@"C:\Users\91993\Desktop\BlankSagittal.bmp");

        }

    }
}
