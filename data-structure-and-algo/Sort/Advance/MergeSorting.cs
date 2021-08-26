namespace data_structure_and_algo.Sort.Advance
{
    class MergeSorting
    {
        private static void Merge(int[] arr, int start, int middle, int end)
        {
            int i,j;
            int left = middle - start + 1;
            int right = end - middle;

            int[] leftArr = new int[left];
            int[] rightArr = new int[right];

            for(i =0; i < left; i++)
                leftArr[i] = arr[start + i];

            for (j = 0; j < right; j++)
                rightArr[j] = arr[middle + 1 + j];

            i = 0;
            j = 0;
            int x = start;

            while ((i < left) && (j < right))
            {
                if (leftArr[i] <= rightArr[j])
                {
                    arr[x] = leftArr[i];
                    i++;
                }
                else
                {
                    arr[x] = rightArr[j];
                    j++;
                }
                x++;
            }

            while (i < left)
            {
                arr[x] = leftArr[i];
                i++;
                x++;
            }

            while (j < right)
            {
                arr[x] = rightArr[j];
                j++;
                x++;
            }
        }

        public static void MergeSort(int[] arr, int start, int end)
        {
            if(start < end)
            {
                int middle = (start + end) / 2;
                MergeSort(arr, start, middle);
                MergeSort(arr, (middle+1), end);
                Merge(arr, start, middle, end);
            }
        }
    }
}
