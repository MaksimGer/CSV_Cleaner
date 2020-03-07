using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_Cleaner.sources
{
    public class MyAttribute
    {
        private string name;
        private Types type;
        private Dictionary<string, int> values = new Dictionary<string, int>();

        public MyAttribute(String name)
        {
            this.name = name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setType(Types type)
        {
            this.type = type;
        }

        public string getName() { return name; }

        public Types getType() { return type; }

        public Dictionary<string, int> getValues()
        {
            return values;
        }

        public int getCountValue(String value)
        {
            try
            {
                return values[value];
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Attribute '" + name + "' does not contain '" + value + "' element");
                return 0;
            }
        }

        public void addValue(string value)
        {
            if (values.ContainsKey(value))
            {
                values[value] += 1;
            }
            else
            {
                values.Add(value, 1);
            }
        }

        public int getCountValues() { return values.Count; }

        public bool removeValue(string value)
        {
            return values.Remove(value);
        }
    }
}
