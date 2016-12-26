﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementalTowerDefenseModel
{
    abstract class Monster : LivingEntity
    {
        public AttackComp AttackComp;
        public MovementComp MovementComp;
        public PriceComp PriceComp { get; private set; }

        public Monster(
            float maxHealth, 
            float attackPower, 
            float attackSpeed,
            float movementSpeed,
            float price) : base(Math.Abs(maxHealth))
        {
            AttackComp = new AttackComp(
                Math.Abs(attackPower), 
                Math.Abs(attackSpeed));

            MovementComp = new MovementComp(Math.Abs(movementSpeed));

            PriceComp = new PriceComp(Math.Abs(price));
        }
    }
}
