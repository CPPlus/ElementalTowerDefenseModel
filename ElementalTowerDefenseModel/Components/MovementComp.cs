﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElementalTowerDefenseModel
{
    public class MovementComp
    {
        public Stat Speed { get; private set; }

        public MovementComp(float maxSpeed)
        {
            Speed = new Stat(Math.Abs(maxSpeed));
        }
    }
}
