using System;
using System.Collections.Generic;
using UtilityLibraries;

namespace ShowCase
{
    class Program
    {
        static void Main(string[] args)
        {
            TestGenericLists();
        }

        private static void TestGenericLists()
        {
            List<double> list = new List<double>() { 1, 2.5, 3, 4.5, 5 };
            List<double> list2 = new List<double>();
            List<double> list3 = new List<double>() { 1, 2.2, 2.2, 4, 4, 3.9 };

            PrintCycleGeneric(list);
            PrintCycleGeneric(list2);
            PrintCycleGeneric(list3);
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

        private static void PrintCycleGeneric<T>(List<T> list)
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
    }
}
