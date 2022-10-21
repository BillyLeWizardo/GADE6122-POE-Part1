using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122_POE_Part1
{
    public class Gold : Item
    {
        private int goldDropAmount;

        public int goldDropAmountAccessor
        {
            get { return goldDropAmount; }
        }

        private Random goldRng = new Random();

        public Gold(int goldX, int goldY) : base(goldX, goldY)
        {
            goldDropAmount = goldRng.Next(1, 6);
            itemType = ItemType.GOLD;
            tileType = TileType.GOLD;
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
