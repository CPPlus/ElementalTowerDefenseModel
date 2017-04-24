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
            monsterPrices.Add(MonsterType.CRAWLING_HORROR, 50);
            monsterPrices.Add(MonsterType.RUNNER, 40);
            monsterPrices.Add(MonsterType.AIR_HORROR, 65);
            monsterPrices.Add(MonsterType.SOUL_EATER, 500);
        }

        protected override void AddTowerPrices(Dictionary<TowerType, float> towerPrices)
        {
            towerPrices.Add(TowerType.EARTH_TOWER, 60);
            towerPrices.Add(TowerType.FIRE_TOWER, 70);
        }
    }
}
