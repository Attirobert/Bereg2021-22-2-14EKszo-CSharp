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
    }
}
