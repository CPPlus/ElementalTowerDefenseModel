using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementalTowerDefenseModel
{
    public class GoldManager
    {
        public float Gold { get; private set; }

        public GoldManager(float gold)
        {
            Gold = gold;
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
