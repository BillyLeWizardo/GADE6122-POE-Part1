using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122_POE_Part1
{
    abstract public class Tile
    {
        public int tileX { get; set; }
        public int tileY { get; set; }

        public enum TileType
        {
            HERO = 'H',
            ENEMY = 'E',
            GOLD = 'G',
            WEAPON = 'W',
            EMPTYTILE = '.',
            OBSTACLE = 'X',
            SWAMPCREATURE = 'C' 
        }

        public Tile(int x, int y, char tileType)
        {
            tileX = x;
            tileY = y;
        }
    }
}
