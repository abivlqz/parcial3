using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;
using Parcial3._1;

namespace Parcial3._1.Cambiarlenguaje
{
    public static class Sort
    {
        int[] arr = { 12, 11, 13, 5, 6 };
        public static void Insertionsort(int[] arr)
        {

            int n = arr.Length;
            int i, key, j;
            for (i = 1; i < n; i++)
            {
                key = arr[i];
                j = i - 1;

                /* Move elements of arr[0..i-1], that are
                   greater than key, to one position ahead
                   of their current position */
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j -= 1;
                }
                arr[j + 1] = key;
                Console.WriteLine(key);
            }
        }
    }
}
