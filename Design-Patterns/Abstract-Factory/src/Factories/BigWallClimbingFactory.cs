﻿using Abstract_Factory.src.Climbers;
using Abstract_Factory.src.Routes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory.src.Factories
{
    public class BigWallClimbingFactory : ClimbingFactory
    {
        public override Climber CreateClimber()
        {
            return new AHonnold();
        }
        public override Route CreateRoute()
        {
            return new FreeRider();
        }
    }
}
