using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GADE6122_POE_Part1
{
    abstract internal class Character : Tile
    {
        //VARIABLES
        public int characterHP { get; }
        public int charcterMaxHP{ get; }
        public int characterDamage{ get; }
        public Tile[] characterVision{ get; }
        public enum characterMovement
        {
            NONE,
            UP,
            DOWN,
            LEFT,
            RIGHT
        }

        //METHODS
        public Character(int characterX, int characterY, char symbol) : base(characterX, characterY)
        {

        }

        public virtual void Attack(Character target)
        {

        }
    }
}
