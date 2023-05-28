using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmySortujace_Test.Logic
{
    public static class QuickSort
    {
        public static void Sort(List<int> keys)
        {
            Sort(keys, 0, keys.Count - 1);
        }

        public static void Sort(List<int> keys, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(keys, low, high);
                Sort(keys, low, pivotIndex - 1);
                Sort(keys, pivotIndex + 1, high);
            }
        }

        public static int Partition(List<int> keys, int low, int high)
        {
            int pivot = keys[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (keys[j] < pivot)
                {
                    i++;
                    (keys[i], keys[j]) = (keys[j], keys[i]);
                }
            }
            (keys[i + 1], keys[high]) = (keys[high], keys[i + 1]);
            return i + 1;
        }
    }
}
