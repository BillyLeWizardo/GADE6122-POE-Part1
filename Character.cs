using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GADE6122_POE_Part1
{
    abstract public class Character : Tile
    {
        //VARIABLES
        protected int characterHP { get; set; }
        protected int charcterMaxHP{ get; set; }
        protected int characterDamage{ get; set; }
        public Tile[] characterVision{ get; set; } = new Tile[5];
        public enum characterMovement
        {
            NONE,
            UP,
            DOWN,
            LEFT,
            RIGHT
        }

        //METHODS
        public Character(int characterX, int characterY, char symbol) : base(characterX, characterY, 'O')
        {

        }

        public virtual void Attack(Character target)
        {
            target.characterHP -= characterDamage;
        }

        public bool IsDead()
        {
            if (characterHP < 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public virtual bool CheckRange(Character target)
        {
            if (DistanceTo(target) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Used by CheckRange.
        /// Determines the absolute distance between a character and its target.
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        private int DistanceTo(Character target)
        {
            int absoluteDistance;
            int xDistance;
            int yDistance;

            xDistance = tileX - target.tileX;
            if (xDistance < 0)
            {
                xDistance *= -1;
            }

            yDistance = tileY - target.tileY;
            if (yDistance < 0)
            {
                yDistance *= -1;
            }

            absoluteDistance = xDistance + yDistance;

            return absoluteDistance;
        }

        public void Move(characterMovement move)
        {
            switch (move)
            {
                case characterMovement.NONE:
                    break;
                case characterMovement.UP:
                    tileY -= 1;
                    break;
                case characterMovement.DOWN:
                    tileY += 1;
                    break;
                case characterMovement.LEFT:
                    tileX -= 1;
                    break;
                case characterMovement.RIGHT:
                    tileX += 1;
                    break;
                default:
                    break;
            }
        }

        public abstract characterMovement ReturnMove(characterMovement move = 0);

        public abstract override string ToString();
    }
}
