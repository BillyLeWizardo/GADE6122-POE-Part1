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
        private Enemy Enemy { get; set; }

        private EmptyTile EmptyTile { get; set; }
        private Swamp_Creature swampCreature { get; set; }
        private int mapWidth { get; set; }
        private int mapHeight { get; set; }
        private Random rng = new Random();

        public Map(int minMapWidth, int maxMapWidth, int minMapHeight, int maxMapHeight, int numOfEnemies)
        {
            mapHeight = rng.Next(minMapHeight, maxMapHeight);
            mapWidth= rng.Next(minMapWidth, maxMapWidth);

            TileMap = new Tile[mapHeight, mapWidth];

            Enemies = new Enemy[numOfEnemies];

            Create(Tile.TileType.HERO);

            foreach (var enemy in Enemies)
            {
                Create(Tile.TileType.SWAMPCREATURE);
            }

            //UpdateVision();
        }

        public void UpdateVision()
        {
            Hero.characterVision[0] = TileMap[Hero.tileY - 1, Hero.tileX]; // North
            Hero.characterVision[1] = TileMap[Hero.tileY + 1, Hero.tileX]; // South
            Hero.characterVision[2] = TileMap[Hero.tileY, Hero.tileX -1]; // West
            Hero.characterVision[3] = TileMap[Hero.tileY, Hero.tileX + 1]; // East
            Hero.characterVision[4] = TileMap[Hero.tileY, Hero.tileX]; // Current

            Enemy.characterVision[0] = TileMap[Enemy.tileY - 1, Enemy.tileX]; // North
            Enemy.characterVision[1] = TileMap[Enemy.tileY + 1, Enemy.tileX]; // South
            Enemy.characterVision[2] = TileMap[Enemy.tileY, Enemy.tileX - 1]; // West
            Enemy.characterVision[3] = TileMap[Enemy.tileY, Enemy.tileX + 1]; // East
            Enemy.characterVision[4] = TileMap[Enemy.tileY, Enemy.tileX]; // Current
        }

        private Tile Create(Tile.TileType tileType)
        {
            int randomX = rng.Next(mapWidth - 1);
            int randomY = rng.Next(mapHeight - 1);

            switch (tileType)
            {
                case Tile.TileType.HERO:
                    while (TileMap[randomY,randomX] != EmptyTile)
                    {
                        randomX = rng.Next(mapWidth - 1);
                        randomY = rng.Next(mapHeight - 1);
                    }
                    return TileMap[randomY, randomX] = Hero;
                //case Tile.TileType.ENEMY:
                //    while (TileMap[randomY, randomX] != EmptyTile)
                //    {
                //        randomX = rng.Next(mapWidth - 1);
                //        randomY = rng.Next(mapHeight - 1);
                //    }
                //    return TileMap[randomY, randomX] = Enemy;
                //case Tile.TileType.GOLD:
                //    break;
                //case Tile.TileType.WEAPON:
                //    break;
                //case Tile.TileType.EMPTYTILE:
                //    break;
                //case Tile.TileType.OBSTACLE:
                //    break;
                case Tile.TileType.SWAMPCREATURE:
                    while (TileMap[randomY, randomX] != EmptyTile)
                    {
                        randomX = rng.Next(mapWidth - 1);
                        randomY = rng.Next(mapHeight - 1);
                    }
                    return TileMap[randomY, randomX] = swampCreature;

            }
            return TileMap[randomY, randomX] = EmptyTile;

        }
    }
}
