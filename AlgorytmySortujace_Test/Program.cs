using AlgorytmySortujace_Test.Logic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmySortujace_Test
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<int> Ascending, Descending, VShaped, AShaped, Constant, Random;
            generateData(out Ascending, out Descending, out VShaped, out AShaped, out Constant, out Random);

            //begin tests
            testSelectionSort(Ascending, Descending, VShaped, AShaped, Constant, Random);
            testInsertionSort(Ascending, Descending, VShaped, AShaped, Constant, Random);
            testMergeSort(Ascending, Descending, VShaped, AShaped, Constant, Random);
            testQuickSort(Ascending, Descending, VShaped, AShaped, Constant, Random);
            testSelectionSort(Ascending, Descending, VShaped, AShaped, Constant, Random);
            Console.ReadKey();
        }
        private static void testSelectionSort
            (List<int> Ascending, List<int> Descending, List<int> VShaped, List<int> AShaped, List<int> Constant, List<int> Random)
        {
            Stopwatch ascendingWatch = new Stopwatch();
            Stopwatch descendingWatch = new Stopwatch();
            Stopwatch vShapedWatch = new Stopwatch();
            Stopwatch aShapedWatch = new Stopwatch();
            Stopwatch constantWatch = new Stopwatch();
            Stopwatch randomWatch = new Stopwatch();

            ascendingWatch.Start();
            SelectionSort.Sort(Ascending);
            ascendingWatch.Stop();
            descendingWatch.Start();
            SelectionSort.Sort(Descending);
            descendingWatch.Stop();
            vShapedWatch.Start();
            SelectionSort.Sort(VShaped);
            vShapedWatch.Stop();
            aShapedWatch.Start();
            SelectionSort.Sort(AShaped);
            aShapedWatch.Stop();
            constantWatch.Start();
            SelectionSort.Sort(Constant);
            constantWatch.Stop();
            randomWatch.Start();
            SelectionSort.Sort(Random);
            randomWatch.Stop();

            string komunikat = $"SelectionSort:\n{(decimal)ascendingWatch.ElapsedTicks / 10000}\n{(decimal)descendingWatch.ElapsedTicks / 10000}\n{(decimal)vShapedWatch.ElapsedTicks / 10000}\n{(decimal)aShapedWatch.ElapsedTicks / 10000}\n{(decimal)constantWatch.ElapsedTicks / 10000}\n{(decimal)randomWatch.ElapsedTicks / 10000}\n";
            Console.WriteLine(komunikat);
        }
        private static void testInsertionSort
            (List<int> Ascending, List<int> Descending, List<int> VShaped, List<int> AShaped, List<int> Constant, List<int> Random)
        {
            Stopwatch ascendingWatch = new Stopwatch();
            Stopwatch descendingWatch = new Stopwatch();
            Stopwatch vShapedWatch = new Stopwatch();
            Stopwatch aShapedWatch = new Stopwatch();
            Stopwatch constantWatch = new Stopwatch();
            Stopwatch randomWatch = new Stopwatch();

            ascendingWatch.Start();
            InsertionSort.Sort(Ascending);
            ascendingWatch.Stop();
            descendingWatch.Start();
            InsertionSort.Sort(Descending);
            descendingWatch.Stop();
            vShapedWatch.Start();
            InsertionSort.Sort(VShaped);
            vShapedWatch.Stop();
            aShapedWatch.Start();
            InsertionSort.Sort(AShaped);
            aShapedWatch.Stop();
            constantWatch.Start();
            InsertionSort.Sort(Constant);
            constantWatch.Stop();
            randomWatch.Start();
            InsertionSort.Sort(Random);
            randomWatch.Stop();

            string komunikat = $"InsertionSort:\n{(decimal)ascendingWatch.ElapsedTicks / 10000}\n{(decimal)descendingWatch.ElapsedTicks / 10000}\n{(decimal)vShapedWatch.ElapsedTicks / 10000}\n{(decimal)aShapedWatch.ElapsedTicks / 10000}\n{(decimal)constantWatch.ElapsedTicks / 10000}\n{(decimal)randomWatch.ElapsedTicks / 10000}\n";
            Console.WriteLine(komunikat);
        }
        private static void testMergeSort
            (List<int> Ascending, List<int> Descending, List<int> VShaped, List<int> AShaped, List<int> Constant, List<int> Random)
        {
            Stopwatch ascendingWatch = new Stopwatch();
            Stopwatch descendingWatch = new Stopwatch();
            Stopwatch vShapedWatch = new Stopwatch();
            Stopwatch aShapedWatch = new Stopwatch();
            Stopwatch constantWatch = new Stopwatch();
            Stopwatch randomWatch = new Stopwatch();

            ascendingWatch.Start();
            MergeSort.Sort(Ascending);
            ascendingWatch.Stop();
            descendingWatch.Start();
            MergeSort.Sort(Descending);
            descendingWatch.Stop();
            vShapedWatch.Start();
            MergeSort.Sort(VShaped);
            vShapedWatch.Stop();
            aShapedWatch.Start();
            MergeSort.Sort(AShaped);
            aShapedWatch.Stop();
            constantWatch.Start();
            MergeSort.Sort(Constant);
            constantWatch.Stop();
            randomWatch.Start();
            MergeSort.Sort(Random);
            randomWatch.Stop();

            string komunikat = $"MergeSort:\n{(decimal)ascendingWatch.ElapsedTicks / 10000}\n{(decimal)descendingWatch.ElapsedTicks / 10000}\n{(decimal)vShapedWatch.ElapsedTicks / 10000}\n{(decimal)aShapedWatch.ElapsedTicks / 10000}\n{(decimal)constantWatch.ElapsedTicks / 10000}\n{(decimal)randomWatch.ElapsedTicks / 10000}\n";
            Console.WriteLine(komunikat);
        }
        private static void testQuickSort
            (List<int> Ascending, List<int> Descending, List<int> VShaped, List<int> AShaped, List<int> Constant, List<int> Random)
        {
            Stopwatch ascendingWatch = new Stopwatch();
            Stopwatch descendingWatch = new Stopwatch();
            Stopwatch vShapedWatch = new Stopwatch();
            Stopwatch aShapedWatch = new Stopwatch();
            Stopwatch constantWatch = new Stopwatch();
            Stopwatch randomWatch = new Stopwatch();

            ascendingWatch.Start();
            QuickSort.Sort(Ascending);
            ascendingWatch.Stop();
            descendingWatch.Start();
            QuickSort.Sort(Descending);
            descendingWatch.Stop();
            vShapedWatch.Start();
            QuickSort.Sort(VShaped);
            vShapedWatch.Stop();
            aShapedWatch.Start();
            QuickSort.Sort(AShaped);
            aShapedWatch.Stop();
            constantWatch.Start();
            QuickSort.Sort(Constant);
            constantWatch.Stop();
            randomWatch.Start();
            QuickSort.Sort(Random);
            randomWatch.Stop();

            string komunikat = $"QuickSort:\n{(decimal)ascendingWatch.ElapsedTicks / 10000}\n{(decimal)descendingWatch.ElapsedTicks / 10000}\n{(decimal)vShapedWatch.ElapsedTicks / 10000}\n{(decimal)aShapedWatch.ElapsedTicks / 10000}\n{(decimal)constantWatch.ElapsedTicks / 10000}\n{(decimal)randomWatch.ElapsedTicks / 10000}\n";
            Console.WriteLine(komunikat);
        }
        private static void testShellSort
            (List<int> Ascending, List<int> Descending, List<int> VShaped, List<int> AShaped, List<int> Constant, List<int> Random)
        {
            Stopwatch ascendingWatch = new Stopwatch();
            Stopwatch descendingWatch = new Stopwatch();
            Stopwatch vShapedWatch = new Stopwatch();
            Stopwatch aShapedWatch = new Stopwatch();
            Stopwatch constantWatch = new Stopwatch();
            Stopwatch randomWatch = new Stopwatch();

            ascendingWatch.Start();
            ShellSort.Sort(Ascending);
            ascendingWatch.Stop();
            descendingWatch.Start();
            ShellSort.Sort(Descending);
            descendingWatch.Stop();
            vShapedWatch.Start();
            ShellSort.Sort(VShaped);
            vShapedWatch.Stop();
            aShapedWatch.Start();
            ShellSort.Sort(AShaped);
            aShapedWatch.Stop();
            constantWatch.Start();
            ShellSort.Sort(Constant);
            constantWatch.Stop();
            randomWatch.Start();
            ShellSort.Sort(Random);
            randomWatch.Stop();

            string komunikat = $"ShellSort:\n{(decimal)ascendingWatch.ElapsedTicks / 10000}\n{(decimal)descendingWatch.ElapsedTicks / 10000}\n{(decimal)vShapedWatch.ElapsedTicks / 10000}\n{(decimal)aShapedWatch.ElapsedTicks / 10000}\n{(decimal)constantWatch.ElapsedTicks / 10000}\n{(decimal)randomWatch.ElapsedTicks / 10000}\n";
            Console.WriteLine(komunikat);
        }
        private static void generateData
            (out List<int> Ascending, out List<int> Descending, out List<int> VShaped, out List<int> AShaped, out List<int> Constant, out List<int> Random)
        {
            // test parameters
            int size = 1000; // ilosc kluczy ktora ma zostac dodana dla kazdej z list
            int keyRange = 10000; // gorny zakres ktory moze przyjac wygenerowany klucz
            Random rand = new Random();

            // test data lists
            Ascending = new List<int>();
            Descending = new List<int>();
            VShaped = new List<int>();
            AShaped = new List<int>();
            Constant = new List<int>();
            Random = new List<int>();

            // wylosuj liczbe dla listy Constant
            int constantInt = rand.Next(keyRange);
            // dodaj dane do list
            for (int i = 0; i < size; i++)
            {
                // ascending
                Ascending.Add(i);
                // descending
                Descending.Add(size - i - 1);
                // constant
                Constant.Add(constantInt);
                // random
                Random.Add(rand.Next(keyRange));
            }
            for (int i = size / 2; i > 0; i--)
            {
                // v-shaped 1st half
                VShaped.Add(i);
                // a-shaped 1st half
                AShaped.Add((i - (size / 2)) * (-1));
            }
            for (int i = 0; i < size / 2; i++)
            {
                // v-shaped 2nd half
                VShaped.Add(i);
                // a-shaped 2nd half
                AShaped.Add((i - (size / 2)) * (-1));
            }
        }
    }
}
