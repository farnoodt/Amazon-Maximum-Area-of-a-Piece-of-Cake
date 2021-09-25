using System;
using System.Collections.Generic;
using System.Linq;

namespace Amazon_Maximum_Area_of_a_Piece_of_Cake
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] h = new int[] { 2 };
            int[] v = new int[] { 2};
            Console.WriteLine(StorageOptimization(h,v, 1000000000, 1000000000));
        }

        static int StorageOptimization(int[] H,int[] V, int W, int D)
        {
            List<int> LH = new List<int>();
            List<int> LV = new List<int>();
            int Hlen = H.Length;
            int VLent = V.Length;
            if (Hlen == 0 && VLent == 0)
                return W * D;
            Array.Sort(H);
            Array.Sort(V);

            FillList(H, LH, W);
            FillList(V, LV, D);

            return (int)((long)LH.Max() * LV.Max() % 1000000007);

        }

       
        static void FillList(int[] arr, List<int> L, int Max)
        {
            int len = arr.Length;
            for (int i = 0; i < len; i++)
            {

                
                if (i == 0)
                    L.Add(arr[i]);
                else
                    L.Add(arr[i] - arr[i - 1]);

                if (i == len - 1)
                {
                    
                    L.Add(Max - arr[i]);
                }
                
            }
        }
    }
}
