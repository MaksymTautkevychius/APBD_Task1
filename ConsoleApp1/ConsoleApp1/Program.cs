

namespace Main
{
    class Program
    {
         static int Avg(int[] vals)
         {
             int suma=0;
            for (int i = 0; i < vals.Length; i++)
            {
                suma += vals[i];
            }

<<<<<<< HEAD
            int avgard = sum / vals.Length;
            return avgard;
=======
            int avg = suma / vals.Length;
            return avg;
>>>>>>> feature-new
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