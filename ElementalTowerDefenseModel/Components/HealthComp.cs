using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementalTowerDefenseModel
{
    public class HealthComp
    {
        public Stat Health { get; private set; }
        public bool IsDead {
            get
            {
                return Health.IsEmpty;
            }
        }

        public HealthComp(float maxHealth)
        {
            Health = new Stat(Math.Abs(maxHealth));
        }

        public void Die()
        {
            Health.Empty();
        }
    }
}
