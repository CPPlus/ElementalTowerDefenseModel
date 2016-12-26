using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementalTowerDefenseModel
{
    class HealthComp
    {
        public Stat Health { get; private set; }

        public HealthComp(float maxHealth)
        {
            Health = new Stat(Math.Abs(maxHealth));
        }
    }
}
