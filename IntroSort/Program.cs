﻿using System;
using System.Collections;
using System.Linq;

namespace IntroSort
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] array = new int[] { 23, 12, 23, 235, 58398, 234, 89, 99, 90, 22, 1, 0, 3489, 123 };
            Console.WriteLine(string.Join(",", array));
            Sort.IntroSort.Sort(ref array);
            Console.WriteLine(string.Join(",", array));

            
        }
    }
}
