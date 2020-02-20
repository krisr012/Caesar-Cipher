using StringEncryption.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            IStringEncryption stringEncryption = new StringEncryption();
            IInputCheck inputCheck = new inputCheck();

            Console.WriteLine("Enter message: ");
            var userMessage = Console.ReadLine();

            Console.WriteLine("Enter key value: ");
            var userKey = Convert.ToInt32(Console.ReadLine());

            if (inputCheck.userInputCheck(userMessage) == true)
            {
                Console.WriteLine("Issue with the entered text");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Encrypted String:\n" + stringEncryption.EncryptString(userMessage, userKey));
                Console.ReadKey();
            }
        }
    }
}
