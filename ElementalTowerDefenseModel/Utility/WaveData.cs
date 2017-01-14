using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementalTowerDefenseModel
{
    public class WaveData
    {
        private Dictionary<MonsterType, int> monsterSequencesData;

        public int Count {
            get
            {
                int totalMonsterCount = 0;
                foreach (KeyValuePair<MonsterType, int> monsterSequenceData in monsterSequencesData)
                {
                    totalMonsterCount += monsterSequenceData.Value;
                }
                return totalMonsterCount;
            }
        }

        public MonsterType[] MonsterTypes
        {
            get
            {
                List<MonsterType> monsterTypes = new List<MonsterType>();
                foreach (KeyValuePair<MonsterType, int> monsterTypeFrequency in monsterSequencesData)
                    for (int i = 0; i < monsterTypeFrequency.Value; i++)
                        monsterTypes.Add(monsterTypeFrequency.Key);
                return monsterTypes.ToArray();
            }
        }

        public WaveData()
        {
            monsterSequencesData = new Dictionary<MonsterType, int>();
        }

        public void AddMonsterSequence(MonsterType type, int count)
        {
            if (monsterSequencesData.ContainsKey(type))
            {
                monsterSequencesData[type] += count;
            } else
            {
                monsterSequencesData.Add(type, count);
            }
        }

        public void AddMonster(MonsterType type)
        {
            AddMonsterSequence(type, 1);
        }
    }
}
