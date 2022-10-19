using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122_POE_Part1
{
    public class GameEngine
    {
        private Map gameMap { get; }

        public GameEngine()
        {
            gameMap = new Map(10, 10, 10, 10, 5);
        }

        public bool MovePlayer(Character.characterMovement direction)
        {
            return true;
        }
    }
}
