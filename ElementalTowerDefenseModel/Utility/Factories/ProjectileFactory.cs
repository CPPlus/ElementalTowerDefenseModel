using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElementalTowerDefenseModel
{
    public class ProjectileFactory
    {
        public static Projectile CreateProjectile(ProjectileType type)
        {
            Projectile projectile = null;
            switch (type)
            {
                case ProjectileType.ROCK: projectile = new Rock(); break;
                case ProjectileType.FIREBALL: projectile = new Fireball(); break;
            }
            return projectile;
        }
    }
}
