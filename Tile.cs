using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122_POE_Part1
{
    abstract public class Tile
    {
        protected int tileX { get; set; }
        protected int tileY { get; set; }
        public enum TileType
        {
            HERO = 'H',
            SWAMP_CREATURE = 'C',
            GOLD = 'G',
            WEAPON = '|',
            OBSTACLE = 'X',
            EMPTYTILE = '.',  
        }

        public Tile(int tileX, int tileY)
        {
            this.tileX = tileX;
            this.tileY = tileY;
        }
        public TileType tileType { get; set; }
    }
}
