﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122_POE_Part1
{
    internal class EmptyTile : Tile
    {
        public EmptyTile(int emptyTileX, int emptyTileY) : base(emptyTileX, emptyTileY, '.')
        {

        }
    }
}
