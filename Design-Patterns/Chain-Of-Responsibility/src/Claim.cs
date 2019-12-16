using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_Of_Responsibility.src
{
    public class Claim
    {
        public double Amount { get; set; }
        public string ClaimId { get; set; }
        public ClaimType Type { get; set; }

        public Claim(double amount,string claimId, ClaimType type)
        {
            Amount = amount;
            ClaimId = claimId;
            Type = type;
        }
    }

    public enum ClaimType
    {
        RegularClaim,
        HighRiskClaim
    }
}
