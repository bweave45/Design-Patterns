using Chain_Of_Responsibility.src.ClaimsApprovers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_Of_Responsibility.src.ClaimApprovers
{
    public class RegionalManager : ClaimApprover
    {
        public override void HandleClaimRequest(Claim claim)
        {
            if (claim.Amount <= 100)
            {
                Console.WriteLine("Claim: {0} was approved by a Regional Manager!", claim.ClaimId);
            }
            else if (successor != null)
            {
                successor.HandleClaimRequest(claim);
            }
        }
    }
}
