using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmySortujace_Test.Logic
{
    public static class InsertionSort
    {
        public static List<int> Sort(List<int> keys)
        {
            for (int index = 1; index < keys.Count; index++)
            {
                int currentKey = keys[index];
                int prevIndex = index - 1;

                while (prevIndex >= 0 && keys[prevIndex] > currentKey)
                {
                    keys[prevIndex + 1] = keys[prevIndex];
                    prevIndex--;
                }

                keys[prevIndex + 1] = currentKey;
            }
            return keys;
        }
    }
}
