using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementalTowerDefenseModel.Services
{
    class TowerService
    {
        private GoldManager goldManager;
        private List<Tower> towers;
        private float sellPriceDrop;

        public TowerService(GoldManager goldManager, float sellPriceDrop)
        {
            this.goldManager = goldManager;
            towers = new List<Tower>();

            sellPriceDrop = Math.Abs(sellPriceDrop);
            if (sellPriceDrop < 0) sellPriceDrop = 0;
            if (sellPriceDrop > 1) sellPriceDrop = 1;
        }

        // TODO: Instantiate actual tower.
        public Tower Buy(Type type)
        {
            // Instantiate a tower depending on type.
            Tower tower = null;

            if (goldManager.CanSpend(tower.Price.Points))
            {
                towers.Add(tower);
                goldManager.Spend(tower.Price.Points);
                return tower;
            } else
            {
                return null;
            }
        }

        public void Sell(Tower tower)
        {
            towers.Remove(tower);
            goldManager.Earn(tower.Price.Points * sellPriceDrop);
        }

        public void Reload()
        {
            foreach (Tower tower in towers)
            {
                tower.Ammo.Fill();
            }
        }

        public void Reload(float ammo)
        {
            foreach (Tower tower in towers)
            {
                tower.Ammo.Fill(ammo);
            }
        }

        public void Clear()
        {
            towers.Clear();
        }
    }
}
