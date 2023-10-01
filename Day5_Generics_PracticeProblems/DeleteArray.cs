using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Generics_PracticeProblems
{
    class DeleteArray
    {
        public static T[] DeleteMethod<T>(T[] array, T elementToDelete)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (EqualityComparer<T>.Default.Equals(array[i], elementToDelete))
                {
                    count++;
                }
                else if (count > 0)
                {
                    array[i - count] = array[i];
                }
            }

            T[] newArray = new T[array.Length - count];
            Array.Copy(array, newArray, newArray.Length);
            return newArray;
        }
    }
}
