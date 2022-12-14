namespace Ristorante
{
    partial class FormPrenota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrenota));
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
            this.dateTimePickerGiorno.Location = new System.Drawing.Point(126, 103);
            this.dateTimePickerGiorno.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dateTimePickerGiorno.Name = "dateTimePickerGiorno";
            this.dateTimePickerGiorno.Size = new System.Drawing.Size(256, 26);
            this.dateTimePickerGiorno.TabIndex = 1;
            // 
            // comboBoxTurno
            // 
            this.comboBoxTurno.DataSource = this.turniBindingSource;
            this.comboBoxTurno.DisplayMember = "valore";
            this.comboBoxTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTurno.FormattingEnabled = true;
            this.comboBoxTurno.Location = new System.Drawing.Point(126, 144);
            this.comboBoxTurno.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.comboBoxTurno.Name = "comboBoxTurno";
            this.comboBoxTurno.Size = new System.Drawing.Size(256, 28);
            this.comboBoxTurno.TabIndex = 2;
            this.comboBoxTurno.ValueMember = "ID";
            this.comboBoxTurno.SelectedIndexChanged += new System.EventHandler(this.comboBoxTurno_SelectedIndexChanged);
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
            // 
            // ristoranteDataSet
            // 
            this.ristoranteDataSet.DataSetName = "RistoranteDataSet";
            this.ristoranteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonPrenota
            // 
            this.buttonPrenota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrenota.Location = new System.Drawing.Point(559, 103);
            this.buttonPrenota.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonPrenota.Name = "buttonPrenota";
            this.buttonPrenota.Size = new System.Drawing.Size(159, 77);
            this.buttonPrenota.TabIndex = 5;
            this.buttonPrenota.Text = "Prenota!";
            this.buttonPrenota.UseVisualStyleBackColor = true;
            this.buttonPrenota.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelGiorno
            // 
            this.labelGiorno.AutoSize = true;
            this.labelGiorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGiorno.Location = new System.Drawing.Point(43, 103);
            this.labelGiorno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGiorno.Name = "labelGiorno";
            this.labelGiorno.Size = new System.Drawing.Size(57, 20);
            this.labelGiorno.TabIndex = 4;
            this.labelGiorno.Text = "Giorno";
            // 
            // labelTurno
            // 
            this.labelTurno.AutoSize = true;
            this.labelTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTurno.Location = new System.Drawing.Point(43, 144);
            this.labelTurno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTurno.Name = "labelTurno";
            this.labelTurno.Size = new System.Drawing.Size(52, 20);
            this.labelTurno.TabIndex = 5;
            this.labelTurno.Text = "Orario";
            // 
            // labelPax
            // 
            this.labelPax.AutoSize = true;
            this.labelPax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPax.Location = new System.Drawing.Point(43, 187);
            this.labelPax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPax.Name = "labelPax";
            this.labelPax.Size = new System.Drawing.Size(44, 20);
            this.labelPax.TabIndex = 6;
            this.labelPax.Text = "Posti";
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNote.Location = new System.Drawing.Point(43, 230);
            this.labelNote.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(43, 20);
            this.labelNote.TabIndex = 7;
            this.labelNote.Text = "Note";
            // 
            // textBoxPax
            // 
            this.textBoxPax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPax.Location = new System.Drawing.Point(126, 187);
            this.textBoxPax.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBoxPax.Name = "textBoxPax";
            this.textBoxPax.Size = new System.Drawing.Size(81, 26);
            this.textBoxPax.TabIndex = 3;
            // 
            // textBoxNote
            // 
            this.textBoxNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNote.Location = new System.Drawing.Point(126, 230);
            this.textBoxNote.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBoxNote.Multiline = true;
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(256, 81);
            this.textBoxNote.TabIndex = 4;
            // 
            // labelPrenota
            // 
            this.labelPrenota.AutoSize = true;
            this.labelPrenota.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrenota.Location = new System.Drawing.Point(239, 29);
            this.labelPrenota.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrenota.Name = "labelPrenota";
            this.labelPrenota.Size = new System.Drawing.Size(279, 46);
            this.labelPrenota.TabIndex = 10;
            this.labelPrenota.Text = "Prenotazione";
            // 
            // btnMy
            // 
            this.btnMy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMy.Location = new System.Drawing.Point(558, 230);
            this.btnMy.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnMy.Name = "btnMy";
            this.btnMy.Size = new System.Drawing.Size(160, 77);
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
            // FormPrenota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(769, 394);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrenota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prenotazioni";
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