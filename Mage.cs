using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122_POE_Part1
{
    public class Mage : Enemy
    {
        public Mage(int mageX, int mageY, int enemyArr) : base(mageX, mageY, enemyArr)
        {
            characterHP = 5;
            characterMaxHP = characterHP;
            characterDamage = 5;
        }

        public override characterMovement ReturnMove(characterMovement move = characterMovement.NONE)
        {
            return move = characterMovement.NONE;
            throw new NotImplementedException();
        }

        //public override bool CheckRange(Character target) //target should be the mage itself
        //{
        //    for (int y = -1; y <= 1; y++)
        //    {
        //        for (int x = -1; x < 1; x++)
        //        {
        //            if (== )
        //            {
                        
        //            }
        //        }
        //    }
        //    return base.CheckRange(target.x);
        //}
    }
}
