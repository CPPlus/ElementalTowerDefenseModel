using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElementalTowerDefenseModel
{
    public abstract class WavesData
    {
        public static readonly float WAVE_SPAWN_INTERVAL = 3;
        public static readonly float MONSTER_SPAWN_INTERVAL = 1.25f;

        public WavesData()
        {
            SetData();
        }

        public WaveData[] Data { get; protected set; }
        protected abstract void SetData();
    }
}
