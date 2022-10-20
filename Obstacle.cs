using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122_POE_Part1
{
    internal class Obstacle : Tile
    {
        public Obstacle(int x, int y) : base(x, y)
        {
            Type = TileType.OBSTACLE;
        }
    }
}
