using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementalTowerDefenseModel
{
    class MovementComp
    {
        public Stat Speed { get; private set; }

        public MovementComp(float maxSpeed)
        {
            Speed = new Stat(Math.Abs(maxSpeed));
        }
    }
}
