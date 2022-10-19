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
        public frmARPG()
        {
            InitializeComponent();
        }

        private void frmARPG_Load(object sender, EventArgs e)
        {
            for (int x = 0; x < 15; x++)
            {
                for (int y = 0; y < 15; y++)
                {
                    TextBox txtBox = new TextBox();
                    txtBox.Size = new Size(30, 30);
                    txtBox.Name = "txt" + x.ToString() + "_" + y.ToString();
                    txtBox.Location = new Point(x * 30, y * 30);
                    pnlDisplay.Controls.Add(txtBox);
                }
            }
        }
    }
}
