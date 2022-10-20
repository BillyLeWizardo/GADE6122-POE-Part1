using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122_POE_Part1
{
    public class EmptyTile : Tile
    {
        public EmptyTile(int emptyX, int emptyY) : base(emptyX, emptyY)
        {
            tileType = TileType.EMPTYTILE;
        }
    }
}
