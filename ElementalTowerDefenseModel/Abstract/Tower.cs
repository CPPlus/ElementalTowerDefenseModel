using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementalTowerDefenseModel
{
    public abstract class Tower
    {
        public Projectile Projectile;
        public Stat Ammo;
        public Stat ShotCost;
        public Stat Range;
        public Stat Price;

        public Tower(Projectile projectile, float ammo, float shotCost, float range, float price)
        {
            Ammo = new Stat(Math.Abs(ammo));
            ShotCost = new Stat(shotCost);
            Range = new Stat(Math.Abs(range));
            Price = new Stat(Math.Abs(price));
        }

        public Projectile Shoot(Monster monster)
        {
            if (Ammo.HasPoints(ShotCost.Points))
            {
                Ammo.Empty(ShotCost.Points);

                Projectile projectile = null;
                projectile.Clone(Projectile);
                
                monster.GetBeingShot(projectile);
                return projectile;
            }

            return null;
        }
    }
}
