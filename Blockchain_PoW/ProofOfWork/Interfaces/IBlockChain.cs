using System;
using System.Collections.Generic;
using System.Text;

namespace ProofOfWork.Interfaces
{
    public interface IBlockChain
    {
        void AcceptBlock(IBlock block);
        int NextBlockNumber { get; }
        void VerifyChain();
    }
}
