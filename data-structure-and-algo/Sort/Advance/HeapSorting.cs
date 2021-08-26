namespace data_structure_and_algo.Sort.Advance
{
    class HeapSorting
    {

        // Has a Time and Space complexity of O(log N)
        // where log N pertains to the height of the tree
        public static void Heapify(int[] arr, int i, int size)
        {
            int left = 2 * i;
            int right = (2 * i) + 1;
            int largest = i;

            if ((left < size) && (arr[left] > arr[i]))
                largest = left;

            if ((right < size) && (arr[right] > arr[largest]))
                largest = right;

            if (largest != i)
            {
                int temp = arr[i];
                arr[i] = arr[largest];
                arr[largest] = temp;
                Heapify(arr, largest, size);
            }
        }

        // Has a time complexity of O(n/2) which is simply O(N)
        // However, since it contains Heapify function which
        // operates on time complexity of O(log N),
        // then, the overall time complexity is O(N log N)
        // that can be summed up to O(N)
        // On the other hand, space complexity remains as O(log N)
        // as the number of variables used does not increased based on the
        // number of steps it is evaluated upon.
        public static void BuildMaxHeap(int[] arr)
        {
            // start on (heap size / 2) - 1
            // since it contains the values which are internal nodes
            // meaning, root or parent nodes
            for (int i = (arr.Length/2)-1; i >= 0; i--)
            {
                Heapify(arr, i, (arr.Length));
            }
        }

        // Time Complexity is O(N log N)
        // Space Complexity is O(log N)
        public static void HeapSort(int[] arr)
        {
            // Time Complexity is O(N)
            BuildMaxHeap(arr);

            // Time Complexity is O(N)
            for (int i = arr.Length - 1; i > 0; i--)
            {
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;
                // Time Complexity is O(log N)
                Heapify(arr, 0, i);
            }
        }
    }
}
