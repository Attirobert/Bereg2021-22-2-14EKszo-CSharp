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
    public partial class UserTetel : Form
    {
        public UserTetel()
        {
            InitializeComponent();
        }

        private void UserTetel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'felhasznDS.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.felhasznDS.users);
            // TODO: This line of code loads data into the 'felhasznDS.users' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'userDS.users' table. You can move, or remove it, as needed.

        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

        }

        private void usersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.felhasznDS);

        }
    }
}
