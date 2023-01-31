using System;
using System.Collections.Generic;
using Sagittal_from_byMThread_1108022.Sagittal_Bmp.Distribute_over_Threads;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Sagittal_from_byMThread_1108022.Sagittal_Bmp
{

    /// <summary>
    ///  Coronal Images generation from Axial using Multi-Thread
    /// </summary>
    public class Main_Sagittal_Generation
    {

        string bSlash = @"\";
        int load = 0;


        // ?  Generate Multiple  Coronal image
        public void MultipleSagittal(int ThreadID, Group_Varibale_MultiThread varibale_MultiThread, List<Group_varibale> threadList)
        {
            //? 11.06 pm 6.08.2022  by Abhishek 

            string AxialFolderPath = varibale_MultiThread.AxialFolderPath;
            string SagittalFolderPath = varibale_MultiThread.SagittalFolderPath;
            List<string> ArrangedAxialImages = varibale_MultiThread.ArrangedAxialImages;
            int sliceThickness_in_Pixel = varibale_MultiThread.VoxelThickness_in_Pixel;

            //? 17.37 pm 5.08.2022  by Abhishek   - for Giving Multiple Thread Images  Serial number

            int Thread_Serial_Num = ThreadID;
            int Total_Image_Qty = threadList[ThreadID - 1].MembersCount;
            int Loop_Count = threadList[ThreadID - 1].Group_Count_devidedBy11;

            //End-25

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            #region Generarting Multiple Coronal Images
            int total_loop_count = 0;
            for (int j = 0; j < Loop_Count; j++)
            {
                // why 11 : more than 11 image will give Memory error
                for (int r = j * 11; r < j * 11 + 11; r++)
                {
                    string firstPartOfString = SagittalFolderPath;

                    //? 17.49 pm 5.08.2022  by Abhishek   - for Giving Multiple Thread Images  Serial number
                    total_loop_count++;
                    string secondPartOfString = null;
                    if (total_loop_count <= Total_Image_Qty)
                    {
                        int total_image_count_before_This = 0;
                        for (int c = 0; c < ThreadID - 1; c++)
                        {
                            total_image_count_before_This = total_image_count_before_This + threadList[c].MembersCount;
                        }

                        secondPartOfString = (r + total_image_count_before_This).ToString();
                    }
                    else break;

                    string thirdPartOfString = ".bmp";
                    int num2 = Convert.ToInt32(secondPartOfString) * sliceThickness_in_Pixel; //? 12.17 noon  6.08.22 by Abhishek

                    string nameOfsagittalImagePath = firstPartOfString + secondPartOfString + thirdPartOfString;
                    string SagittalBlankImage_path = varibale_MultiThread.Sagittal_blank_imagePath;

                    int startWidth = Convert.ToInt32(secondPartOfString) * sliceThickness_in_Pixel;

                    int AxialHeight_pix=varibale_MultiThread.Axial_height_pix;

                  UnitSegittal3(AxialFolderPath,ArrangedAxialImages, nameOfsagittalImagePath, startWidth, sliceThickness_in_Pixel, SagittalBlankImage_path);

                }
            }
            #endregion

            stopwatch.Stop();

            MessageBox.Show("Sagittal Generation Time in ms , Thread ID ,Loop Count ", stopwatch.ElapsedMilliseconds.ToString() + "," + ThreadID.ToString() + " " +
                (total_loop_count + 1).ToString());

            load++;

        }


        //? 9.32 am  13.08.2022
        /// <summary>
        /// From All(775) Axial take One Coloumn and Past it 2 times(Voxel Size)  in Sagittal   to get Complite 1 Sagittal- Image
        /// </summary>
        /// <param name="AxialFolderPath"></param>
        /// <param name="AxialimageArray"></param>
        /// <param name="outPutImageSaveingPath"></param>
        /// <param name="PixwidthStartPosi"></param>
        /// <param name="coloumnCount"></param>
        public void UnitSegittal3(string AxialFolderPath, List<string> AxialimageArray, string outPutImageSaveingPath, int PixwidthStartPosi, int coloumnCount, string SagittalBlankImage_path) // 
        {
            unsafe
            {
                #region For OutPut: Blank Image on which data will be write -- Sagittal  SetPixel()
                Bitmap outBitmap = new Bitmap(@"C:\Users\91993\Desktop\BlankSagittal.bmp");

                BitmapData bitmapDataOut = outBitmap.LockBits(new Rectangle(0, 0, outBitmap.Width, outBitmap.Height), ImageLockMode.ReadWrite, outBitmap.PixelFormat);
                int bytePerPixelOut = Bitmap.GetPixelFormatSize(outBitmap.PixelFormat) / 8;
                int heightInPixelsOut = bitmapDataOut.Height;
                // int widthInBytes = 512 * 4;
                int widthInBytesOut = bitmapDataOut.Width * bytePerPixelOut;
                byte* ptrFirstPixelOut = (byte*)bitmapDataOut.Scan0;
                #endregion

                for (int axi = 0; axi < 775; axi++)
                {
                    #region Input Image , from which Data will be Taken--- Axial  GetPixel()
                    Bitmap inputBitmap = new Bitmap(AxialFolderPath + bSlash + AxialimageArray[axi]);
                    BitmapData bitmapData = inputBitmap.LockBits(new Rectangle(0, 0, inputBitmap.Width, inputBitmap.Height), ImageLockMode.ReadWrite, inputBitmap.PixelFormat);
                    int bytePerPixel = Bitmap.GetPixelFormatSize(inputBitmap.PixelFormat) / 8;
                    int heightInPixels = bitmapData.Height;
                    // int widthInBytes = 512 * 4;
                    int widthInBytes = bitmapData.Width * bytePerPixel;
                    byte* ptrFirstPixel = (byte*)bitmapData.Scan0;
                    #endregion

                    //?  V voxel height in Pix
                    // Deepend on Voxel Row Height repeatly add Axial in Sagittal
                    for (int v = 0; v < 2; v++)
                    {
                        byte* writeLine_SetPixel = ptrFirstPixelOut + (axi * 2 + v) * bitmapDataOut.Stride;

                        //? Taking one Coloumn from Axial and pasting two time in Sagittal as Row
                        for (int w = 0; w < widthInBytesOut; w = w + bytePerPixel)
                        {
                            byte* currentLine_GetPixel = ptrFirstPixel + (w / 4) * bitmapData.Stride;
                            int oldBlue = currentLine_GetPixel[0 + PixwidthStartPosi * 4];
                            int oldGreen = currentLine_GetPixel[1 + PixwidthStartPosi * 4];
                            int oldRed = currentLine_GetPixel[2 + PixwidthStartPosi * 4];

                            writeLine_SetPixel[w + 0] = (byte)oldBlue;
                            writeLine_SetPixel[w + 1] = (byte)oldGreen;
                            writeLine_SetPixel[w + 2] = (byte)oldRed;
                            writeLine_SetPixel[w + 3] = 255;
                        }
                    }

                    inputBitmap.UnlockBits(bitmapData);
                }

                outBitmap.UnlockBits(bitmapDataOut);
                string path_Sagittal = @"C:\Users\91993\Desktop\SegittalImagesLockBitUnsafe\" + (PixwidthStartPosi/2).ToString() + ".bmp";
                outBitmap.Save(path_Sagittal);
            }
        }


    }

}
