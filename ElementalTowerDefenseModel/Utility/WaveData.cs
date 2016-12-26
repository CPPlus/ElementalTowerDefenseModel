using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementalTowerDefenseModel
{
    public class WaveData
    {
        private Dictionary<Type, int> monsterSequencesData;
        public int Count {
            get
            {
                int totalMonsterCount = 0;
                foreach (KeyValuePair<Type, int> monsterSequenceData in monsterSequencesData)
                {
                    totalMonsterCount += monsterSequenceData.Value;
                }
                return totalMonsterCount;
            }
        }

        public WaveData()
        {
            monsterSequencesData = new Dictionary<Type, int>();
        }

        public void AddMonsterSequence(Type type, int count)
        {
            if (monsterSequencesData.ContainsKey(type))
            {
                monsterSequencesData[type] += count;
            } else
            {
                monsterSequencesData.Add(type, count);
            }
        }

        public void AddMonster(Type type)
        {
            AddMonsterSequence(type, 1);
        }
    }
}
