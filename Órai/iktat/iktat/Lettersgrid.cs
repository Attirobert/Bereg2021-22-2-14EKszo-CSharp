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
    public partial class Lettersgrid : Form
    {
        public Lettersgrid()
        {
            InitializeComponent();
        }

        private void lettersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

        }

        private void Lettersgrid_Load(object sender, EventArgs e)
        {

        }
    }
}
