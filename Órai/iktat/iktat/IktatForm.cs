using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iktat
{
    public partial class IktatForm : Form
    {
        // Osztályváltozók
        private SqlConnection sqlConn;
        private string letterInsert = "letterInsert";

        public IktatForm()
        {
            InitializeComponent();
        }

        private void IktatForm_Load(object sender, EventArgs e)
        {
            // Kapcsolódás az adatbázishoz
            sqlConnect();
        }

        private void sqlConnect()
        {
            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
            sb.DataSource = "(localdb)\\MSSQLLocalDB";
            sb.InitialCatalog = "iktat";

            try
            {
                sqlConn = new SqlConnection(sb.ToString());
                sqlConn.Open();
                MessageBox.Show("A kapcsolódás az adatbázishoz sikeres!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("A kapcsolódás az adatbázishoz sikertelen! /n {0}", ex.Message);
            }
        }

        private void btnMegse_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            insertLetter();
        }

        private void insertLetter()
        {
            using (SqlCommand sqlComm = new SqlCommand(letterInsert, sqlConn))
            {
                sqlComm.CommandType = CommandType.StoredProcedure;

                // Paraméterek beállítása
                sqlComm.Parameters.AddWithValue("erkezett", dtpErkezett.Value);
                sqlComm.Parameters.AddWithValue("targy", tbxTargy.Text);
                sqlComm.Parameters.AddWithValue("leiras", rtbLeiras.Text);
                sqlComm.Parameters.AddWithValue("user", cbxCimzett.SelectedValue);

                try
                {
                    // Felvitel a táblába
                    sqlComm.ExecuteNonQuery();
                    MessageBox.Show("Az rekord felvétele sikeres.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            // Beviteli mezők törlése
            clearFields();
        }

        private void clearFields()
        {
            // Beviteli mezők nullázása
            tbxTargy.Text = String.Empty;
            rtbLeiras.Text = String.Empty;
        }

        private void IktatForm_FormClosed(object sender, FormClosedEventArgs e)
        {
           // sqlConn.Close();
        }
    }
}
