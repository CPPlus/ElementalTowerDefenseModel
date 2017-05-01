using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElementalTowerDefenseModel
{
    public class RegularPriceList : PriceList
    {
        protected override void AddMonsterPrices(Dictionary<MonsterType, float> monsterPrices)
        {
            monsterPrices.Add(MonsterType.CRAWLING_HORROR, 25);
            monsterPrices.Add(MonsterType.RUNNER, 20);
            monsterPrices.Add(MonsterType.AIR_HORROR, 30);
            monsterPrices.Add(MonsterType.SOUL_EATER, 250);
        }

        protected override void AddTowerPrices(Dictionary<TowerType, float> towerPrices)
        {
            towerPrices.Add(TowerType.EARTH_TOWER, 60);
            towerPrices.Add(TowerType.FIRE_TOWER, 70);
        }
    }
}
