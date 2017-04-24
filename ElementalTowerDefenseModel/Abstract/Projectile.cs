using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElementalTowerDefenseModel
{
    public abstract class Projectile : IModel
    {
        public ProjectileType Type { get; private set; }
        public AttackComp AttackComp { get; private set; }
        public Stat ShotCost { get; private set; }
        
        public Projectile(float attackPower, float attackSpeed, float shotCost, ProjectileType type)
        {
            AttackComp = new AttackComp(
                Math.Abs(attackPower),
                Math.Abs(attackSpeed));
            Type = type;
            ShotCost = new Stat(Math.Abs(shotCost));
        }

        public Projectile Clone()
        {
            return ProjectileFactory.CreateProjectile(Type);
        }
    } 
}
