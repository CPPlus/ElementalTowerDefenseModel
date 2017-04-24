using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElementalTowerDefenseModel
{
    public class SoulEater : Monster
    {
        public SoulEater() : base(1000, 30, 0.7f, MonsterType.SOUL_EATER, TerrainType.GROUND)
        {
        }
    }
}
