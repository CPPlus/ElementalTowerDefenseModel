using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElementalTowerDefenseModel
{
    public class Wave
    {
        public List<Monster> Monsters { get; private set; }
        public bool IsDead { get; private set; }
        public WaveData WaveData { get; private set; }

        public void Add(Monster monster)
        {
            Monsters.Add(monster);
        }

        public void Kill()
        {
            foreach (Monster monster in Monsters)
            {
                monster.HealthComp.Die();
            }
        }
    }
}