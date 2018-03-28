using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace ProofOfWork.Cryptography
{
    public class HashData
    {
        // Hashing is one-way operation; Encryption is Two-way operation.
        public static byte[] ComputeHashSha256(byte[] toBeHashed)
        {
            using (var sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(toBeHashed);
            }
        }
    }
}
