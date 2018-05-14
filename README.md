# Blockchain-ProofOfWork
Blockchain is immutable, distributed database / Ledger of economic transactions which are secured using Cryptography.

Important Keywords in Blockchain:
1. Cryptography - Secure transactions using Hashing, Authenticated hashing/hmac and Digital Signature (Non-repudiation)
2. Immutable / Non-corruptable - achieved through Proof of Work by introducing Nonce (also called mining)
3. Distributed /Decentralized Ledger - Blockchain accepts transactions and allows us to mine (add) new Blocks. But the whole point of Blockchains is that they should be decentralized. And if they’re decentralized, need to ensure that they all reflect the same chain. This is called the problem of Consensus, and we’ll have to implement a Consensus Algorithm (Longest chain) if we want more than one node in our network.

4. Blockchain - Blockchain concepts are simillar to double-linked list data structure in C/C++. will have Blocks. Block will have header     and Transaction details and is secured using Crypto algorithms.

5. Proof of Work - Also called mining. Used for adding/mining to blockchain and validating new blocks, detecting tampering and keep         ledgers synchronised.
6. Nonce - Rule: Hash value must start with N zeroes 
	A Proof of Work algorithm (PoW) is how new Blocks are created or mined on the blockchain. The goal of PoW is to discover a number which   solves a problem. The number must be difficult to find/calculate but easy to 	verify—computationally speaking—by anyone on the network.   This is the core idea behind Proof of Work.

7. Proof of Stake - Alternative algorithm to overcome computaion heavy PoW.
8. Maintaining Consensus - A conflict is when one node has a different chain to another node. To resolve this, the longest chain on the      network is the de-facto one. Blockchain is eventual consistency.
