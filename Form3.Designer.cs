namespace Ristorante
{
    partial class FormMy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMy));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giorno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Orario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Posti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenotazClienteDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ristoranteDataSet = new Ristorante.RistoranteDataSet();
            this.prenotazioniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.prenotazioniTableAdapter = new Ristorante.RistoranteDataSetTableAdapters.PrenotazioniTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.prenotazClienteDataTableTableAdapter = new Ristorante.RistoranteDataSetTableAdapters.PrenotazClienteDataTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prenotazClienteDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ristoranteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prenotazioniBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.Giorno,
            this.Orario,
            this.Posti,
            this.Note,
            this.idClienteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.prenotazClienteDataTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(77, 123);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(577, 297);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            this.iDDataGridViewTextBoxColumn.Width = 49;
            // 
            // Giorno
            // 
            this.Giorno.DataPropertyName = "Giorno";
            this.Giorno.HeaderText = "Giorno";
            this.Giorno.MinimumWidth = 6;
            this.Giorno.Name = "Giorno";
            this.Giorno.ReadOnly = true;
            this.Giorno.Width = 93;
            // 
            // Orario
            // 
            this.Orario.DataPropertyName = "Orario";
            this.Orario.HeaderText = "Orario";
            this.Orario.MinimumWidth = 6;
            this.Orario.Name = "Orario";
            this.Orario.ReadOnly = true;
            this.Orario.Width = 88;
            // 
            // Posti
            // 
            this.Posti.DataPropertyName = "Posti";
            this.Posti.HeaderText = "Posti";
            this.Posti.MinimumWidth = 6;
            this.Posti.Name = "Posti";
            this.Posti.ReadOnly = true;
            this.Posti.Width = 80;
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "Note";
            this.Note.MinimumWidth = 6;
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            this.Note.Width = 79;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "IdCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "IdCliente";
            this.idClienteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idClienteDataGridViewTextBoxColumn.Visible = false;
            this.idClienteDataGridViewTextBoxColumn.Width = 88;
            // 
            // prenotazClienteDataTableBindingSource
            // 
            this.prenotazClienteDataTableBindingSource.DataMember = "PrenotazClienteDataTable";
            this.prenotazClienteDataTableBindingSource.DataSource = this.ristoranteDataSet;
            // 
            // ristoranteDataSet
            // 
            this.ristoranteDataSet.DataSetName = "RistoranteDataSet";
            this.ristoranteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prenotazioniBindingSource
            // 
            this.prenotazioniBindingSource.DataMember = "Prenotazioni";
            this.prenotazioniBindingSource.DataSource = this.ristoranteDataSet;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(714, 25);
            this.fillByToolStrip.TabIndex = 1;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // prenotazioniTableAdapter
            // 
            this.prenotazioniTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(589, 70);
            this.label1.TabIndex = 2;
            this.label1.Text = "Le tue prenotazioni";
            // 
            // prenotazClienteDataTableTableAdapter
            // 
            this.prenotazClienteDataTableTableAdapter.ClearBeforeFill = true;
            // 
            // FormMy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(714, 513);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Le tue prenotazioni";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prenotazClienteDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ristoranteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prenotazioniBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RistoranteDataSet ristoranteDataSet;
        private System.Windows.Forms.BindingSource prenotazioniBindingSource;
        private RistoranteDataSetTableAdapters.PrenotazioniTableAdapter prenotazioniTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource prenotazClienteDataTableBindingSource;
        private RistoranteDataSetTableAdapters.PrenotazClienteDataTableTableAdapter prenotazClienteDataTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giorno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Orario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Posti;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
    }
}