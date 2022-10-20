using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122_POE_Part1
{
    abstract public class Tile
    {
        protected int tileX;
        public int TileX { get { return tileX; } set { tileX = value; } }


        protected int tileY;
        public int TileY { get { return tileY; } set { tileY = value; } }


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
