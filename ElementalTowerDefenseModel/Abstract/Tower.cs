using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElementalTowerDefenseModel
{
    public abstract class Tower : IModel
    {
        public TowerType Type { get; private set; }
        public Projectile Projectile;
        public Stat Ammo;
        public Stat Range;
        public Stat BaseAttackSpeed;
        public float AttackSpeed { get { return BaseAttackSpeed.Points + Projectile.AttackComp.Speed.Points; } }

        public Tower(Projectile projectile, float ammo, float range, float baseAttackSpeed, TowerType type)
        {
            Ammo = new Stat(Math.Abs(ammo));
            Range = new Stat(Math.Abs(range));
            Projectile = projectile;
            BaseAttackSpeed = new Stat(Math.Abs(baseAttackSpeed));
            Type = type;
        }

        public Projectile Shoot(Monster monster)
        {
            if (Ammo.HasPoints(Projectile.ShotCost.Points))
            {
                Ammo.Empty(Projectile.ShotCost.Points);

                Projectile projectile = Projectile.Clone();
                monster.GetBeingShot(projectile);
                return projectile;
            }

            return null;
        }
    }
}
