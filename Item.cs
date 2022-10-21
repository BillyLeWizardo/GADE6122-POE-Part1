using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122_POE_Part1
{
    abstract public class Item : Tile
    {
        public Item(int itemX, int itemY) : base(itemX, itemY)
        {

        }

        public enum ItemType
        {
            GOLD
        }

        public ItemType itemType;

        public abstract override string ToString();
    }
}
