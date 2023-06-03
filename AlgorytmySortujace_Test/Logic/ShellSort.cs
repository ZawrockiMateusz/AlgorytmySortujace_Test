using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmySortujace_Test.Logic
{
    public static class ShellSort
    {
        public static List<int> Sort(List<int> keys)
        {
            int gap = keys.Count / 2;
            while (gap > 0)
            {
                for (int index = gap; index < keys.Count; index++)
                {
                    int keyCashe = keys[index];
                    int indexHelper = index;
                    while (indexHelper >= gap && keys[indexHelper - gap] > keyCashe)
                    {
                        keys[indexHelper] = keys[indexHelper - gap];
                        indexHelper -= gap;
                    }
                    keys[indexHelper] = keyCashe;
                }
                gap /= 2;
            }
            return keys;
        }
    }
}
