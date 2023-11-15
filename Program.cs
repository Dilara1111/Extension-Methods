using System;

namespace Task_14._11._23
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[0];
            arr = arr.Add(1);
            arr = arr.Add(2);
            arr = arr.Add(3);
            arr = arr.Add(4);
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            Console.WriteLine(sum);
        }
        
    }
    static class Extention
    {
        public static int[] Add(this int[] arr, int item)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = item;
            return arr;
        }
    }
}


