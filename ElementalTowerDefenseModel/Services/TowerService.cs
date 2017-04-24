using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElementalTowerDefenseModel
{
    public class TowerService
    {
        private const float TOWER_REFUND_AMOUNT = 0.5f;
        private const float PER_RELOAD_PRICE = 10;

        private GoldManager goldManager;
        private List<Tower> towers;
        private TowerSelector towerSelector;

        public TowerService(GoldManager goldManager, TowerSelector towerSelector)
        {
            this.goldManager = goldManager;
            towers = new List<Tower>();
            this.towerSelector = towerSelector;
        }

        public Tower Buy()
        {
            Tower tower = TowerFactory.CreateTower(towerSelector.SelectedTowerType);
            return TryToBuyTower(tower);
        }

        private Tower TryToBuyTower(Tower tower)
        {
            if (tower == null) return null;

            float towerPrice = goldManager.PriceList.GetPrice(tower.Type);

            if (goldManager.CanSpend(towerPrice))
            {
                goldManager.Spend(towerPrice);
                towers.Add(tower);
                return tower;
            }
            else return null;
        }

        public float Sell(Tower tower)
        {
            if (tower == null) return 0;

            if (towers.Contains(tower))
            {
                towers.Remove(tower);
                float sellPrice = goldManager.PriceList.GetPrice(tower.Type) * TOWER_REFUND_AMOUNT;
                goldManager.Earn(sellPrice);
                return sellPrice;
            } else return 0;
        }

        public float Reload(Tower tower)
        {
            if (tower == null) return 0;

            if (towers.Contains(tower))
            {
                if (goldManager.CanSpend(PER_RELOAD_PRICE) && !tower.Ammo.IsFull)
                {
                    tower.Ammo.Fill();
                    goldManager.Spend(PER_RELOAD_PRICE);
                    return PER_RELOAD_PRICE;
                }
            }

            return 0;
        }

        public void Reload()
        {
            foreach (Tower tower in towers)
            {
                Reload(tower);
            }
        }
    }
}
