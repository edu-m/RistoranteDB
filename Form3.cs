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
    public partial class FormMy : Form
    {
        public FormMy()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'ristoranteDataSet.PrenotazClienteDataTable'. È possibile spostarla o rimuoverla se necessario.
            this.prenotazClienteDataTableTableAdapter.Fill(this.ristoranteDataSet.PrenotazClienteDataTable);
            this.prenotazClienteDataTableTableAdapter.FillBy(this.ristoranteDataSet.PrenotazClienteDataTable, 
                new System.Nullable<int>(((int)(System.Convert.ChangeType(Utility.loggedUser, typeof(int))))));

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
    }
}
