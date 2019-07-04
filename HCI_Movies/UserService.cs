using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace HCI_Movies
{
    class UserService
    {
        private static byte[] GetHash(string password)
        {
            HashAlgorithm algorithm = SHA256.Create();
            return algorithm.ComputeHash(Encoding.UTF8.GetBytes(password));
        }

        private static string GetEncodedHash(byte[] hash)
        {
            return System.Convert.ToBase64String(hash);
        }

        public static string GetPasswordHash(string salt, string password)
        {
            string s = salt + password;
            return GetEncodedHash(GetHash(s));
        }
    }
}
