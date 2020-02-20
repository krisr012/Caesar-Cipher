using StringEncryption.Contracts;
using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEncryption
{
    class StringEncryption : IStringEncryption
    {
        public String EncryptString(String input, int key)
        {
            String returnValue = String.Empty;
            
            foreach(char character in input)
            {
                returnValue += Cipher(character, key);
            }

            return returnValue;
        }

        private Char Cipher(char characters, int key)
        {
            if (!char.IsLetter(characters))
            {
                return characters;
            }
            else
            {
                char offset = char.IsUpper(characters) ? 'A' : 'a';
                return (char)((((characters + key) - offset) % 26) + offset);
            }
        }
    }
}
