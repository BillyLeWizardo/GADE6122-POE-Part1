using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122_POE_Part1
{
    public class Hero : Character
    {
        public Hero( int heroX, int heroY, int heroHP) : base(heroX, heroY)
        {
            characterHP = heroHP;
            characterMaxHP = characterHP;
            characterDamage = 2;
            tileType = TileType.HERO;
        }

        public override characterMovement ReturnMove(characterMovement move)
        {
            if (characterVision[(int)move].tileType != TileType.EMPTYTILE)
            {
                return characterMovement.NONE;
            }
            else
                return move;
        }

        public override string ToString()
        {
            return $"Player Stats:\n" +
                   $"HP: {characterHP}/{characterMaxHP} \n" +
                   $"Damage: {characterDamage} \n" +
                   $"Location: [{tileX},{tileY}] \n"+
                   $"Gold Purse: {characterGoldPurse}";
        }
    }
}
