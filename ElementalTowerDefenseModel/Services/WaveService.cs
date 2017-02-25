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

        public WaveService()
        {
            WavesSpawned = 0;
        }

        public Wave Spawn(MonsterType type, int count)
        {
            Wave wave = new Wave();
            for (int i = 0; i < count; i++)
            {
                Monster monster = Instantiate(type);
                if (monster != null)
                    wave.Add(Instantiate(type));
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
                Monster monster = Instantiate(type);
                if (monster != null)
                    wave.Add(Instantiate(type));
            }
            CurrentWave = wave;
            WavesSpawned++;
            return wave;
        }

        private Monster Instantiate(MonsterType type)
        {
            Monster monster = null;
            switch(type)
            {
                case MonsterType.CRAWLING_HORROR: monster = new CrawlingHorror(); break;
                case MonsterType.RUNNER: monster = new Runner(); break;
            }
            return monster;
        }
    }
}
