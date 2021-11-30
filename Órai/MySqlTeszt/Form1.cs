using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MySqlTeszt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Rendszam";
            dataGridView1.Columns[2].Name = "Gyartmany";
            dataGridView1.Columns[3].Name = "Urtartalom";
            Adattabla_Frissit();
        }

        private void Adattabla_Frissit()
        {
            Program.sql.CommandText = "SELECT `id`,`Rendszam`,`Marka`,`Urtartalom` FROM `autok`";
            try
            {
                using (MySqlDataReader dr = Program.sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int sor_index = dataGridView1.Rows.Add();
                        dataGridView1.Rows[sor_index].Cells["ID"].Value = dr.GetInt32("id");
                        dataGridView1.Rows[sor_index].Cells["Rendszam"].Value = dr.GetString("Rendszam");
                        dataGridView1.Rows[sor_index].Cells["Gyartmany"].Value = dr.GetString("Marka");
                        dataGridView1.Rows[sor_index].Cells["Urtartalom"].Value = dr.GetInt32("Urtartalom");
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}

