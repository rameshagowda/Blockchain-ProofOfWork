using System;
using System.Collections.Generic;
using System.Text;

namespace ProofOfWork.Interfaces
{
    public interface IBlock
    {
        // List of transactions
        List<ITransaction> Transaction { get; }

        // Block header data
        int BlockNumber { get; }
        DateTime CreatedDate { get; set; }
        string BlockHash { get; }
        string PreviousBlockHash { get; set; }
        string BlockSignature { get; }

        //utility functions
        void AddTransaction(ITransaction transaction);
        string CalculateBlockHash(string previousBlockHash);
        void SetBlockHash(IBlock parent);
        IBlock NextBlock { get; set; }
        bool IsValidChain(string prevBlockHash, bool verbose);
        IKeyStore KeyStore { get; }
    }
}
