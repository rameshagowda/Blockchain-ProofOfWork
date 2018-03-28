using System;
using System.Collections.Generic;
using System.Text;

namespace ProofOfWork.Interfaces
{
    public interface ITransaction
    {
        //Business doamin data
        string ClaimNumber { get; set; }
        decimal SettlementAmount { get; set; }
        DateTime SettlementDate { get; set; }
        string CarRegistration { get; set; }
        int Mileage { get; set; }
        ClaimType ClaimType { get; set; }

        string CalculateTransactionHash();
    }
}
