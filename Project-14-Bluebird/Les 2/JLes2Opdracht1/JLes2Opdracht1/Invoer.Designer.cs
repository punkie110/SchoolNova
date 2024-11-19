namespace JLes2Opdracht1
{
    partial class Invoer
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
            this.txtStudentnr = new System.Windows.Forms.TextBox();
            this.txtVoornaam = new System.Windows.Forms.TextBox();
            this.txtAchternaam = new System.Windows.Forms.TextBox();
            this.lblAchternaam = new System.Windows.Forms.Label();
            this.lblVoornaam = new System.Windows.Forms.Label();
            this.lblStudentNummer = new System.Windows.Forms.Label();
            this.lblKlas = new System.Windows.Forms.Label();
            this.cbxKlas = new System.Windows.Forms.ComboBox();
            this.btnInvoer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtStudentnr
            // 
            this.txtStudentnr.Location = new System.Drawing.Point(279, 113);
            this.txtStudentnr.Name = "txtStudentnr";
            this.txtStudentnr.Size = new System.Drawing.Size(201, 22);
            this.txtStudentnr.TabIndex = 16;
            this.txtStudentnr.TextChanged += new System.EventHandler(this.txtStudentnr_TextChanged);
            // 
            // txtVoornaam
            // 
            this.txtVoornaam.Location = new System.Drawing.Point(279, 144);
            this.txtVoornaam.Name = "txtVoornaam";
            this.txtVoornaam.Size = new System.Drawing.Size(201, 22);
            this.txtVoornaam.TabIndex = 15;
            this.txtVoornaam.TextChanged += new System.EventHandler(this.txtVoornaam_TextChanged);
            // 
            // txtAchternaam
            // 
            this.txtAchternaam.Location = new System.Drawing.Point(279, 172);
            this.txtAchternaam.Name = "txtAchternaam";
            this.txtAchternaam.Size = new System.Drawing.Size(201, 22);
            this.txtAchternaam.TabIndex = 14;
            this.txtAchternaam.TextChanged += new System.EventHandler(this.txtAchternaam_TextChanged);
            // 
            // lblAchternaam
            // 
            this.lblAchternaam.AutoSize = true;
            this.lblAchternaam.Location = new System.Drawing.Point(162, 172);
            this.lblAchternaam.Name = "lblAchternaam";
            this.lblAchternaam.Size = new System.Drawing.Size(79, 16);
            this.lblAchternaam.TabIndex = 13;
            this.lblAchternaam.Text = "Achternaam";
            this.lblAchternaam.Click += new System.EventHandler(this.lblAchternaam_Click);
            // 
            // lblVoornaam
            // 
            this.lblVoornaam.AutoSize = true;
            this.lblVoornaam.Location = new System.Drawing.Point(178, 144);
            this.lblVoornaam.Name = "lblVoornaam";
            this.lblVoornaam.Size = new System.Drawing.Size(70, 16);
            this.lblVoornaam.TabIndex = 12;
            this.lblVoornaam.Text = "Voornaam";
            this.lblVoornaam.Click += new System.EventHandler(this.lblVoornaam_Click);
            // 
            // lblStudentNummer
            // 
            this.lblStudentNummer.AutoSize = true;
            this.lblStudentNummer.Location = new System.Drawing.Point(178, 113);
            this.lblStudentNummer.Name = "lblStudentNummer";
            this.lblStudentNummer.Size = new System.Drawing.Size(63, 16);
            this.lblStudentNummer.TabIndex = 11;
            this.lblStudentNummer.Text = "Studentnr";
            this.lblStudentNummer.Click += new System.EventHandler(this.lblStudentNummer_Click);
            // 
            // lblKlas
            // 
            this.lblKlas.AutoSize = true;
            this.lblKlas.Location = new System.Drawing.Point(208, 203);
            this.lblKlas.Name = "lblKlas";
            this.lblKlas.Size = new System.Drawing.Size(33, 16);
            this.lblKlas.TabIndex = 10;
            this.lblKlas.Text = "Klas";
            this.lblKlas.Click += new System.EventHandler(this.lblKlas_Click);
            // 
            // cbxKlas
            // 
            this.cbxKlas.FormattingEnabled = true;
            this.cbxKlas.Location = new System.Drawing.Point(279, 200);
            this.cbxKlas.Name = "cbxKlas";
            this.cbxKlas.Size = new System.Drawing.Size(201, 24);
            this.cbxKlas.TabIndex = 9;
            this.cbxKlas.SelectedIndexChanged += new System.EventHandler(this.cbxKlas_SelectedIndexChanged);
            // 
            // btnInvoer
            // 
            this.btnInvoer.Location = new System.Drawing.Point(197, 268);
            this.btnInvoer.Name = "btnInvoer";
            this.btnInvoer.Size = new System.Drawing.Size(412, 140);
            this.btnInvoer.TabIndex = 17;
            this.btnInvoer.Text = "Voer In";
            this.btnInvoer.UseVisualStyleBackColor = true;
            this.btnInvoer.Click += new System.EventHandler(this.btnInvoer_Click);
            // 
            // Invoer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInvoer);
            this.Controls.Add(this.txtStudentnr);
            this.Controls.Add(this.txtVoornaam);
            this.Controls.Add(this.txtAchternaam);
            this.Controls.Add(this.lblAchternaam);
            this.Controls.Add(this.lblVoornaam);
            this.Controls.Add(this.lblStudentNummer);
            this.Controls.Add(this.lblKlas);
            this.Controls.Add(this.cbxKlas);
            this.Name = "Invoer";
            this.Text = "Invoer";
            this.Load += new System.EventHandler(this.Invoer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStudentnr;
        private System.Windows.Forms.TextBox txtVoornaam;
        private System.Windows.Forms.TextBox txtAchternaam;
        private System.Windows.Forms.Label lblAchternaam;
        private System.Windows.Forms.Label lblVoornaam;
        private System.Windows.Forms.Label lblStudentNummer;
        private System.Windows.Forms.Label lblKlas;
        private System.Windows.Forms.ComboBox cbxKlas;
        private System.Windows.Forms.Button btnInvoer;
    }
}