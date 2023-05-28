using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmySortujace_Test.Logic
{
    public static class MergeSort
    {
        public static void Sort(List<int> keys)
        {
            if (keys.Count <= 1)
                return;

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int middle = keys.Count / 2;

            for (int index = 0; index < middle; index++)
                left.Add(keys[index]);
            for (int index = middle; index < keys.Count; index++)
                right.Add(keys[index]);

            Sort(left);
            Sort(right);

            Merge(keys, left, right);
        }

        public static void Merge(List<int> merged, List<int> left, List<int> right)
        {
            int leftIndex = 0;
            int rightIndex = 0;
            int mergedIndex = 0;

            while (leftIndex < left.Count && rightIndex < right.Count)
            {
                if (left[leftIndex] <= right[rightIndex])
                {
                    merged[mergedIndex] = left[leftIndex];
                    leftIndex++;
                }
                else
                {
                    merged[mergedIndex] = right[rightIndex];
                    rightIndex++;
                }
                mergedIndex++;
            }

            while (leftIndex < left.Count)
            {
                merged[mergedIndex] = left[leftIndex];
                leftIndex++;
                mergedIndex++;
            }

            while (rightIndex < right.Count)
            {
                merged[mergedIndex] = right[rightIndex];
                rightIndex++;
                mergedIndex++;
            }
        }
    }
}
