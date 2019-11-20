using System;
using System.Collections.Generic;
using CollectionExtendLib;

namespace ShowCase
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestGenericLists();
            TestGenericArrays();
        }

        private static void TestGenericLists()
        {
            List<double> list = new List<double>() { 1, 2.5, 3, 4.5, 5 };
            List<double> list2 = new List<double>();
            List<double> list3 = new List<double>() { 1, 2.2, 2.2, 4, 4, 3.9 };

            PrintCycleGenericList(list);
            PrintCycleGenericList(list2);
            PrintCycleGenericList(list3);
        }
        private static void TestGenericArrays()
        {
            double[] array = new double[] { 1, 2.5, 3, 4.5, 5 };
            double[] array2 = new double[0];
            double[] array3 = new double[] { 1, 2.2, 2.2, 4, 4, 3.9 };

            PrintCycleGenericArray(array);
            PrintCycleGenericArray(array2);
            PrintCycleGenericArray(array3);
        }

        private static void TestAllTypes()
        {
            CheckGenericType("bool", new List<bool>());

            // Signed integral
            CheckGenericType("sbyte", new List<sbyte>());
            CheckGenericType("short", new List<short>());
            CheckGenericType("int", new List<int>());
            CheckGenericType("long", new List<long>());

            // Unsigned integral
            CheckGenericType("byte", new List<byte>());
            CheckGenericType("ushort", new List<ushort>());
            CheckGenericType("uint", new List<uint>());
            CheckGenericType("ulong", new List<ulong>());

            // IEEE binary floating-point
            CheckGenericType("float", new List<float>());
            CheckGenericType("double", new List<double>());

            // High-precision decimal floating-point
            CheckGenericType("decimal", new List<float>());

            // Unicode character
            CheckGenericType("char", new List<char>());
        }

        private static void CheckGenericType<T>(string name, List<T> list)
        {
            Console.WriteLine(name + " type is " + typeof(T));
            Console.WriteLine(ListLibrary.IsNumber<T>());
        }

        private static void PrintCycleGenericList<T>(List<T> list)
        {
            Console.WriteLine("List contains: " + list.Stringify());
            Console.WriteLine("Max: " + list.Max());
            Console.WriteLine("Min: " + list.Min());
            Console.WriteLine("Average: " + list.Average());
            if (list.Count > 0)
            {
                Console.WriteLine("CountNumber("+ list[0] + "): " + list.CountValue(list[0]));
            }            
            Console.WriteLine("Amount of duplicates: " + list.CountDuplicates());
            Console.WriteLine("List without duplicates: " + list.CopyWithoutDuplicates().Stringify());
            Console.WriteLine("[After CopyWithoutDuplicates()] List contains: " + list.Stringify());
            list.RemoveDuplicates();
            Console.WriteLine("[After RemoveDuplicates()] List contains: " + list.Stringify());
            if (list.Count > 0)
            {
                list.Append(4, list[0]);
                Console.WriteLine("[After Append(4, " + list[0] + ")] List contains: " + list.Stringify());
                list.Fill(3, list[0]);
                Console.WriteLine("[After Fill(3," + list[0] + ")] List contains: " + list.Stringify());
            }            
            Console.WriteLine("");
        }

        private static void PrintCycleGenericArray<T>(T[] array)
        {
            Console.WriteLine("array contains: " + array.Stringify());
            Console.WriteLine("Max: " + array.Max());
            Console.WriteLine("Min: " + array.Min());
            Console.WriteLine("Average: " + array.Average());
            if (array.Length > 0)
            {
                Console.WriteLine("CountNumber([value=]" + array[0] + "): " + array.CountValue(array[0]));
            }
            Console.WriteLine("Amount of duplicates: " + array.CountDuplicates());
            Console.WriteLine("array without duplicates: " + array.CopyWithoutDuplicates().Stringify());
            Console.WriteLine("[After CopyWithoutDuplicates()] array contains: " + array.Stringify());
            if (array.Length > 0)
            {
                array.Insert(1, 2, array[0]);
                Console.WriteLine("[After Insert([position=]1, [count=]2, [value=]" + array[0] + ")] array contains: " + array.Stringify());
                array.Fill(array[0]);
                Console.WriteLine("[After Fill([value=]" + array[0] + ")] array contains: " + array.Stringify());
            }
            Console.WriteLine("");
        }
    }
}
