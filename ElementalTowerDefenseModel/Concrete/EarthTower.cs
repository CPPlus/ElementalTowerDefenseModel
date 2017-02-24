using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElementalTowerDefenseModel
{
    public class EarthTower : Tower
    {
        public EarthTower() : base(new Rock(), 100, 2, 7, 75)
        {
        }
    }
}
