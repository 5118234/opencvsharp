using System;

namespace OpenCvSharp
{
#if LANG_JP
    /// <summary>
    /// 
    /// </summary>
#else
    /// <summary>
    /// Robust method used to compute transformation
    /// </summary>
#endif
    public enum EstimateAffine2DMethod : int
    {
#if LANG_JP
        /// <summary>
        /// LMedS推定によるロバストな手法
        /// </summary>
#else
        /// <summary>
        /// Least-Median robust method
        /// </summary>
#endif
        LMedS = 4,


#if LANG_JP
        /// <summary>
        /// RANSACアルゴリズムに基づくロバストな手法
        /// </summary>
#else
        /// <summary>
        /// RANSAC-based robust method
        /// </summary>
#endif
        Ransac = 8,
    }
}
