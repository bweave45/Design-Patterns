using Abstract_Factory.src.Climbers;
using Abstract_Factory.src.Factories;
using Abstract_Factory.src.Routes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory.src
{
    public class ClimbingWorld
    {
        private Climber _climber;
        private Route _route;

        public ClimbingWorld(ClimbingFactory factory)
        {
            _climber = factory.CreateClimber();
            _route = factory.CreateRoute();
        }

        public void ClimbTheRoute()
        {
            _climber.Climb(_route);
        }
    }
}
