using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122_POE_Part1
{
    internal class Hero : Character
    {
        EmptyTile emptyTile { get; set; }
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
                    if (characterVision[0] != emptyTile)
                    {
                        return characterMovement.NONE;
                    }
                    break;
                case characterMovement.DOWN:
                    if (characterVision[1] != emptyTile)
                    {
                        return characterMovement.NONE;
                    }
                    break;
                case characterMovement.LEFT:
                    if (characterVision[2] != emptyTile)
                    {
                        return characterMovement.NONE;
                    }
                    break;
                case characterMovement.RIGHT:
                    if (characterVision[3] != emptyTile)
                    {
                        return characterMovement.NONE;
                    }
                    break;
                default:
                    break;
            }
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Player Stats:" +
                $"HP: {characterHP}/{charcterMaxHP}" +
                $"Damage: {characterDamage}" +
                $"[{tileX},{tileY}]";
            //throw new NotImplementedException();
        }
    }
}
