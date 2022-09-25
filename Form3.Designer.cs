namespace Ristorante
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giornoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenotazioniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ristoranteDataSet = new Ristorante.RistoranteDataSet();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.loggedUserToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.loggedUserToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.prenotazioniTableAdapter = new Ristorante.RistoranteDataSetTableAdapters.PrenotazioniTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prenotazioniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ristoranteDataSet)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.giornoDataGridViewTextBoxColumn,
            this.turnoDataGridViewTextBoxColumn,
            this.idClienteDataGridViewTextBoxColumn,
            this.paxDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.prenotazioniBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(748, 150);
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
            this.iDDataGridViewTextBoxColumn.Width = 62;
            // 
            // giornoDataGridViewTextBoxColumn
            // 
            this.giornoDataGridViewTextBoxColumn.DataPropertyName = "giorno";
            this.giornoDataGridViewTextBoxColumn.HeaderText = "giorno";
            this.giornoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giornoDataGridViewTextBoxColumn.Name = "giornoDataGridViewTextBoxColumn";
            this.giornoDataGridViewTextBoxColumn.ReadOnly = true;
            this.giornoDataGridViewTextBoxColumn.Width = 89;
            // 
            // turnoDataGridViewTextBoxColumn
            // 
            this.turnoDataGridViewTextBoxColumn.DataPropertyName = "turno";
            this.turnoDataGridViewTextBoxColumn.HeaderText = "turno";
            this.turnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.turnoDataGridViewTextBoxColumn.Name = "turnoDataGridViewTextBoxColumn";
            this.turnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.turnoDataGridViewTextBoxColumn.Width = 82;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "IdCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "IdCliente";
            this.idClienteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idClienteDataGridViewTextBoxColumn.Width = 108;
            // 
            // paxDataGridViewTextBoxColumn
            // 
            this.paxDataGridViewTextBoxColumn.DataPropertyName = "pax";
            this.paxDataGridViewTextBoxColumn.HeaderText = "pax";
            this.paxDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paxDataGridViewTextBoxColumn.Name = "paxDataGridViewTextBoxColumn";
            this.paxDataGridViewTextBoxColumn.ReadOnly = true;
            this.paxDataGridViewTextBoxColumn.Width = 70;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "note";
            this.noteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
            this.noteDataGridViewTextBoxColumn.Width = 77;
            // 
            // prenotazioniBindingSource
            // 
            this.prenotazioniBindingSource.DataMember = "Prenotazioni";
            this.prenotazioniBindingSource.DataSource = this.ristoranteDataSet;
            // 
            // ristoranteDataSet
            // 
            this.ristoranteDataSet.DataSetName = "RistoranteDataSet";
            this.ristoranteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loggedUserToolStripLabel,
            this.loggedUserToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(800, 34);
            this.fillByToolStrip.TabIndex = 1;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // loggedUserToolStripLabel
            // 
            this.loggedUserToolStripLabel.Name = "loggedUserToolStripLabel";
            this.loggedUserToolStripLabel.Size = new System.Drawing.Size(108, 29);
            this.loggedUserToolStripLabel.Text = "loggedUser:";
            // 
            // loggedUserToolStripTextBox
            // 
            this.loggedUserToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loggedUserToolStripTextBox.Name = "loggedUserToolStripTextBox";
            this.loggedUserToolStripTextBox.Size = new System.Drawing.Size(100, 34);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(56, 29);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // prenotazioniTableAdapter
            // 
            this.prenotazioniTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prenotazioniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ristoranteDataSet)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RistoranteDataSet ristoranteDataSet;
        private System.Windows.Forms.BindingSource prenotazioniBindingSource;
        private RistoranteDataSetTableAdapters.PrenotazioniTableAdapter prenotazioniTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giornoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel loggedUserToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox loggedUserToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
    }
}