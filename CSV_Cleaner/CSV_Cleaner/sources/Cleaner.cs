using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_Cleaner.sources
{
    class Cleaner
    {
        public static string[] cleaningMissingValues(string[] items, string missSymbol)
        {
            if(items != null && items.Length  >= 0)
            {
                foreach(string item in items)
                {
                    if (item.Equals(missSymbol))
                        return null;
                }
            }

            return items;
        }

        public static string[] cleaningSingleCases(string[] items, ref List<MyAttribute> attributes, int[] checkedIndexes)
        {
            string item;
            int badIndex = 0;

            try
            {
                foreach(int index in checkedIndexes)
                {
                    badIndex = index;
                    item = items[index];

                    if(attributes[index].getCountValue(item) <= 4)
                    {
                        return null;
                    }
                }
            }
            catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("function 'cleaningSingleCases' - " +
                    "ArgumentOutOfRangeException: the array does not contain " +
                    "an element with index " + badIndex + "! Сurrent array returned.");
                return items;
            }

            return items;
        }
    }
}
