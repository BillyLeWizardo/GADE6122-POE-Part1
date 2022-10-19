using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122_POE_Part1
{
    abstract internal class Tile
    {
        public int tileX { get; set; }
        public int tileY { get; set; }

        public enum TileType
        {
            HERO,
            ENEMY,
            GOLD,
            WEAPON
        }

        public Tile(int x, int y)
        {
            tileX = x;
            tileX = y;
        }
    }
}
