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
            refreshDisplay();
        }

        private void refreshDisplay()
        {
            
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            MovePlayer(Character.characterMovement.LEFT);
        }
    }
}
