using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElementalTowerDefenseModel
{
    public class Fireball : Projectile
    {
        public Fireball() : base(6, 1, 10, ProjectileType.FIREBALL)
        {
        }
    }
}
