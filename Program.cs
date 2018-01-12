using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Hashing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetHash(Console.ReadLine()));
            Console.ReadLine();
        }

        public static string GetHash(string input)
        {
            HashAlgorithm algorithm = SHA256.Create();
            return BitConverter.ToString(algorithm.ComputeHash(Encoding.UTF8.GetBytes(input))).Replace("-", String.Empty);
        }
    }
}
