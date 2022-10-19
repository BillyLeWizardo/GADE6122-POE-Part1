using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122_POE_Part1
{
    internal class Map
    { 

        //VARIABLES
        private Tile[,] TileMap { get; set; }
        private Hero Hero { get; set; }
        private Enemy[] Enemies { get; set; }
        private int mapWidth, mapHeight;
        private Random rng;

        public Map(int minMapWidth, int maxMapWidth, int minMapHeight, int maxMapHeight, int numOfEnemies)
        {
            mapHeight = rng.Next(minMapHeight, maxMapHeight);
            mapHeight = rng.Next(minMapWidth, maxMapWidth);

            TileMap = new Tile[mapHeight, mapWidth];

            Enemies = new Enemy[numOfEnemies];

            //Create(hero);

            foreach (var enemy in Enemies)
            {
                //Create(enemy);
            }

            //UpdateVision();
        }
    }
}
