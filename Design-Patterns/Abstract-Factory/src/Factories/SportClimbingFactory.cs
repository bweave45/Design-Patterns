using System;
using System.Collections.Generic;
using System.Text;
using Abstract_Factory.src.Climbers;
using Abstract_Factory.src.Routes;

namespace Abstract_Factory.src.Factories
{
    public class SportClimbingFactory : ClimbingFactory
    {
        public override Climber CreateClimber()
        {
            return new AOndra();
        }

        public override Route CreateRoute()
        {
            return new Silence();
        }
    }
}
