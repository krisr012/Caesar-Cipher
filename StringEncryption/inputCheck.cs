using StringEncryption.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEncryption
{
    class inputCheck : IInputCheck
    {
        public bool userInputCheck(string input)
        {
            if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input) || input.Any(Char.IsDigit))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
