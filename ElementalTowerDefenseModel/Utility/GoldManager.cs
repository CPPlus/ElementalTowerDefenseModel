using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElementalTowerDefenseModel
{
    public class GoldManager : IModel
    {
        public PriceList PriceList { get; private set; }
        public float Gold { get; private set; }

        public GoldManager(float gold, PriceList priceList)
        {
            Gold = gold;
            PriceList = priceList;
        }

        public bool Spend(float gold)
        {
            if (CanSpend(gold))
            {
                Gold -= gold;
                return true;
            }

            return false;
        }

        public void Earn(float gold)
        {
            Gold += gold;
        }

        public bool CanSpend(float gold)
        {
            return gold <= Gold;
        }
    }
}
