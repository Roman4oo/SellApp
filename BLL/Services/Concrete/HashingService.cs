using BLL.Services.Abstract;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace BLL.Services
{
   public class HashingService : IHashingService
    {
        public string CreateHash(string stringToHash)
        {
            var salt = GenereteSalt(16);
            var bytes = KeyDerivation.Pbkdf2(stringToHash, salt, KeyDerivationPrf.HMACSHA512, 10000, 16);

            return $"{Convert.ToBase64String(salt)}:{Convert.ToBase64String(bytes)}";

        }

        public bool IsStringEqualHash(string stringToHash, string hash)
        {
            try
            {
                var parts = hash.Split(':');
                var salt = Convert.FromBase64String(parts[0]);
                var bytes = KeyDerivation.Pbkdf2(stringToHash, salt, KeyDerivationPrf.HMACSHA512, 10000, 16);

                return parts[1].Equals(Convert.ToBase64String(bytes));
            }
            catch
            {
                return false;
            }
        }
        private static byte[] GenereteSalt(int lenght)
        {
            var salt = new byte[lenght];
            using (var random = RandomNumberGenerator.Create())
            {
                random.GetBytes(salt);
            }
            return salt;
        }
    }
}
