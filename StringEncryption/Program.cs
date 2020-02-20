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
            StringEncryption stringEncryption = new StringEncryption();

            Console.WriteLine("Enter message: ");
            var userMessage = Console.ReadLine();

            Console.WriteLine("Enter key value: ");
            var userKey = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Encrypted String:\n" + stringEncryption.EncryptString(userMessage, userKey));
            Console.ReadKey();
        }
    }
}
