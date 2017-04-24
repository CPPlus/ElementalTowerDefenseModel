using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElementalTowerDefenseModel
{
    public class FireTower : Tower
    {
        public FireTower() : base(new Fireball(), 300, 2.5f, 0.1f, TowerType.FIRE_TOWER)
        {
        }
    }
}
