namespace Sagittal_from_byMThread_1108022.Axial_Bmp.mm_to_Pixel
{
    /// <summary>
    ///  Axial Slice Voxel thickness 
    /// </summary>
    public class Voxel_Thick
    {
        /// <summary>
        /// CT Scan type .
        /// </summary>
        public enum Scan_Types
        {
            Sprial,
            Axial

        }

        /// <summary>
        ///  Voxel Thickness in Pix
        /// </summary>
        /// <param name="Axial_sliceThick_pix"></param>
        /// <param name="scan"></param>
        /// <returns></returns>
        public int Thickness(int Axial_sliceThick_pix, Scan_Types scan)
        {
            int Axial_Voxel_Thick_pix = 0;

            if (scan == Scan_Types.Sprial)
            {
                Axial_Voxel_Thick_pix = Axial_sliceThick_pix / 2;
            }

            return Axial_Voxel_Thick_pix;
        }

    }

}
