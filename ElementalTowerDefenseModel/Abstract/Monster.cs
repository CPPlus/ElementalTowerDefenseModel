using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElementalTowerDefenseModel
{
    public abstract class Monster : LivingEntity
    {
        public MonsterType Type { get; private set; }
        public TerrainType Terrain { get; private set; }
        public AttackComp AttackComp;
        public MovementComp MovementComp;

        public Monster(
            float maxHealth,
            float attackPower, 
            float movementSpeed,
            MonsterType type,
            TerrainType terrain) : base(Math.Abs(maxHealth))
        {
            AttackComp = new AttackComp(
                Math.Abs(attackPower), 
                0);

            MovementComp = new MovementComp(Math.Abs(movementSpeed));

            Type = type;
            Terrain = terrain;
        }
    }
}
