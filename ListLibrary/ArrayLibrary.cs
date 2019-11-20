using System;
using System.Collections.Generic;
using System.Text;

namespace UtilityLibraries
{
    public static class ArrayLibrary
    {
        public static bool IsNumber<T>()
        {
            string typeName = typeof(T).FullName;
            switch (typeName)
            {
                case "System.SByte":    //sbyte
                case "System.Byte":     //byte
                case "System.Int16":    //short
                case "System.UInt16":   //ushort
                case "System.Int32":    //int
                case "System.UInt32":   //uint
                case "System.Int64":    //long
                case "System.UInt64":   //ulong
                case "System.Single":   //float
                case "System.Double":   //double
                case "System.Decimal":  //decimal
                    return true;
                default:
                    return false;
            }
        }

        public static string Stringify<T>(this T[] array)
        {
            if (array.Length == 0) { return null; }

            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            for (int element = 0; element < array.Length - 1; element++)
            {
                sb.Append(array[element]).Append(" ");
            }
            sb.Append(array[array.Length - 1]).Append("]");

            return sb.ToString();
        }

        public static T Average<T>(this T[] array)
        {
            if (!IsNumber<T>()) { return default; }
            if (array.Length == 0) { return default; }

            dynamic sum = array[0];

            if (array.Length > 1)
            {
                for (int element = 1; element < array.Length; element++)
                {
                    sum += (dynamic)array[element];
                }
            }

            return (T)(sum / array.Length);
        }

        public static T Max<T>(this T[] array)
        {
            if (!IsNumber<T>()) { return default; }
            if (array.Length == 0) { return default; }

            T max = array[0];

            if (array.Length > 1)
            {
                for (int element = 1; element < array.Length; element++)
                {
                    max = ((dynamic)array[element] > max) ? array[element] : max;
                }
            }

            return max;
        }

        public static T Min<T>(this T[] array)
        {
            if (!IsNumber<T>()) { return default; }
            if (array.Length == 0) { return default; }

            T min = array[0];

            if (array.Length > 1)
            {
                for (int element = 1; element < array.Length; element++)
                {
                    min = ((dynamic)array[element] < min) ? array[element] : min;
                }
            }

            return min;
        }

        public static int CountDuplicates<T>(this T[] array)
        {
            if (array.Length == 0) { return 0; }

            List<T> valueList = new List<T>();
            int duplicates = 0;

            for (int element = 0; element < array.Length; element++)
            {
                if (valueList.Contains(array[element]))
                {
                    duplicates++;
                }
                else valueList.Add(array[element]);
            }

            return duplicates;
        }

        public static int CountValue<T>(this T[] array, T value)
        {
            if (array.Length == 0) { return 0; }

            int occurances = 0;

            for (int element = 0; element < array.Length; element++)
            {
                if ((dynamic)array[element] == value)
                {
                    occurances++;
                }
            }

            return occurances;
        }

        public static T[] CopyWithoutDuplicates<T>(this T[] array)
        {
            if (array.Length == 0) { return array; }

            List<T> valueList = new List<T>();

            for (int element = 0; element < array.Length; element++)
            {
                if (!valueList.Contains(array[element]))
                {
                    valueList.Add(array[element]);
                }
            }

            return valueList.ToArray();
        }

        public static void Fill<T>(this T[] array, T value)
        {
            for (int element = 0; element < array.Length; element++)
            {
                array[element] = value;
            }
        }

        public static void Insert<T>(this T[] array, int position, int count, T value)
        {
            if (position > array.Length - 1) { return; }

            for (int element = position; element < position+count; element++)
            {
                if (element < array.Length)
                {
                    array[element] = value;
                }
                else return;
            }
        }
    }
}