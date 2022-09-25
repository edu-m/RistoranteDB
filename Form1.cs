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

namespace Ristorante
{
    public partial class Form_Benvenuti : Form
    {
        public SqlConnection conn;
        public SqlCommand cmd;

        public Form_Benvenuti()
        {
            InitializeComponent();

            conn = new SqlConnection(Utility.connString); 
         }



        private void btnAccedi_Click(object sender, EventArgs e)
        {
            /*
            DataTable clienti = this.ristoranteDataSet.Clienti;
            clienti.Select("email='" + textBoxEmail.Text + "' and pwd = '" + textBoxPwd.Text + "'");
            */
            
            conn.Open();
            string queryString = "SELECT ID FROM dbo.Clienti "
                            + "WHERE email = '" + textBoxEmail.Text
                            + "' and pwd = '" + textBoxPwd.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(queryString, conn);
            DataSet clienti = new DataSet();
            adapter.Fill(clienti, "Clienti");
            conn.Close();


            if (clienti.Tables["Clienti"].Rows.Count == 1)
            {
                DataRow pRow = clienti.Tables["Clienti"].Rows[0];
                Utility.loggedUser = pRow["ID"].ToString();

                //MessageBox.Show("IdCliente = " + Utility.loggedUser);

                FormMain formPrenota = new FormMain();
                formPrenota.ShowDialog();
                this.Close();

            }
            else
                MessageBox.Show("Username o Password errati.");

        }

        private void btnRegistrati_Click(object sender, EventArgs e)
        {
            // da fare
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
