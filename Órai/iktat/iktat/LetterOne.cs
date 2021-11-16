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
    public partial class LetterOne : Form
    {
        public LetterOne()
        {
            InitializeComponent();
        }

        private void lettersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lettersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.letterDS);

        }

        private void LetterOne_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'letterDS.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.letterDS.users);
            // TODO: This line of code loads data into the 'letterDS.letters' table. You can move, or remove it, as needed.
            this.lettersTableAdapter.Fill(this.letterDS.letters);

        }
    }
}
