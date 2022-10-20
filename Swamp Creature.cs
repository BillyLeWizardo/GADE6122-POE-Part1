using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122_POE_Part1
{
    internal class Swamp_Creature : Enemy
    {
        public Swamp_Creature(int swampX, int swampY, int enemyArr) : base(swampX, swampY, enemyArr)
        {
            characterHP = 10;
            characterMaxHP = characterHP;
            characterDamage = 1;
            enemyType = TileType.SWAMP_CREATURE;
            tileType = TileType.SWAMP_CREATURE;
        }

        public override characterMovement ReturnMove(characterMovement move = characterMovement.NONE)
        {
            int randomDirection;
            for (int i = 0; i < 4; i++)
            {
                randomDirection = rnJesus.Next(1, 5);
                move = (characterMovement)randomDirection;
                if (characterVision[(int)move].tileType == TileType.EMPTYTILE)
                {
                    return move;
                }
            }
            return characterMovement.NONE;
        }
    }
}
