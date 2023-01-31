using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sagittal_from_byMThread_1108022.Axial_Bmp.mm_to_Pixel
{
    /// <summary>
    /// Convert mm to Pixel , pixels = millimeters * (PPI / 25.4) .
    ///  Keeping PPI  96
    /// </summary>
    public class mm_to_Pixel
    {
        public double ppi_of_system = 0;
        public double input = 0;
        public mm_to_Pixel(double input_mm)
        {
            Get_Display_PPI get_Display_PPI = new Get_Display_PPI();
            float[] Dpi = get_Display_PPI.GetPPi();
            ppi_of_system = Dpi[0];

            input = input_mm;
        }



        public double GetValue_inDouble()
        {
            //? pixels = millimeters * (PPI / 25.4)
            // PPI =Pixel Per Inch 
            // 1 inch =25.4 mm
            double mm_to_Pix_conversion = input * (ppi_of_system / 25.4);
            return mm_to_Pix_conversion;
        }

        public int GetValue_inInt()
        {
            //? pixels = millimeters * (PPI / 25.4)
            // PPI =Pixel Per Inch ,      // 1 inch =25.4 mm
            int mm_to_Pix_conversion = (int)Math.Round(input * (ppi_of_system / 25.4));
            return mm_to_Pix_conversion;
        }


        public int GetValue_inInt_96ppi()
        {
            //? pixels = millimeters * (PPI / 25.4)
            // PPI =Pixel Per Inch ,      // 1 inch =25.4 mm
            int mm_to_Pix_conversion = (int)Math.Round(input * (96 / 25.4));
            return mm_to_Pix_conversion;
        }

    }
}
