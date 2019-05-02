using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial3_P2.Clases
{
    class GenericClass
    {
        public static void insertionSort<T>(T[] array, int n) where T : IComparable
        {
            int i, j;
            T key;
            for (i = 1; i < n; i++)
            {
                key = array[i];
                j = i - 1;

                /* Move elements of arr[0..i-1], that are
                   greater than key, to one position ahead
                   of their current position */

                while (j >= 0 && array[j].CompareTo(key) > 0)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = key;
            }
        }
    }
}
