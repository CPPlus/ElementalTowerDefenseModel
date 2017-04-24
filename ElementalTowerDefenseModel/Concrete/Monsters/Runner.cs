using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElementalTowerDefenseModel
{
    public class Runner : Monster
    {
        public Runner() : base(25, 9, 2.5f, MonsterType.RUNNER, TerrainType.GROUND)
        {
        }
    }
}
