using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElementalTowerDefenseModel
{
    public class TowerSelector : IModel
    {
        public TowerType SelectedTowerType { get; private set; }

        public void Select(TowerType type)
        {
            SelectedTowerType = type;
        }
    }
}
