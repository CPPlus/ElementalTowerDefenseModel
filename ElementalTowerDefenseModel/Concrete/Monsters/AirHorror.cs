using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElementalTowerDefenseModel
{
    public class AirHorror : Monster
    {
        public AirHorror() : base(20, 15, 3.5f, MonsterType.AIR_HORROR, TerrainType.AIR)
        {
        }
    }
}
