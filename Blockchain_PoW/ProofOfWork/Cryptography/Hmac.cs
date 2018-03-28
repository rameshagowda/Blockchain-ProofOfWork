using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

//Core principles of Cryptography:
// 1. Confidentiality - achieved by encrypting the data
// 2. Integrity - Hashing solves this
// 3. Authentication - HMAC (Authenticated hashing) solves Authentication and Integrity - Ex. RSA Security.
// 4. Non-repudiation - It is trust. You can't refuse the ownership further down the line. 
// For ex, Digital Signature - Signed the message using Private Key and Verify the signature using public key (opposite of Encryption). 

namespace ProofOfWork.Cryptography
{
    public class Hmac
    {
        private const int KeySize = 32;

        public static byte[] GenerateKey()
        {
            using (var randomNumberGenerator = new RNGCryptoServiceProvider())
            {
                var randomNumber = new byte[KeySize];
                randomNumberGenerator.GetBytes(randomNumber);

                return randomNumber;
            }
        }

        public static byte[] ComputeHmacsha256(byte[] toBeHashed, byte[] key)
        {
            using (var hmac = new HMACSHA256(key))
            {
                return hmac.ComputeHash(toBeHashed);
            }
        }
    }
}
