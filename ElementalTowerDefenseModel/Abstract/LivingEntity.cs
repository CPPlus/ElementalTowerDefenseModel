using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementalTowerDefenseModel
{
    abstract class LivingEntity
    {
        public HealthComp HealthComp;

        private List<Projectile> incomingProjectiles;
        public bool WillDie {
            get
            {
                float accumulatedDamage = 0;
                foreach (Projectile projectile in incomingProjectiles)
                {
                    accumulatedDamage += projectile.AttackComp.Power.Points;
                }

                return accumulatedDamage >= HealthComp.Health.Points;
            }
        }

        public LivingEntity(float maxHealth)
        {
            HealthComp = new HealthComp(Math.Abs(maxHealth));

            incomingProjectiles = new List<Projectile>();
        }

        public void GetBeingShot(Projectile projectile)
        {
            incomingProjectiles.Add(projectile);
        }

        public void GetShot(Projectile projectile)
        {
            incomingProjectiles.Remove(projectile);
        }
    }
}
