using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class OutputWriter
    {
        private IOutputProvider _outputProvider;

        public OutputWriter(IOutputProvider outputProvider)
        {
            _outputProvider = outputProvider;
        }

        public void PrintOutput()
        {
            string output = _outputProvider.GetOutput();
            Console.WriteLine($"The output is:\n{output}");
        }
    }
}
