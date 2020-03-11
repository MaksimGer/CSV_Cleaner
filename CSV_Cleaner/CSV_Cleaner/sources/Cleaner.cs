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
            // Функция на вход получает очередную строку в виде массива элементов и знак, которым обозначаются
            // пропущенные значения в файле(как правило, это N/A). Если массив содержит значения и 
            // среди них присутствует пропущенное значение, функция возвращает null.
            if (items != null && items.Length  >= 0)
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
            if(items == null)
            {
                return items;
            }
            // Функция на вход получает очередную строку в виде массива элементов, ссылку на лист атрибутов
            // (для определения количества тех или иных значений в файле) и интовый массив с индексами столбцов,
            // для которых необходимо проводить проверку на единичные значения. 
            // minCount - минимальное допустимое количество элементов в файле.
            // Работа функции: в переменную item записывается значение в текущей строке, в столбце с индексом index
            // затем происходит проверка количества этого значения во всём файле. Если количество меньше минимально
            // допустимого, функция возвращает null. Если в функцию передан некорректный индекс, возвращается исходный
            // массив значений.
            string item;
            int minCount = 5;
            int badIndex = 0;
            
            try
            {
                foreach(int index in checkedIndexes)
                {
                    badIndex = index;
                    item = items[index];

                    if(attributes[index].getCountValue(item) < minCount) //проверка количества текучего значения во всём файле
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
