using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122_POE_Part1
{
    abstract public class Enemy : Character
    {
        protected Random rnJesus = new Random();
        protected TileType enemyType { get; set; }
        public int enemyArr { get; set; }
        public Enemy(int enemyX, int enemyY, int enemyArr) : base(enemyX, enemyY)
        {  
            this.enemyArr = enemyArr;
        }

        public override string ToString()
        {
            return $"{enemyType} | Enemy HP: {characterHP}/{characterMaxHP} | Enemy Damage: {characterDamage} | Location: [{tileX},{tileY}]";
        }
    }
}
