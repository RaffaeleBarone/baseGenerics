using System;

namespace baseGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, };
            double[] doubleArray = { 1.0, 2.0, 3.0 };
            string[] stringArray = { "1", "2", "3" };

            MostraElementi(intArray);
            MostraElementi(doubleArray);
            MostraElementi(stringArray);

            Console.ReadKey();
        }

        //public static void MostraElementi(int[] array)
        //{
        //    foreach (int item in array)
        //    {
        //        Console.WriteLine(item + " ");
        //    }
        //}

        //public static void MostraElementi(double[] array)
        //{
        //    foreach (double item in array)
        //    {
        //        Console.WriteLine(item + " ");
        //    }
        //}

        //public static void MostraElementi(string[] array)
        //{
        //    foreach (string item in array)
        //    {
        //        Console.WriteLine(item + " ");
        //    }
        //}

        public static void MostraElementi<T>(T[] array)
        {
            foreach (T item in array)
            {
                Console.WriteLine(item + " ");
            }
        }
    }
}
