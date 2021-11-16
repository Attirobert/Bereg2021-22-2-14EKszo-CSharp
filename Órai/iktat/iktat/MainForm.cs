using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iktat
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void egyFelhasználóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserTetel frm = new UserTetel();
            frm.ShowDialog();
        }

        private void felhasználókTáblaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users frm = new Users();
            frm.ShowDialog();
        }

        private void levélToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void levelekListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lettersgrid frm = new Lettersgrid();
            frm.ShowDialog();
        }

        private void iktatásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IktatForm frm = new IktatForm();
            frm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
