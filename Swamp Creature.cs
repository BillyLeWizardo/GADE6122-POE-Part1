using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122_POE_Part1
{
    internal class Swamp_Creature : Enemy
    {
        public Swamp_Creature(int swampCreatureX, int swampCreatureY) : base(swampCreatureX, swampCreatureY, 1, 10, 'S')
        {

        }

        public override characterMovement ReturnMove(characterMovement move = characterMovement.NONE)
        {
            int randomDirection = rng.Next(5);
            switch (randomDirection)
            {
                    case 0:
                        return characterMovement.NONE;
                    case 1:
                        return characterMovement.UP;
                    case 2:
                        return characterMovement.DOWN;
                    case 3:
                        return characterMovement.LEFT;
                    case 4:
                        return characterMovement.RIGHT;
                default:
                    break;
            }
            throw new NotImplementedException();
        }
    }
}
