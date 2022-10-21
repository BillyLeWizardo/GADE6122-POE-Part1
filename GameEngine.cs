using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122_POE_Part1
{
    public class GameEngine
    {
        private Map gameMap;
        public Map GameMap { get { return gameMap; } set { gameMap = value; } }

        public GameEngine()
        {
            gameMap = new Map(10, 15, 6, 10, 5, 5);
        }

        public void movePlayer(Character.characterMovement direction)
        {
            Map.TileMap[gameMap.Hero.TileY, gameMap.Hero.TileX] = new EmptyTile(gameMap.Hero.TileX, gameMap.Hero.TileY);

            gameMap.Hero.Move(gameMap.Hero.ReturnMove(direction));

            //if (Map.TileMap[gameMap.Hero.TileY,gameMap.Hero.TileX].tileType == Tile.TileType.GOLD)
            //{
            //    gameMap.GetItemAtPosition(gameMap.Hero.TileX, gameMap.Hero.TileY);
            //    gameMap.Hero.Pickup();
            //}

            Map.TileMap[gameMap.Hero.TileY, gameMap.Hero.TileX] = gameMap.Hero;

            gameMap.UpdateVision();
        }

        public void checkIfDead(Enemy enemy)
        {
            if (enemy.IsDead())
            {
                for (int i = 0; i < gameMap.totalEnemies - 1; i++)
                {
                    gameMap.Enemies[i] = gameMap.Enemies[i + 1];
                    gameMap.Enemies[i].enemyArr -= 1;
                }
                gameMap.totalEnemies -= 1;

                Map.TileMap[enemy.TileY, enemy.TileX] = new EmptyTile(enemy.TileX, enemy.TileY);
            }
        }

        public void checkIfDead(Hero hero)
        {
            if (hero.IsDead())
            {
                Map.TileMap[hero.TileY,hero.TileX] = new EmptyTile(hero.TileX, hero.TileY);
            }
        }

        public void moveAllEnemies()
        {
            for (int enemyCounter = 0; enemyCounter < gameMap.totalEnemies; enemyCounter++)
            {
                Map.TileMap[gameMap.Enemies[enemyCounter].TileY, gameMap.Enemies[enemyCounter].TileX] = new EmptyTile(gameMap.Enemies[enemyCounter].TileX, gameMap.Enemies[enemyCounter].TileY);

                gameMap.Enemies[enemyCounter].Move(gameMap.Enemies[enemyCounter].ReturnMove());

                gameMap.UpdateVision();
            }
        }

        public void enemyAttack()
        {
            for (int enemyCounter = 0; enemyCounter < gameMap.totalEnemies; enemyCounter++)
            {
                if (gameMap.Enemies[enemyCounter].CheckRange(gameMap.Hero))
                {
                    gameMap.Enemies[enemyCounter].Attack(gameMap.Hero);
                }
            }
            checkIfDead(gameMap.Hero);
        }


    }
}
