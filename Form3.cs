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
    public partial class FormMy : Form
    {
        public SqlConnection conn;
        public SqlCommand cmd;

        public FormMy()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.prenotazClienteDataTableTableAdapter.Fill(this.ristoranteDataSet.PrenotazClienteDataTable);
            this.prenotazClienteDataTableTableAdapter.FillBy(this.ristoranteDataSet.PrenotazClienteDataTable,
                new System.Nullable<int>(((int)(System.Convert.ChangeType(Utility.loggedUser, typeof(int))))));

            conn = new SqlConnection(Utility.connString);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PR_CANCELLA_PRENOTAZIONE";
            cmd.Connection = conn;


            if (!int.TryParse(this.textBox2.Text.Trim(), out _) ||
                    this.textBox2.Text.Trim() == "0")
                MessageBox.Show("Specificare l'ID della prenotazione.");
            else
            {

                cmd.Parameters.AddWithValue("@IdCliente", Utility.loggedUser);
                cmd.Parameters.AddWithValue("@IdPrenotazione", this.textBox2.Text);
                cmd.Parameters.Add("@message", SqlDbType.VarChar, 100);
                cmd.Parameters["@message"].Direction = ParameterDirection.Output;

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close(); ;

                string result = cmd.Parameters["@message"].Value.ToString();
                MessageBox.Show(result);

                this.prenotazClienteDataTableTableAdapter.FillBy(this.ristoranteDataSet.PrenotazClienteDataTable,
                new System.Nullable<int>(((int)(System.Convert.ChangeType(Utility.loggedUser, typeof(int))))));
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PR_CANCELLA_PRENOTAZIONE";
            cmd.Connection = conn;


            if (!int.TryParse(this.textBox2.Text.Trim(), out _) ||
                    this.textBox2.Text.Trim() == "0")
                MessageBox.Show("Specificare l'ID della prenotazione.");
            else
            {

                cmd.Parameters.AddWithValue("@IdCliente", Utility.loggedUser);
                cmd.Parameters.AddWithValue("@IdPrenotazione", this.textBox2.Text);
                cmd.Parameters.Add("@message", SqlDbType.VarChar, 100);
                cmd.Parameters["@message"].Direction = ParameterDirection.Output;

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close(); ;

                string result = cmd.Parameters["@message"].Value.ToString();
                MessageBox.Show(result);

                this.prenotazClienteDataTableTableAdapter.FillBy(this.ristoranteDataSet.PrenotazClienteDataTable,
                new System.Nullable<int>(((int)(System.Convert.ChangeType(Utility.loggedUser, typeof(int))))));
            }
        }
    }
}
