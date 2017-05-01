using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElementalTowerDefenseModel
{
    public class TowerSpawner : IModel
    {
        public TowerType SelectedTowerType { get; set; }
        public bool IsInSpawnMode { get; set; }
    }
}
