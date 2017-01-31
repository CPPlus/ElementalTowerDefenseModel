using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElementalTowerDefenseModel
{
    public class TowerService
    {
        private GoldManager goldManager;
        private List<Tower> towers;

        public Tower Buy(TowerType type)
        {
            Tower tower = null;

            switch (type)
            {
                case TowerType.EARTH_TOWER: tower = new EarthTower(); break;
                case TowerType.FIRE_TOWER: tower = new FireTower(); break;
            }

            return TryToBuyTower(tower);
        }

        private Tower TryToBuyTower(Tower tower)
        {
            if (tower == null) return null;

            if (goldManager.CanSpend(tower.Price.Points))
            {
                goldManager.Spend(tower.Price.Points);
                towers.Add(tower);
                return tower;
            }
            else return null;
        }

        public void Sell(Tower tower)
        {
            if (tower == null) return;

            if (towers.Contains(tower))
            {
                towers.Remove(tower);
                goldManager.Earn(tower.Price.Points);
            }
        }

        public void Reload()
        {
            foreach (Tower tower in towers)
            {
                tower.Ammo.Fill();
            }
        }
    }
}
