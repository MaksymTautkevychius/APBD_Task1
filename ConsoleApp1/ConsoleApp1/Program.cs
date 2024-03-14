

namespace Main
{
    class Program
    {
         static int Avg(int[] vals)
         {
             int sum=0;
            for (int i = 0; i < vals.Length; i++)
            {
                sum += vals[i];
            }

            int avg = sum / vals.Length;
            return avg;
         }

         static int max(int[] vals)
         {
             int max = 0;
             for (int i = 0; i < vals.Length; i++)
             {
                 if (vals[i]>max)
                 {
                     max = vals[i];
                 }
             }

             return max;
         }
    }
}