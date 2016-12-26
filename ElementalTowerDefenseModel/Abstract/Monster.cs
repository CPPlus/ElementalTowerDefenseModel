using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementalTowerDefenseModel
{
    public abstract class Monster : LivingEntity
    {
        public AttackComp AttackComp;
        public MovementComp MovementComp;
        public Stat KillReward { get; private set; }

        public Monster(
            float maxHealth, 
            float attackPower, 
            float movementSpeed,
            float killReward) : base(Math.Abs(maxHealth))
        {
            AttackComp = new AttackComp(
                Math.Abs(attackPower), 
                0);

            MovementComp = new MovementComp(Math.Abs(movementSpeed));

            KillReward = new Stat(
                Math.Abs(killReward));
        }
    }
}
