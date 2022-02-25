using System;

namespace Algorithm
{
    public class Sorting
    {
        /// <summary>
        /// Take a generic list in and perform insertion sort on it
        /// </summary>
        public static List<T> InsertionSorting<T>(List<T> list) where T : IComparable
        {
            for (int i = 1; i < list.Count; i++)
            {
                int indexToInsert = -1;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (list[i].CompareTo(list[j]) < 0)
                    {
                        indexToInsert = j;
                    }
                }
                if (indexToInsert != -1)
                {
                    var element = list[i];
                    list.RemoveAt(i);
                    list.Insert(indexToInsert, element);
                }
            }

            return list;
        }
    }
}