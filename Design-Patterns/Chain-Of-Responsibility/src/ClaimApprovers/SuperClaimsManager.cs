using Chain_Of_Responsibility.src.ClaimsApprovers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_Of_Responsibility.src.ClaimApprovers
{
    public class SuperClaimsManager : ClaimApprover
    {
        public override void HandleClaimRequest(Claim claim)
        {
            if (claim.Type != ClaimType.RegularClaim)
            {
                Console.WriteLine("Claim: {0} was approved by THE SUPER Claim Manager!", claim.ClaimId);
            }
            else if (successor != null)
            {
                successor.HandleClaimRequest(claim);
            }
        }
    }
}
