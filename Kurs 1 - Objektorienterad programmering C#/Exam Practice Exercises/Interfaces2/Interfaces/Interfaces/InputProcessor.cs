using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class InputProcessor
    {
        private IInputGatherer _inputGatherer;

        public InputProcessor(IInputGatherer inputGatherer)
        {
            _inputGatherer = inputGatherer;
        }

        public void GatherData()
        {
            while (true)
            {
                Console.WriteLine("Enter a number or press enter to complete list");
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                int value = Convert.ToInt32(input);
                _inputGatherer.CollectInput(value);
            }
        }
    }
}
