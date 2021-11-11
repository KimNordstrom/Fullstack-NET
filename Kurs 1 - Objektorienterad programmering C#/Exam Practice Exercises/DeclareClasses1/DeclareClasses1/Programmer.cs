using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclareClasses1
{
    class Programmer
    {
        public string Name { get; init; }
        public int Age { get; private set;}
        private bool _isHappy;
        public Programmer()
        {
            _isHappy = false;
        }
        public int ProduceCode()
        {
            if (_isHappy)
            {
                return 100;
            } else
            {
                return 50;
            }
        }
        public void DrinkCoffe()
        {
            _isHappy = true;
        }
        public void CelebrateBirthday()
        {
            Age++;
            _isHappy = true;
        }
    }
}
