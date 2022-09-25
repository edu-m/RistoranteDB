namespace Ristorante
{
    partial class Form_Benvenuti
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Benvenuti));
            this.btnAccedi = new System.Windows.Forms.Button();
            this.btnRegistrati = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPwd = new System.Windows.Forms.Label();
            this.textBoxPwd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccedi
            // 
            this.btnAccedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccedi.Location = new System.Drawing.Point(509, 448);
            this.btnAccedi.Name = "btnAccedi";
            this.btnAccedi.Size = new System.Drawing.Size(397, 50);
            this.btnAccedi.TabIndex = 3;
            this.btnAccedi.Text = "Accedi";
            this.btnAccedi.UseVisualStyleBackColor = true;
            this.btnAccedi.Click += new System.EventHandler(this.btnAccedi_Click);
            // 
            // btnRegistrati
            // 
            this.btnRegistrati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrati.Location = new System.Drawing.Point(509, 385);
            this.btnRegistrati.Name = "btnRegistrati";
            this.btnRegistrati.Size = new System.Drawing.Size(397, 50);
            this.btnRegistrati.TabIndex = 4;
            this.btnRegistrati.Text = "Registrati";
            this.btnRegistrati.UseVisualStyleBackColor = true;
            this.btnRegistrati.Click += new System.EventHandler(this.btnRegistrati_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 67);
            this.label1.TabIndex = 2;
            this.label1.Text = "Benvenuti!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 179);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 375);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(509, 179);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(383, 35);
            this.textBoxEmail.TabIndex = 1;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(367, 179);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(74, 29);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "Email";
            // 
            // labelPwd
            // 
            this.labelPwd.AutoSize = true;
            this.labelPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPwd.Location = new System.Drawing.Point(367, 233);
            this.labelPwd.Name = "labelPwd";
            this.labelPwd.Size = new System.Drawing.Size(120, 29);
            this.labelPwd.TabIndex = 6;
            this.labelPwd.Text = "Password";
            // 
            // textBoxPwd
            // 
            this.textBoxPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPwd.Location = new System.Drawing.Point(509, 233);
            this.textBoxPwd.Name = "textBoxPwd";
            this.textBoxPwd.PasswordChar = '*';
            this.textBoxPwd.Size = new System.Drawing.Size(383, 35);
            this.textBoxPwd.TabIndex = 2;
            // 
            // Form_Benvenuti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1037, 691);
            this.Controls.Add(this.textBoxPwd);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistrati);
            this.Controls.Add(this.btnAccedi);
            this.Controls.Add(this.labelPwd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Benvenuti";
            this.Text = "Benvenuti";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccedi;
        private System.Windows.Forms.Button btnRegistrati;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPwd;
        private System.Windows.Forms.TextBox textBoxPwd;
    }
}

