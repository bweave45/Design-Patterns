using Chain_Of_Responsibility.src;
using Chain_Of_Responsibility.src.ClaimApprovers;
using System;
using System.Collections.Generic;

namespace Chain_Of_Responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var claims = new List<Claim>
            {
                new Claim(100, "00023423", ClaimType.HighRiskClaim),
                new Claim(100000, "00036453", ClaimType.RegularClaim),
                new Claim(1, "00090868", ClaimType.RegularClaim),
                new Claim(1000.5, "00023465", ClaimType.RegularClaim),
                new Claim(999.5, "00057653", ClaimType.RegularClaim),
                new Claim(10000000, "00023515", ClaimType.HighRiskClaim)
            };

            var regManager = new RegionalManager();
            var distManager = new DistrictManager();
            var claimsManager = new ClaimsManager();
            var superClaimsManager = new SuperClaimsManager();

            claimsManager.SetSuccessor(superClaimsManager);
            distManager.SetSuccessor(claimsManager);
            regManager.SetSuccessor(distManager);

            foreach (var claim in claims)
            {
                regManager.HandleClaimRequest(claim);
            }

            Console.ReadLine();
        }
    }
}
