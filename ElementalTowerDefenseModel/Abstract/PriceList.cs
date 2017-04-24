using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElementalTowerDefenseModel
{
    public abstract class PriceList
    {
        private Dictionary<TowerType, float> towerPrices = new Dictionary<TowerType, float>();
        private Dictionary<MonsterType, float> monsterPrices = new Dictionary<MonsterType, float>();

        public PriceList()
        {
            AddTowerPrices(towerPrices);
            AddMonsterPrices(monsterPrices);
        }

        public float GetPrice(TowerType towerType)
        {
            return GetPrice(towerType, towerPrices);
        }

        public float GetPrice(MonsterType monsterType)
        {
            return GetPrice(monsterType, monsterPrices);
        }

        private float GetPrice<T>(T key, Dictionary<T, float> prices)
        {
            float price;
            bool priceExists = prices.TryGetValue(key, out price);
            if (!priceExists)
                throw new Exception("Price doesn't exist.");
            return price;
        }

        protected abstract void AddTowerPrices(Dictionary<TowerType, float> towerPrices);
        protected abstract void AddMonsterPrices(Dictionary<MonsterType, float> monsterPrices);
    }
}
