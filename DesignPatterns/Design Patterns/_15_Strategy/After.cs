﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _15_Strategy
{
    public class After
    {
        public static void Run()
        {
            const int k_Len = 10;
            int[] array = new int[k_Len];
            Random rand = new Random();
            for (int i = 0; i < k_Len; i++)
            {
                array[i] = rand.Next(10);
                Console.Write(array[i].ToString() + " ");
            }

            Console.WriteLine();

            Sorter sorter = new Sorter(new UpComparer());

            sorter.Sort(array);
            for (int u = 0; u < k_Len; u++)
            {
                Console.Write(array[u].ToString() + " ");
            }
            Console.WriteLine();

            sorter.Comparer = new DownComparer();
            for (int u = 0; u < k_Len; u++)
            {
                Console.Write(array[u].ToString() + " ");
            }
            Console.WriteLine();
        }

        public class Sorter
        {
            ///  My strategy
            public IComparer Comparer { get; set; }

            public Sorter(IComparer i_Comparer)
            {
                Comparer = i_Comparer;
            }

            public void Sort(int[] i_Array)
            {
                for (int g = i_Array.Length / 2; g > 0; g /= 2)
                {
                    for (int i = g; i < i_Array.Length; i++)
                    {
                        for (int j = i - g; j >= 0; j -= g)
                        {
                            if (Comparer.ShouldSwap(i_Array[j], i_Array[j + g]))
                            {
                                doSwap(ref i_Array[j], ref i_Array[j + g]);
                            }
                        }
                    }
                }
            }

            private void doSwap(ref int io_Num1, ref int io_Num2)
            {
                int temp = io_Num1;
                io_Num1 = io_Num2;
                io_Num2 = temp;
            }
        }

        /// the strategy interface
        public interface IComparer
        {
            bool ShouldSwap(int i_Num1, int i_Num2);
        }

        /// a strategy implementation
        public class DownComparer : IComparer
        {
            public bool ShouldSwap(int i_Num1, int i_Num2)
            {
                return i_Num1 > i_Num2;
            }
        }

        /// another strategy implementation
        public class UpComparer : IComparer
        {
            public bool ShouldSwap(int i_Num1, int i_Num2)
            {
                return i_Num1 < i_Num2;
            }
        }
    }
}
