using ProofOfWork.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProofOfWork
{
    //Queue data structure used for in-memory queue / transaction pool.
    //In reality, it can have a database or RabbitMQ as distributed transaction pool.
    // We need Transaction pool because it helps to sync nodes on distributed network.

    public class TransactionPool
    {
        private readonly Queue<ITransaction> _queue;

        public TransactionPool()
        {
            _queue = new Queue<ITransaction>();
        }

        public void AddTransaction(ITransaction transaction)
        {
            _queue.Enqueue(transaction);
        }

        public ITransaction GetTransaction()
        {
            return _queue.Dequeue();
        }
    }
}
