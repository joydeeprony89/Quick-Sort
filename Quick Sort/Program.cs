using System;
using System.Buffers;

namespace Quick_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 9, 7, 5, 3, 10, 6 };
            Sort(arr, 0, arr.Length - 1);
            foreach (int i in arr) Console.WriteLine(i);
        }

        static void Sort(int[] arr, int l , int r)
        {
            if(l < r)
            {
                int partition = Partition(arr, l, r);
                Sort(arr, l, partition - 1);
                Sort(arr, partition + 1, r);
            }
        }

        static int Partition(int[] arr, int l , int r)
        {
            int pivot = arr[r];
            int i = l -1;
            for (int j = l; j <= r-1; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }

            Swap(arr, i+1, r);
            return i+1;
        }
        static void Swap(int[] arr, int i , int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
