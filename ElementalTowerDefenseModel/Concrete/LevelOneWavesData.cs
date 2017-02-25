using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElementalTowerDefenseModel
{
    public class LevelOneWavesData : WavesData
    {
        public LevelOneWavesData() : base()
        {

        }

        protected override void SetData()
        {
            List<WaveData> data = new List<WaveData>();

            WaveData waveData;

            // First wave.
            waveData = new WaveData();
            waveData.AddMonsterSequence(MonsterType.CRAWLING_HORROR, 2);
            data.Add(waveData);

            // Second wave.
            waveData = new WaveData();
            waveData.AddMonsterSequence(MonsterType.RUNNER, 2);
            waveData.AddMonsterSequence(MonsterType.CRAWLING_HORROR, 1);
            data.Add(waveData);

            // Third wave.
            waveData = new WaveData();
            waveData.AddMonsterSequence(MonsterType.CRAWLING_HORROR, 5);
            data.Add(waveData);

            // Fourth wave.
            waveData = new WaveData();
            waveData.AddMonsterSequence(MonsterType.RUNNER, 3);
            data.Add(waveData);

            Data = data.ToArray();
        }
    }
}
