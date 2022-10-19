using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122_POE_Part1
{
    abstract internal class Enemy : Character
    {
        Random rng = new Random();

        public Enemy(int enemyX, int enemyY, int enemyDamage, int enemyStartingHP, char enemySymbol) : base(enemyX,enemyY, enemySymbol)
        {

        }

        public override string ToString()
        {
            return "EnemyClassName at [X,Y] (Amount DMG)";
        }
    }
}
