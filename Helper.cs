using System;
using System.Collections.Generic;
using System.Linq;

namespace ProcessingEngine.Algorithm
{
    public static class Helper
    {
        /// <summary>
        /// Copies a time series represented as dictionary in a simple array
        /// </summary>
        /// <param name="pDic">Original dictionary</param>
        /// <returns>Array</returns>
        public static double[] Dictionary2Array(Dictionary<DateTime, double> pDic)
        {
            int num = pDic.Count;
            double[] res = new double[num];
            int i = 0;
            foreach (KeyValuePair<DateTime, double> entry in pDic)
            {
                res[i] = entry.Value;
                i++;
            }
            return res;
        }

        /// <summary>
        /// Copies a simple array in a Dictionary representing a time series.
        /// </summary>
        /// <param name="dArr">original simple array</param>
        /// <param name="pDicSample">dictionary which is used to grap the timestamps, e.g. the original input dictionary</param>
        /// <returns>Dictionary as time series</returns>
        public static Dictionary<DateTime, double> Array2Dictionary(double[] dArr, Dictionary<DateTime, double> pDicSample)
        {
            if (dArr.Length != pDicSample.Count)
            {
                throw new InvalidOperationException("Both Parameters dArr and pDicSample need to have the same size.");
            }
            else
            {
                Dictionary<DateTime, double> res = new Dictionary<DateTime, double>();
                for (int i = 0; i < dArr.Length; i++)
                {
                    res.Add(pDicSample.ToList<KeyValuePair<DateTime, double>>()[i].Key, dArr[i]);
                }
                return res;
            }
        }
    }
}
