using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122_POE_Part1
{
    internal class Hero : Character
    {
        public Hero( int heroX, int heroY, int heroHP) : base(heroX, heroY, 'H')
        {
            characterHP = heroHP;
            charcterMaxHP = heroHP;
            characterDamage = 2;
        }

        public override characterMovement ReturnMove(characterMovement move)
        {
            switch (move)
            {
                case characterMovement.NONE:
                    break;
                case characterMovement.UP:
                    if (characterVision[0] = (Tile))
                    {

                    }
                    break;
                case characterMovement.DOWN:
                    break;
                case characterMovement.LEFT:
                    break;
                case characterMovement.RIGHT:
                    break;
                default:
                    break;
            }
            throw new NotImplementedException();
        }
    }
}
