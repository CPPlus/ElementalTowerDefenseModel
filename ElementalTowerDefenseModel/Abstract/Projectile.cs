using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElementalTowerDefenseModel
{
    public abstract class Projectile
    {
        public AttackComp AttackComp { get; private set; }
        
        public Projectile(float attackPower, float attackSpeed)
        {
            AttackComp = new AttackComp(
                Math.Abs(attackPower),
                Math.Abs(attackSpeed));
        }

        public void Clone(Projectile source)
        {
            AttackComp = (AttackComp)source.AttackComp.Clone();
        }
    } 
}
