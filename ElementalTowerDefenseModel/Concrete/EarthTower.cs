using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementalTowerDefenseModel.Concrete
{
    public class EarthTower : Tower
    {
        public EarthTower() : base(new Rock(), 100, 2, 7, 75)
        {
        }
    }
}
