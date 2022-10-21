using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122_POE_Part1
{
    public class Map
    {

        //VARIABLES
        private Hero hero;
        public Hero Hero { get { return hero; } set { hero = value; } }
        
        
        private Enemy[] enemies;
        public Enemy[] Enemies { get { return enemies; } set { enemies = value; } }

        private Item[] items;
        public Item[] itemsAccessor { get { return items; } set { items = value; } }


        private Random rnjesus = new Random();
        public int mapWidth;
        public int mapHeight;

        public int totalEnemies { get; set; }
        private int enemyCounter;
        public int totalItems { get; set; }
        public int itemCounter;
        public static Tile[,] TileMap { get; set; }
        public char[,] charMap;

        public Map(int minMapWidth, int maxMapWidth, int minMapHeight, int maxMapHeight, int numOfEnemies, int amountOfGoldDrops)
        {
            mapHeight = rnjesus.Next(minMapHeight, maxMapHeight);
            mapWidth= rnjesus.Next(minMapWidth, maxMapWidth);

            TileMap = new Tile[mapWidth, mapHeight];
            
            for (int x = 0; x < TileMap.GetLength(0); x++)
            {
                for (int y = 0; y < TileMap.GetLength(1); y++)
                {
                    if (x == 0 || x == mapWidth - 1)
                    {
                        TileMap[x, y] = new Obstacle(x, y);
                    }
                    else 
                    if (y == 0 || y == mapHeight - 1)
                    {
                        TileMap[x, y] = new Obstacle(x, y);
                    }
                    else
                    {
                        TileMap[x, y] = new EmptyTile(x, y);
                    }
                }
            }

            totalEnemies = numOfEnemies;
            Enemies = new Enemy[totalEnemies]; //Init the Enemy array size

            for (enemyCounter = 0; enemyCounter < totalEnemies; enemyCounter++)
            {
                int randomEnemy = rnjesus.Next(2);
                switch (randomEnemy)
                {
                    case 0:
                        Create(Tile.TileType.SWAMP_CREATURE);
                        break;
                    case 1:
                        Create(Tile.TileType.MAGE);
                        break;
                    default:
                        break;
                }
            }

            totalItems = amountOfGoldDrops;
            items = new Item[amountOfGoldDrops]; //Initializes items Arr. Only gold exists as items as of now.

            for (itemCounter = 0; itemCounter < totalItems; itemCounter++)
            {
                Create(Tile.TileType.GOLD);
            }

            Create(Tile.TileType.HERO);
            
            UpdateVision();
        }

        public Tile Create(Tile.TileType tileType)
        {
            int randomX;
            int randomY;

            do
            {
                randomX = rnjesus.Next(mapWidth - 1);
                randomY = rnjesus.Next(mapHeight - 1);
            }
            while (TileMap[randomX, randomY].tileType != Tile.TileType.EMPTYTILE);
            if (tileType == Tile.TileType.SWAMP_CREATURE)
            {
                Enemies[enemyCounter] = new Swamp_Creature(randomX, randomY, enemyCounter);
                TileMap[randomX, randomY] = Enemies[enemyCounter];
            }
            else 
            if (tileType == Tile.TileType.MAGE)
            {
                Enemies[enemyCounter] = new Mage(randomX, randomY, enemyCounter);
                TileMap[randomX, randomY] = Enemies[enemyCounter];
            }
            else
            if (tileType == Tile.TileType.HERO)
            {
                Hero = new Hero(randomY, randomX, 20);
                TileMap[randomX, randomY] = Hero;
            }
            else
                if (tileType == Tile.TileType.GOLD)
            {
                itemsAccessor[itemCounter] = new Gold(randomX, randomY);
            }
            return TileMap[randomX, randomY];

        }

        public void UpdateVision()
        {
            Hero.characterVision[0] = TileMap[Hero.TileX, Hero.TileY];
            Hero.characterVision[1] = TileMap[Hero.TileX - 1, Hero.TileY];
            Hero.characterVision[2] = TileMap[Hero.TileX + 1, Hero.TileY];
            Hero.characterVision[3] = TileMap[Hero.TileX, Hero.TileY - 1];
            Hero.characterVision[4] = TileMap[Hero.TileX, Hero.TileY + 1];

            for (int c = 0; c < totalEnemies; c++)
            {
                Enemies[c].characterVision[0] = TileMap[Enemies[c].TileX - 1,Enemies[c].TileY];
                Enemies[c].characterVision[1] = TileMap[Enemies[c].TileX + 1,Enemies[c].TileY];
                Enemies[c].characterVision[2] = TileMap[Enemies[c].TileX,Enemies[c].TileY - 1];
                Enemies[c].characterVision[3] = TileMap[Enemies[c].TileX,Enemies[c].TileY + 1];
            }
        }

        public void mapGen()
        {
            charMap = new char[mapWidth, mapHeight];
            for (int x = 0; x < TileMap.GetLength(0); x++)
            {
                for (int y = 0; y < TileMap.GetLength(1); y++)
                {
                    charMap[x, y] = (char)TileMap[x, y].tileType;
                }
            }
        }

        public Item GetItemAtPosition(int x, int y)
        {
            int counter = 0;
            foreach (Item item in items)
            {
                if (item.TileX == x && item.TileX == y)
                {
                    return item;
                    items[counter] = null;
                }
                counter++;
            }
            return null;
        }
    }
}
