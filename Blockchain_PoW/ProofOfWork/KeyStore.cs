using ProofOfWork.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProofOfWork
{
    public class KeyStore:IKeyStore
    {
        //DigitalSignature is for Non-repudiation/trust.
        private Cryptography.DigitalSignature digitalSignature { get; set; }
        public byte[] AuthenticatedHashKey { get; private set; }

        public KeyStore(byte[] authenticatedHashKey)
        {
            AuthenticatedHashKey = authenticatedHashKey;
            digitalSignature = new Cryptography.DigitalSignature();
            digitalSignature.AssignNewKey();
        }

        public string SignBlock(string blockHash)
        {
            return Convert.ToBase64String(digitalSignature.SignData(Convert.FromBase64String(blockHash)));
        }

        public bool VerifyBlock(string blockHash, string signature)
        {
            return digitalSignature.VerifySignature(Convert.FromBase64String(blockHash), Convert.FromBase64String(signature));
        }
    }
}
