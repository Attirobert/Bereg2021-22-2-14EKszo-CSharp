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
        private SqlConnection sqlConn;  // Connection string változója
        // Tárolt eljárások nevei
        private readonly string letterInsert = "letterInsert";
        private readonly string usersToCbx = "usersToCbx";   // Címzett combobox feltöltéséhez

        public IktatForm()
        {
            InitializeComponent();
        }

        private void IktatForm_Load(object sender, EventArgs e)
        {
            // Kapcsolódás az adatbázishoz
            sqlConnect();

            // Címzett combobox feltöltése
            UserCbxFill();
        }

        private void UserCbxFill()
        {
            using (SqlCommand sqlComm = new SqlCommand(usersToCbx, sqlConn))
            {
                sqlComm.CommandType = CommandType.StoredProcedure;
                try
                {
                    // DataTable feltöltése az adatbázisból
                    SqlDataAdapter sqlDa = new SqlDataAdapter(sqlComm);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);

                    // Az első sor közvetlen bevitele
                    DataRow rowItem = dtbl.NewRow();
                    rowItem[0] = 0;
                    rowItem[1] = "- Válasszon -";
                    dtbl.Rows.InsertAt(rowItem, 0);

                    // A combobox komponens bekötése a DataTable-höz
                    cbxCimzett.ValueMember = "Id_user";
                    cbxCimzett.DisplayMember = "nev";
                    cbxCimzett.DataSource = dtbl;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void sqlConnect()
        {
            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
            sb.DataSource = "(localdb)\\MSSQLLocalDB";
            sb.InitialCatalog = "iktato";

            try
            {
                sqlConn = new SqlConnection(sb.ToString());
                sqlConn.Open();
                // MessageBox.Show("A kapcsolódás az adatbázishoz sikeres!");
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
                sqlComm.Parameters.AddWithValue("Id_user", Convert.ToInt32(cbxCimzett.SelectedValue));

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
           sqlConn.Close();
        }
    }
}
