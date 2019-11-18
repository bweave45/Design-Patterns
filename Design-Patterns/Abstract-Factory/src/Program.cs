using Abstract_Factory.src.Factories;
using System;

namespace Abstract_Factory.src
{
    class Program
    {
        static void Main(string[] args)
        {
            var SportClimbing = new SportClimbingFactory();
            var BigWallClimbing = new BigWallClimbingFactory();
            var Bouldering = new BoulderingFactory();

            var climbingWorld = new ClimbingWorld(SportClimbing);
            climbingWorld.ClimbTheRoute();

            climbingWorld = new ClimbingWorld(BigWallClimbing);
            climbingWorld.ClimbTheRoute();

            climbingWorld = new ClimbingWorld(Bouldering);
            climbingWorld.ClimbTheRoute();

            Console.ReadLine();
        }
    }
}
