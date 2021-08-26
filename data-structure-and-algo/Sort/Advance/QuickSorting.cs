using System.Text.RegularExpressions;

namespace data_structure_and_algo.Sort.Advance
{
    class QuickSorting
    {
        private static int Partition(int[]arr, int start, int end)
        {
            int pivot = arr[end];
            int i = start;
            int temp;
            for (int j=start; j < end; j++)
            {
                if(arr[j] <= pivot)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                }

            }
            arr[end] = arr[i];
            arr[i] = pivot;
            return i;
        }

        public static void QuickSort(int[] arr, int start, int end)
        {
            if(start < end)
            {
                int pivot = Partition(arr, start, end);
                QuickSort(arr, start, pivot-1);
                QuickSort(arr, pivot+1, end);
            }
        }
    }
}
