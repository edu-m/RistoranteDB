using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ristorante
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'ristoranteDataSet.Prenotazioni'. È possibile spostarla o rimuoverla se necessario.
            this.prenotazioniTableAdapter.Fill(this.ristoranteDataSet.Prenotazioni);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.prenotazioniTableAdapter.FillBy(this.ristoranteDataSet.Prenotazioni, new System.Nullable<int>(((int)(System.Convert.ChangeType(loggedUserToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
