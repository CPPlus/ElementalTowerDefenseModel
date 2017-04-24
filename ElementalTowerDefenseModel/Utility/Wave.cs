using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElementalTowerDefenseModel
{
    public class Wave
    {
        public List<Monster> Monsters { get; private set; }
        public bool IsDead
        {
            get
            {
                bool result = true;
                foreach (Monster monster in Monsters)
                    if (!monster.HealthComp.IsDead)
                        result = false;
                return result;
            }
        }

        public Wave() { }

        public void Add(Monster monster)
        {
            if (Monsters == null) Monsters = new List<Monster>();

            Monsters.Add(monster);
        }

        public bool Remove(Monster monster)
        {
            return Monsters.Remove(monster);
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