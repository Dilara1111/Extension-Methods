using System;

namespace Task_14._11._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr = new int[] {1,2,3,4 };
            //arr = arr.Add(1);
            //arr = arr.Add(2);
            //arr = arr.Add(3);
            //arr = arr.Add(4);
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            Console.WriteLine(sum);
        }
        static int Add(int value)
        {
            //arr = new int[value];
            return value;
        }
    }
}
