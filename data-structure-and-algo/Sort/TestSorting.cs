using data_structure_and_algo.Sort.Advance;
using System;

namespace data_structure_and_algo.Sort
{
    class TestSorting
    {
        public static void Test()
        {
            int[] arr = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            Console.WriteLine("\nMerge Sort");
            Console.WriteLine("Before Array: [ {0} ]", string.Join(" ,", arr));
            MergeSorting.MergeSort(arr, 0 , 9-1);
            Console.WriteLine("After Array: [ {0} ]", string.Join(" ,", arr));


            int[] qarr = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            Console.WriteLine("\nQuick Sort");
            Console.WriteLine("Before Array: [ {0} ]", string.Join(" ,", qarr));
            QuickSorting.QuickSort(qarr, 0, 9 - 1);
            Console.WriteLine("After Array: [ {0} ]", string.Join(" ,", qarr));
        }
    }
}
