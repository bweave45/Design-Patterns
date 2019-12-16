using Chain_Of_Responsibility.src.ClaimsApprovers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_Of_Responsibility.src.ClaimApprovers
{
    public class DistrictManager : ClaimApprover
    {
        public override void HandleClaimRequest(Claim claim)
        {
            if (claim.Amount <= 1000)
            {
                Console.WriteLine("Claim: {0} was approved by a District Manager!", claim.ClaimId);
            }
            else if (successor != null)
            {
                successor.HandleClaimRequest(claim);
            }
        }
    }
}
