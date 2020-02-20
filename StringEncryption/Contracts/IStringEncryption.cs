using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEncryption.Contracts
{
    interface IStringEncryption
    {
        String EncryptString(String input, int key);
    }
}
