namespace Ristorante
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.dateTimePickerGiorno = new System.Windows.Forms.DateTimePicker();
            this.comboBoxTurno = new System.Windows.Forms.ComboBox();
            this.turniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ristoranteDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ristoranteDataSet = new Ristorante.RistoranteDataSet();
            this.buttonPrenota = new System.Windows.Forms.Button();
            this.labelGiorno = new System.Windows.Forms.Label();
            this.labelTurno = new System.Windows.Forms.Label();
            this.labelPax = new System.Windows.Forms.Label();
            this.labelNote = new System.Windows.Forms.Label();
            this.textBoxPax = new System.Windows.Forms.TextBox();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.labelPrenota = new System.Windows.Forms.Label();
            this.btnMy = new System.Windows.Forms.Button();
            this.turniTableAdapter = new Ristorante.RistoranteDataSetTableAdapters.TurniTableAdapter();
            this.turniBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.turniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ristoranteDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ristoranteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turniBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerGiorno
            // 
            this.dateTimePickerGiorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerGiorno.Location = new System.Drawing.Point(189, 159);
            this.dateTimePickerGiorno.Name = "dateTimePickerGiorno";
            this.dateTimePickerGiorno.Size = new System.Drawing.Size(382, 35);
            this.dateTimePickerGiorno.TabIndex = 1;
            this.dateTimePickerGiorno.ValueChanged += new System.EventHandler(this.dateTimePickerGiorno_ValueChanged);
            // 
            // comboBoxTurno
            // 
            this.comboBoxTurno.DataSource = this.turniBindingSource;
            this.comboBoxTurno.DisplayMember = "valore";
            this.comboBoxTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTurno.FormattingEnabled = true;
            this.comboBoxTurno.Location = new System.Drawing.Point(189, 221);
            this.comboBoxTurno.Name = "comboBoxTurno";
            this.comboBoxTurno.Size = new System.Drawing.Size(382, 37);
            this.comboBoxTurno.TabIndex = 2;
            this.comboBoxTurno.ValueMember = "ID";
            // 
            // turniBindingSource
            // 
            this.turniBindingSource.DataMember = "Turni";
            this.turniBindingSource.DataSource = this.ristoranteDataSetBindingSource;
            // 
            // ristoranteDataSetBindingSource
            // 
            this.ristoranteDataSetBindingSource.DataSource = this.ristoranteDataSet;
            this.ristoranteDataSetBindingSource.Position = 0;
            this.ristoranteDataSetBindingSource.CurrentChanged += new System.EventHandler(this.ristoranteDataSetBindingSource_CurrentChanged);
            // 
            // ristoranteDataSet
            // 
            this.ristoranteDataSet.DataSetName = "RistoranteDataSet";
            this.ristoranteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonPrenota
            // 
            this.buttonPrenota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrenota.Location = new System.Drawing.Point(70, 511);
            this.buttonPrenota.Name = "buttonPrenota";
            this.buttonPrenota.Size = new System.Drawing.Size(239, 117);
            this.buttonPrenota.TabIndex = 5;
            this.buttonPrenota.Text = "Prenota!";
            this.buttonPrenota.UseVisualStyleBackColor = true;
            this.buttonPrenota.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelGiorno
            // 
            this.labelGiorno.AutoSize = true;
            this.labelGiorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGiorno.Location = new System.Drawing.Point(65, 159);
            this.labelGiorno.Name = "labelGiorno";
            this.labelGiorno.Size = new System.Drawing.Size(86, 29);
            this.labelGiorno.TabIndex = 4;
            this.labelGiorno.Text = "Giorno";
            // 
            // labelTurno
            // 
            this.labelTurno.AutoSize = true;
            this.labelTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTurno.Location = new System.Drawing.Point(65, 221);
            this.labelTurno.Name = "labelTurno";
            this.labelTurno.Size = new System.Drawing.Size(81, 29);
            this.labelTurno.TabIndex = 5;
            this.labelTurno.Text = "Orario";
            // 
            // labelPax
            // 
            this.labelPax.AutoSize = true;
            this.labelPax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPax.Location = new System.Drawing.Point(65, 287);
            this.labelPax.Name = "labelPax";
            this.labelPax.Size = new System.Drawing.Size(67, 29);
            this.labelPax.TabIndex = 6;
            this.labelPax.Text = "Posti";
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNote.Location = new System.Drawing.Point(65, 354);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(65, 29);
            this.labelNote.TabIndex = 7;
            this.labelNote.Text = "Note";
            // 
            // textBoxPax
            // 
            this.textBoxPax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPax.Location = new System.Drawing.Point(189, 287);
            this.textBoxPax.Name = "textBoxPax";
            this.textBoxPax.Size = new System.Drawing.Size(120, 35);
            this.textBoxPax.TabIndex = 3;
            // 
            // textBoxNote
            // 
            this.textBoxNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNote.Location = new System.Drawing.Point(189, 354);
            this.textBoxNote.Multiline = true;
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(382, 123);
            this.textBoxNote.TabIndex = 4;
            // 
            // labelPrenota
            // 
            this.labelPrenota.AutoSize = true;
            this.labelPrenota.Font = new System.Drawing.Font("Times New Roman", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrenota.Location = new System.Drawing.Point(58, 31);
            this.labelPrenota.Name = "labelPrenota";
            this.labelPrenota.Size = new System.Drawing.Size(356, 67);
            this.labelPrenota.TabIndex = 10;
            this.labelPrenota.Text = "Prenotazione";
            this.labelPrenota.Click += new System.EventHandler(this.labelPrenota_Click);
            // 
            // btnMy
            // 
            this.btnMy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMy.Location = new System.Drawing.Point(331, 511);
            this.btnMy.Name = "btnMy";
            this.btnMy.Size = new System.Drawing.Size(240, 117);
            this.btnMy.TabIndex = 6;
            this.btnMy.Text = "Le tue prenotazioni";
            this.btnMy.UseVisualStyleBackColor = true;
            this.btnMy.Click += new System.EventHandler(this.btnMy_Click);
            // 
            // turniTableAdapter
            // 
            this.turniTableAdapter.ClearBeforeFill = true;
            // 
            // turniBindingSource1
            // 
            this.turniBindingSource1.DataMember = "Turni";
            this.turniBindingSource1.DataSource = this.ristoranteDataSetBindingSource;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1154, 808);
            this.Controls.Add(this.btnMy);
            this.Controls.Add(this.labelPrenota);
            this.Controls.Add(this.textBoxNote);
            this.Controls.Add(this.textBoxPax);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.labelPax);
            this.Controls.Add(this.labelTurno);
            this.Controls.Add(this.labelGiorno);
            this.Controls.Add(this.buttonPrenota);
            this.Controls.Add(this.comboBoxTurno);
            this.Controls.Add(this.dateTimePickerGiorno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Prenotazioni";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.turniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ristoranteDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ristoranteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turniBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerGiorno;
        private System.Windows.Forms.ComboBox comboBoxTurno;
        private System.Windows.Forms.Button buttonPrenota;
        private System.Windows.Forms.Label labelGiorno;
        private System.Windows.Forms.Label labelTurno;
        private System.Windows.Forms.Label labelPax;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.TextBox textBoxPax;
        private System.Windows.Forms.TextBox textBoxNote;
        private System.Windows.Forms.Label labelPrenota;
        private System.Windows.Forms.Button btnMy;
        private System.Windows.Forms.BindingSource ristoranteDataSetBindingSource;
        private RistoranteDataSet ristoranteDataSet;
        private System.Windows.Forms.BindingSource turniBindingSource;
        private RistoranteDataSetTableAdapters.TurniTableAdapter turniTableAdapter;
        private System.Windows.Forms.BindingSource turniBindingSource1;
    }
}