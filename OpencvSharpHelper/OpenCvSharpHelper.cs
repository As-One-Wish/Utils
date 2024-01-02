using Emgu.CV;
using System.Drawing;

namespace Units_OpenCvSharp
{
    public class OpenCvSharpHelper
    {
        #region Mat 转化

        /// <summary>
        /// Emgu.CV.Mat 转化为 OpenCvSharp.Mat
        /// </summary>
        /// <param name="emguImage"></param>
        /// <returns></returns>
        public OpenCvSharp.Mat ConvertEmguCVImageToOpenCvSharpMat(Mat emguImage)
        {
            // 将 EmguCV Image 转换为 Bitmap
            Bitmap bitmap = emguImage.ToBitmap();

            // 创建 OpenCvSharp Mat 对象并将 Bitmap 数据复制到其中
            OpenCvSharp.Mat openCvSharpMat = OpenCvSharp.Extensions.BitmapConverter.ToMat(bitmap);

            return openCvSharpMat;
        }

        #endregion Mat 转化
    }
}