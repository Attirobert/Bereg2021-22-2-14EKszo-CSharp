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

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            try
            {
                this.usersBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.userDS);
            }
            catch (Exception err)
            {
                MessageBox.Show("Hibás művelet \n" + err.Message);
                this.usersTableAdapter.Fill(this.userDS.users);
            }

        }

        private void UserTetel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userDS.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.userDS.users);

        }
    }
}
