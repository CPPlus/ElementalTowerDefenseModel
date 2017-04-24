using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElementalTowerDefenseModel
{
    public class WaveService
    {
        public int WavesSpawned { get; private set; }
        public Wave CurrentWave { get; private set; }

        private GoldManager goldManager;
        private List<Monster> collectedRewards = new List<Monster>();

        public WaveService(GoldManager goldManager)
        {
            WavesSpawned = 0;
            this.goldManager = goldManager;
        }

        public Wave Spawn(MonsterType type, int count)
        {
            Wave wave = new Wave();
            for (int i = 0; i < count; i++)
            {
                Monster monster = MonsterFactory.CreateMonster(type);
                if (monster != null)
                    wave.Add(monster);
            }
            CurrentWave = wave;
            WavesSpawned++;
            return wave;
        }

        public Wave Spawn(WaveData data)
        {
            Wave wave = new Wave();
            MonsterType[] monsterTypes = data.MonsterTypes;
            foreach (MonsterType type in monsterTypes)
            {
                Monster monster = MonsterFactory.CreateMonster(type);
                if (monster != null)
                    wave.Add(monster);
            }
            CurrentWave = wave;
            WavesSpawned++;
            return wave;
        }

        public void CollectKillRewards()
        {
            if (CurrentWave == null) return;

            foreach (Monster monster in CurrentWave.Monsters)
            {
                if (monster.HealthComp.IsDead)
                {
                    if (!collectedRewards.Contains(monster))
                    {
                        collectedRewards.Add(monster);
                        goldManager.Earn(goldManager.PriceList.GetPrice(monster.Type));
                    }
                }
            }
        }
    }
}
