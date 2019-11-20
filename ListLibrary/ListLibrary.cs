using System.Collections.Generic;
using System.Text;

namespace CollectionExtendLib
{
    public static class ListLibrary
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

        public static string Stringify<T>(this List<T> list)
        {
            if (list.Count == 0) { return null; }

            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            for (int element = 0; element < list.Count - 1; element++)
            {
                sb.Append(list[element]).Append(" ");
            }
            sb.Append(list[list.Count - 1]).Append("]");

            return sb.ToString();
        }
    
        public static T Average<T>(this List<T> list)
        {
            if (!IsNumber<T>()) { return default; }
            if (list.Count == 0) { return default; }

            dynamic sum = list[0];

            if (list.Count > 1)
            {
                for (int element = 1; element < list.Count; element++)
                {
                    sum += (dynamic)list[element];
                }
            }

            return (T)(sum / list.Count);
        }

        public static T Max<T>(this List<T> list)
        {
            if (!IsNumber<T>()) { return default; }
            if (list.Count == 0) { return default; }

            T max = list[0];

            if (list.Count > 1)
            {
                for (int element = 1; element < list.Count; element++)
                {
                    max = ((dynamic)list[element] > max) ? list[element] : max;
                }
            }

            return max;
        }
        
        public static T Min<T>(this List<T> list)
        {
            if (!IsNumber<T>()) { return default; }
            if (list.Count == 0) { return default; }

            T min = list[0];

            if (list.Count > 1)
            {
                for (int element = 1; element < list.Count; element++)
                {
                    min = ((dynamic)list[element] < min) ? list[element] : min;
                }
            }

            return min;
        }

        public static int CountDuplicates<T>(this List<T> list)
        {
            if (list.Count == 0) { return 0; }

            List<T> valueList = new List<T>();
            int duplicates = 0;

            for (int element = 0; element < list.Count; element++)
            {
                if (valueList.Contains(list[element]))
                {
                    duplicates++;
                }
                else valueList.Add(list[element]);
            }

            return duplicates;
        }
        
        public static int CountValue<T>(this List<T> list, T value)
        {
            if (list.Count == 0) { return 0; }

            int occurances = 0;

            for (int element = 0; element < list.Count; element++)
            {
                if ((dynamic)list[element] == value)
                {
                    occurances++;
                }
            }

            return occurances;
        }

        public static void RemoveDuplicates<T>(this List<T> list)
        {
            List<T> valueList = new List<T>();
            List<int> indicesToRemove = new List<int>();

            for (int element = 0; element < list.Count; element++)
            {
                if (!valueList.Contains(list[element]))
                {
                    valueList.Add(list[element]);
                }
                else indicesToRemove.Add(element);
            }

            for (int element = indicesToRemove.Count - 1; element >= 0; element--)
            {
                list.RemoveAt(indicesToRemove[element]);
            }
        }

        public static List<T> CopyWithoutDuplicates<T>(this List<T> list)
        {
            if (list.Count == 0) { return list; }

            List<T> valueList = new List<T>();

            for (int element = 0; element < list.Count; element++)
            {
                if (!valueList.Contains(list[element]))
                {
                    valueList.Add(list[element]);
                }
            }

            return valueList;
        }

        public static void Fill<T>(this List<T> list, int count, T value)
        {
            list.Clear();
            for (int element = 0; element < count; element++)
            {
                list.Add(value);
            }
        }

        public static void Append<T>(this List<T> list, int count, T value)
        {
            for (int element = 0; element < count; element++)
            {
                list.Add(value);
            }
        }        
    }
}