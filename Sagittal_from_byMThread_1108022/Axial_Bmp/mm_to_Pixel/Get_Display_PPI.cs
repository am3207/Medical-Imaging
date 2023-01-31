using System;
using System.Drawing;

namespace Sagittal_from_byMThread_1108022.Axial_Bmp.mm_to_Pixel
{
    public class Get_Display_PPI
    {
        public float[] GetPPi()
        {
            using (Graphics graphics = Graphics.FromHwnd(IntPtr.Zero))
            {
                float dpiX = graphics.DpiX;
                float dpiY = graphics.DpiY;
                float[] result = new float[] { dpiX = dpiX, dpiY = dpiY };
                return result;
            }
        }

    }
}
