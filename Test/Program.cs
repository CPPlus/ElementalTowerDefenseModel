using ElementalTowerDefenseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        private static int a;

        static void Main(string[] args)
        {
            Tower tower = new EarthTower();
            Monster monster = new CrawlingHorror();
            Projectile projectile = tower.Shoot(monster);
        }

        static void PrintVitalInfo(LivingEntity entity)
        {
            Console.WriteLine("Health: " + entity.HealthComp.Health.Points);
            Console.WriteLine("Is Dead: " + entity.HealthComp.IsDead);
        }
    }
}
