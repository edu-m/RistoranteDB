using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ristorante
{
    public partial class FormMain : Form
    {
        public SqlConnection conn;
        public SqlCommand cmd;

        public FormMain()
        {
            InitializeComponent();
            this.turniTableAdapter = new RistoranteDataSetTableAdapters.TurniTableAdapter();
            this.turniTableAdapter.Fill(this.ristoranteDataSet.Turni);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(Utility.connString);
         }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PR_PRENOTA";
            cmd.Connection = conn;

            
            if (!int.TryParse(this.textBoxPax.Text.Trim(), out _) ||
                    this.textBoxPax.Text.Trim() == "0")
                MessageBox.Show("Specificare il numero di posti richiesti.");
            else
            {

                cmd.Parameters.AddWithValue("@IdCliente", Utility.loggedUser);
                cmd.Parameters.AddWithValue("@giorno", this.dateTimePickerGiorno.Value.ToString("yyyyMMdd"));
                cmd.Parameters.AddWithValue("@turno", this.comboBoxTurno.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@pax", this.textBoxPax.Text);
                cmd.Parameters.AddWithValue("@note", this.textBoxNote.Text);
                cmd.Parameters.Add("@message", SqlDbType.VarChar, 100);
                cmd.Parameters["@message"].Direction = ParameterDirection.Output;

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close(); ;

                string result = cmd.Parameters["@message"].Value.ToString();
                MessageBox.Show(result);
            }
        }


        private void btnMy_Click(object sender, EventArgs e)
        {
            // da fare
            Form3 formMy = new Form3();
            formMy.ShowDialog();
        }

        private void labelPrenota_Click(object sender, EventArgs e)
        {

        }

        private void ristoranteDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerGiorno_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
