using Algorithms.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithms
{
    public partial class StartGui : Form
    {
        public StartGui()
        {
            InitializeComponent();
        }

        private void vToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RandomGrid rg = new RandomGrid();
            rg.Show();
        }
    }
}
