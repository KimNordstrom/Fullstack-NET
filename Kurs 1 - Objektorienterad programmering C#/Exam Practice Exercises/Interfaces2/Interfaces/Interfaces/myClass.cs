using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class myClass : IInputGatherer, IOutputProvider
    {
        static List<int> intInputs = new List<int>();
        public void CollectInput(int value)
        {
            intInputs.Add(value);
        }

        public string GetOutput()
        {
            string stringNumber = "";
            intInputs.Sort();
            intInputs.Reverse();
            foreach (int inputs in intInputs)
            {
                stringNumber += inputs.ToString() + Environment.NewLine;
            }
            return stringNumber;
        }
    }
}
