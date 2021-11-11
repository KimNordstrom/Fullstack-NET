using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class IntCollection
    {
        private static List<int> intValues = new List<int>();

        public void AddInt(int value)
        {
            intValues.Add(value);
        }

        public string GetListOfInts()
        {
            string result = "";
            foreach (int value in intValues)
            {
                if (result == "")
                {
                    result = $"{value}";
                }
                else
                {
                    result += $",{value}";
                }
            }
            return result;
        }
        public void ValuesClear()
        {
            intValues.Clear();
        }
    }
}
