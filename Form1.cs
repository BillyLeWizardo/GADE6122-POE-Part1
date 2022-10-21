﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADE6122_POE_Part1
{
    public partial class frmARPG : Form
    {
        private GameEngine gameEngine;
        public frmARPG()
        {
            InitializeComponent();
        }

        private void frmARPG_Load(object sender, EventArgs e)
        {
            gameEngine = new GameEngine();
            
            refreshDisplay();
        }

        private void refreshDisplay()
        {
            gameEngine.GameMap.mapGen();
            lblHeroStats.Text = gameEngine.GameMap.Hero.ToString();

            for (int x = 0; x < gameEngine.GameMap.mapHeight; x++)
            {
                for (int y = 0; y < gameEngine.GameMap.mapWidth; y++)
                {
                    TextBox textBox = new TextBox();
                    textBox.Location = new Point(x * 30, y * 30);
                    textBox.Text = gameEngine.GameMap.charMap[y,x].ToString();
                    textBox.Size = new Size(25, 25);
                    pnlDisplay.Controls.Add(textBox);
                }
            }

            lstEnemies.Items.Clear();
            for (int x = 0; x < gameEngine.GameMap.totalEnemies; x++)
            {
                lstEnemies.Items.Add(gameEngine.GameMap.Enemies[x].ToString());
            }

            lblAttackMessage.Text = "";
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            gameEngine.movePlayer(Character.characterMovement.LEFT);
            refreshDisplay();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            gameEngine.movePlayer(Character.characterMovement.UP);
            refreshDisplay();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            gameEngine.movePlayer(Character.characterMovement.DOWN);
            refreshDisplay();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            gameEngine.movePlayer(Character.characterMovement.RIGHT);
            refreshDisplay();
        }
    }
}
