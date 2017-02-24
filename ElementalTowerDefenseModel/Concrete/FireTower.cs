using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElementalTowerDefenseModel
{
    class FireTower : Tower
    {
        public FireTower() : base(new Fireball(), 200, 2, 5, 60)
        {
        }
    }
}
