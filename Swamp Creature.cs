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
            rng
        }
    }
}
