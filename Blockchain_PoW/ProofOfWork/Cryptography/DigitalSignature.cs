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
    //DigitalSignature is for Non-repudiation/trust.
    public class DigitalSignature
    {
        private RSAParameters _publicKey;
        private RSAParameters _privateKey;

        public void AssignNewKey()
        {
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;
                _publicKey = rsa.ExportParameters(false);
                _privateKey = rsa.ExportParameters(true);
            }
        }

        public byte[] SignData(byte[] hashOfDataToSign)
        {
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;
                rsa.ImportParameters(_privateKey);

                var rsaFormatter = new RSAPKCS1SignatureFormatter(rsa);
                rsaFormatter.SetHashAlgorithm("SHA256");

                return rsaFormatter.CreateSignature(hashOfDataToSign);
            }
        }

        public bool VerifySignature(byte[] hashOfDataToSign, byte[] signature)
        {
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.ImportParameters(_publicKey);

                var rsaDeformatter = new RSAPKCS1SignatureDeformatter(rsa);
                rsaDeformatter.SetHashAlgorithm("SHA256");

                return rsaDeformatter.VerifySignature(hashOfDataToSign, signature);
            }
        }

    }
}
