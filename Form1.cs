using System;
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
        private Map gameMap { get; set; }
        private EmptyTile EmptyTile { get; set; }
        private Obstacle Obstacle { get; set; }
        public frmARPG()
        {
            InitializeComponent();

            gameMap = new Map(6, 15, 6, 15, 5);
        }

        private void frmARPG_Load(object sender, EventArgs e)
        {
            refreshDisplay();
        }

        public bool MovePlayer(Character.characterMovement direction)
        {
            switch (direction)
            {
                case Character.characterMovement.NONE:
                    break;
                case Character.characterMovement.UP:
                    break;
                case Character.characterMovement.DOWN:
                    break;
                case Character.characterMovement.LEFT:

                    break;
                case Character.characterMovement.RIGHT:
                    break;
                default:
                    break;
            }
            return true;
        }

        private void refreshDisplay()
        {
            char[,] tileChar = new char[gameMap.mapHeight, gameMap.mapWidth];

            for (int y = 0; y < gameMap.mapHeight; y++)
            {
                for (int x = 0; x < gameMap.mapWidth; x++)
                {
                    if (gameMap.TileMap[y,x] == EmptyTile)
                    {
                        tileChar[y, x] = '.';
                    }
                    if(gameMap.TileMap[y,x] == Obstacle)
                    {
                        tileChar[y, x] = 'X';
                    }
                }
            }

            for (int y = 0; y < gameMap.mapHeight; y++)
            {
                for (int x = 0; x < gameMap.mapWidth; x++)
                {
                    TextBox txtBox = new TextBox();
                    txtBox.Size = new Size(30, 30);
                    txtBox.Name = "txt" + x.ToString() + "_" + y.ToString();
                    txtBox.Text = tileChar[y,x].ToString();
                    txtBox.Location = new Point(x * 30, y * 30);
                    pnlDisplay.Controls.Add(txtBox);
                }
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            MovePlayer(Character.characterMovement.LEFT);
        }
    }
}
