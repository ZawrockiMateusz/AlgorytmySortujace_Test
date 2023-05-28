using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmySortujace_Test.Logic
{
    public class SelectionSort
    {
        public static List<int> Sort(List<int> keys)
        {
            for (int index = 0; index < (keys.Count - 1); index++)
            {
                int minIndex = index;

                //znajdź najmniejszy index w liście
                for (int nextIndex = index + 1; nextIndex < keys.Count; nextIndex++)
                    if (keys[nextIndex] < keys[minIndex])
                        minIndex = nextIndex;

                (keys[minIndex], keys[index]) = (keys[index], keys[minIndex]);
            }
            return keys;
        }
    }
}
