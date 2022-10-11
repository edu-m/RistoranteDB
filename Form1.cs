using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Ristorante
{
    public partial class FormLogin : Form
    {
        public SqlConnection conn;
        public SqlCommand cmd;

        public FormLogin()
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
                            + "' and pwd = '" + GetSha1(textBoxPwd.Text) + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(queryString, conn);
            DataSet clienti = new DataSet();
            adapter.Fill(clienti, "Clienti");
            conn.Close();


            if (clienti.Tables["Clienti"].Rows.Count == 1)
            {
                DataRow pRow = clienti.Tables["Clienti"].Rows[0];
                Utility.loggedUser = pRow["ID"].ToString();

                //MessageBox.Show("IdCliente = " + Utility.loggedUser);
                FormPrenota formPrenota = new FormPrenota();
                formPrenota.ShowDialog();
                this.Close();

            }
            else
                MessageBox.Show("Username o Password errati.");

        }

        private void btnRegistrati_Click(object sender, EventArgs e)
        {
            this.labelNome.Visible = true;
            this.textBoxNome.Visible = true;
            this.labelTelefono.Visible = true;
            this.textBoxTel.Visible = true;
            this.btnInvia.Visible = true;
            this.btnRegistrati.Enabled = false;
            this.btnAccedi.Enabled = false;
        }

        public static string GetSha1(string value)
        {
            var data = Encoding.ASCII.GetBytes(value);
            var hashData = new SHA1Managed().ComputeHash(data);
            var hash = string.Empty;
            foreach (var b in hashData)
            {
                hash += b.ToString("X2");
            }
            return hash;
        }

        private void btnInvia_Click(object sender, EventArgs e)
        {
            if (textBoxEmail.Text.Trim().Equals(String.Empty)
                || textBoxPwd.Text.Trim().Equals(String.Empty))
                MessageBox.Show("I campi Email e Password sono obbligatori");
            else
            { 
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PR_CREA_UTENTE";
                cmd.Connection = conn;

                cmd.Parameters.AddWithValue("@email", this.textBoxEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@pwd", GetSha1(this.textBoxPwd.Text.Trim())); //USARE QUESTO: con hash
                //cmd.Parameters.AddWithValue("@pwd", this.textBoxPwd.Text.Trim()); //SOLO TEST: senza hash !!!
                cmd.Parameters.AddWithValue("@nome", this.textBoxNome.Text.Trim());
                cmd.Parameters.AddWithValue("@telefono", this.textBoxTel.Text.Trim());
                cmd.Parameters.Add("@message", SqlDbType.VarChar, 100);
                cmd.Parameters["@message"].Direction = ParameterDirection.Output;

                try
                {
                    conn.Open();
                    // code here  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("C'è stato un problema nella comunicazione con il server. Riprova più tardi. Codice di errore"+ ex.ToString());
                    this.Close();
                }
                
                cmd.ExecuteNonQuery();
                conn.Close(); ;

                string result = cmd.Parameters["@message"].Value.ToString();
                MessageBox.Show(result);

                this.labelNome.Visible = false;
                this.textBoxNome.Visible = false;
                this.labelTelefono.Visible = false;
                this.textBoxTel.Visible = false;
                this.btnInvia.Visible = false;
                this.btnRegistrati.Enabled = true;
                this.btnAccedi.Enabled = true;
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
