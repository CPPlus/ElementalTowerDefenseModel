using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementalTowerDefenseModel
{
    class AttackComp : ICloneable
    {
        public Stat Power { get; private set; }
        public Stat Speed { get; private set; }

        public AttackComp(float power, float speed)
        {
            Power = new Stat(Math.Abs(power));
            Speed = new Stat(Math.Abs(speed));
        }

        public void Attack(LivingEntity livingEntity)
        {
            livingEntity.HealthComp.Health.Empty(Power.Points);
        }

        public object Clone()
        {
            return new AttackComp(Power.MaxPoints, Speed.MaxPoints);
        }
    }
}
