using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElementalTowerDefenseModel
{
    public static class MonsterFactory
    {
        public static Monster CreateMonster(MonsterType type)
        {
            Monster monster = null;
            switch (type)
            {
                case MonsterType.CRAWLING_HORROR: monster = new CrawlingHorror(); break;
                case MonsterType.RUNNER: monster = new Runner(); break;
                case MonsterType.SOUL_EATER: monster = new SoulEater(); break;
                case MonsterType.AIR_HORROR: monster = new AirHorror(); break;
            }
            return monster;
        }
    }
}
