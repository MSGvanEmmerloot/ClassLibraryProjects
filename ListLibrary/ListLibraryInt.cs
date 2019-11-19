using System;
using System.Collections.Generic;
using System.Text;

namespace UtilityLibraries
{
    public static class ListLibraryInt
    {
        public static string Stringify(this List<int> list)
        {
            if (list.Count == 0) { return null; }

            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            for (int element = 0; element < list.Count-1; element++)
            {
                sb.Append(list[element]).Append(" ");
            }
            sb.Append(list[list.Count - 1]).Append("]");

            return sb.ToString();
        }

        public static int Average(this List<int> list)
        {
            if (list.Count == 0) { return 0; }

            int sum = 0;

            for(int element=0; element < list.Count; element++)
            {
                sum += list[element];
            }

            return sum / list.Count;
        }
        
        public static int Max(this List<int> list)
        {
            if (list.Count == 0) { return 0; }

            int max = list[0];

            if (list.Count > 1)
            {
                for (int element = 1; element < list.Count; element++)
                {
                    max = (list[element] > max) ? list[element] : max;
                }
            }            

            return max;
        }

        public static int Min(this List<int> list)
        {
            if (list.Count == 0) { return 0; }

            int min = list[0];

            if (list.Count > 1)
            {
                for (int element = 1; element < list.Count; element++)
                {
                    min = (list[element] < min) ? list[element] : min;
                }
            }

            return min;
        }

        public static int CountDuplicates(this List<int> list)
        {
            if (list.Count == 0) { return 0; }

            List<int> valueList = new List<int>();
            int duplicates = 0;
                        
            for (int element = 0; element < list.Count; element++)
            {
                if (valueList.Contains(list[element])){
                    duplicates++;
                }
                else valueList.Add(list[element]);
            }

            return duplicates;
        }

        public static int CountNumber(this List<int> list, int number)
        {
            if (list.Count == 0) { return 0; }

            int occurances = 0;

            for (int element = 0; element < list.Count; element++)
            {
                if (list[element] == number)
                {
                    occurances++;
                }
            }

            return occurances;
        }

        public static void RemoveDuplicates(this List<int> list)
        {
            List<int> valueList = new List<int>();
            List<int> indicesToRemove = new List<int>();

            for (int element = 0; element < list.Count; element++)
            {
                if (!valueList.Contains(list[element]))
                {
                    valueList.Add(list[element]);
                }
                else indicesToRemove.Add(element);
            }

            for(int element = indicesToRemove.Count-1; element >= 0; element--)
            {
                list.RemoveAt(indicesToRemove[element]);
            }
        }

        public static List<int> CopyWithoutDuplicates(this List<int> list)
        {
            if (list.Count == 0) { return list; }

            List<int> valueList = new List<int>();

            for (int element = 0; element < list.Count; element++)
            {
                if (!valueList.Contains(list[element]))
                {
                    valueList.Add(list[element]);
                }
            }

            return valueList;
        }

        public static void Fill(this List<int> list, int count, int number)
        {
            list.Clear();
            for(int element=0; element<count; element++)
            {
                list.Add(number);
            }
        }

        public static void Append(this List<int> list, int count, int number)
        {
            for (int element = 0; element < count; element++)
            {
                list.Add(number);
            }
        }
    }
}