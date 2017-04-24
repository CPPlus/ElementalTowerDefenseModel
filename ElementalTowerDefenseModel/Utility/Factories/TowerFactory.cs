using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElementalTowerDefenseModel
{
    public static class TowerFactory
    {
        public static Tower CreateTower(TowerType type)
        {
            Tower tower = null;
            switch (type)
            {
                case TowerType.EARTH_TOWER: tower = new EarthTower(); break;
                case TowerType.FIRE_TOWER: tower = new FireTower(); break;
            }
            return tower;
        }
    }
}
