using System;
namespace BinarySearch.Search
{
    public static class BinarySearch
    {
        public static object SearchIterative(object[] inputArray, object key)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                {
                    return ++mid;
                }
                else if ((int)key < (int)inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }

            }
            return "Nil";
        }

        public static object SearchRecursive(int[] inputArray, int key, int min, int max)
        {
            if (min > max)
            {
                return "Nil";
            }
            else
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                {
                    return ++mid;
                }
                else if (key < inputArray[mid])
                {
                    return SearchRecursive(inputArray, key, min, mid - 1);
                }
                else
                {
                    return SearchRecursive(inputArray, key, mid + 1, max);
                }
            }
        }
    }
}
