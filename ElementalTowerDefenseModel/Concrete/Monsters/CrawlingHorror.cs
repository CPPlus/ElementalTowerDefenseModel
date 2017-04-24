using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElementalTowerDefenseModel
{
    public class CrawlingHorror : Monster
    {
        public CrawlingHorror() : base(35, 15, 1.25f, MonsterType.CRAWLING_HORROR, TerrainType.GROUND)
        {
        }
    }
}
