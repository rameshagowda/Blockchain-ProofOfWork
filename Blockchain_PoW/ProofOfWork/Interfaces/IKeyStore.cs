using System;
using System.Collections.Generic;
using System.Text;
//using System.Security.Cryptography;

namespace ProofOfWork.Interfaces
{
    public interface IKeyStore
    {
        byte[] AuthenticatedHashKey { get; }
        string SignBlock(string blockHash);
        bool VerifyBlock(string blockHash, string signature);
    }
}
