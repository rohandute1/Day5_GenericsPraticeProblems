using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Generics_PracticeProblems
{
    class DeleteArray
    {
        public static int[] DeleteMethod(int[] array, int elementToDelete)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == elementToDelete)
                {
                    count++;
                }
                else if (count > 0)
                {
                    array[i - count] = array[i];
                }
            }
            int[] newArray = new int[array.Length - count];
            Array.Copy(array, newArray, newArray.Length);
            return newArray;
        }

        public static double[] DeleteMethod(double[] array, double elementToDelete)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == elementToDelete)
                {
                    count++;
                }
                else if (count > 0)
                {
                    array[i - count] = array[i];
                }
            }

            double[] newArray = new double[array.Length - count];
            Array.Copy(array, newArray, newArray.Length);
            return newArray;
        }

        public static char[] DeleteMethod(char[] array, char elementToDelete)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == elementToDelete)
                {
                    count++;
                }
                else if (count > 0)
                {
                    array[i - count] = array[i];
                }
            }

            char[] newArray = new char[array.Length - count];
            Array.Copy(array, newArray, newArray.Length);
            return newArray;
        }
    }
}
