using System;

namespace csharp_binary_search
{
    class Program
    {
        static void find_num(int[] arr, int target)
        {
            int first = 0, last = arr.Length - 1, mid = 0;
            
            while (first <= last)
            {
                mid = (first + last) / 2;
                if (target > arr[mid])
                    first = mid + 1;
                else
                    if (target < arr[mid])
                        last = mid - 1;
                    else
                        first = last + 1;
            }
        }
        static void Main(string[] args)
        {
            
        }
    }
}
