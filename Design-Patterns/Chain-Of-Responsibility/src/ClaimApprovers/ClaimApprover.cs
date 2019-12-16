using System;
using System.Collections.Generic;
using System.Text;
using Chain_Of_Responsibility.src;

namespace Chain_Of_Responsibility.src.ClaimsApprovers
{
    public abstract class ClaimApprover

    {
        protected ClaimApprover successor;

        public void SetSuccessor(ClaimApprover successor)
        {
            this.successor = successor;
        }

        public abstract void HandleClaimRequest(Claim claim);
    }
}
