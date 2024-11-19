namespace Les5Opdracht1
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
            this.btnInvoer = new System.Windows.Forms.Button();
            this.txtStudentnr = new System.Windows.Forms.TextBox();
            this.txtVoornaam = new System.Windows.Forms.TextBox();
            this.txtAchternaam = new System.Windows.Forms.TextBox();
            this.lblAchternaam = new System.Windows.Forms.Label();
            this.lblVoornaam = new System.Windows.Forms.Label();
            this.lblStudentNummer = new System.Windows.Forms.Label();
            this.lblKlas = new System.Windows.Forms.Label();
            this.cbxKlas = new System.Windows.Forms.ComboBox();
            this.cbxKluisnr = new System.Windows.Forms.ComboBox();
            this.lblKluisNr = new System.Windows.Forms.Label();
            this.lblOpmerkingen = new System.Windows.Forms.Label();
            this.txtOpmerkingen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnInvoer
            // 
            this.btnInvoer.Location = new System.Drawing.Point(196, 287);
            this.btnInvoer.Name = "btnInvoer";
            this.btnInvoer.Size = new System.Drawing.Size(412, 140);
            this.btnInvoer.TabIndex = 44;
            this.btnInvoer.Text = "Voer In";
            this.btnInvoer.UseVisualStyleBackColor = true;
            this.btnInvoer.Click += new System.EventHandler(this.btnInvoer_Click);
            // 
            // txtStudentnr
            // 
            this.txtStudentnr.Location = new System.Drawing.Point(294, 78);
            this.txtStudentnr.Name = "txtStudentnr";
            this.txtStudentnr.Size = new System.Drawing.Size(201, 22);
            this.txtStudentnr.TabIndex = 43;
            // 
            // txtVoornaam
            // 
            this.txtVoornaam.Location = new System.Drawing.Point(294, 109);
            this.txtVoornaam.Name = "txtVoornaam";
            this.txtVoornaam.Size = new System.Drawing.Size(201, 22);
            this.txtVoornaam.TabIndex = 42;
            // 
            // txtAchternaam
            // 
            this.txtAchternaam.Location = new System.Drawing.Point(294, 137);
            this.txtAchternaam.Name = "txtAchternaam";
            this.txtAchternaam.Size = new System.Drawing.Size(201, 22);
            this.txtAchternaam.TabIndex = 41;
            // 
            // lblAchternaam
            // 
            this.lblAchternaam.AutoSize = true;
            this.lblAchternaam.Location = new System.Drawing.Point(184, 137);
            this.lblAchternaam.Name = "lblAchternaam";
            this.lblAchternaam.Size = new System.Drawing.Size(79, 16);
            this.lblAchternaam.TabIndex = 40;
            this.lblAchternaam.Text = "Achternaam";
            // 
            // lblVoornaam
            // 
            this.lblVoornaam.AutoSize = true;
            this.lblVoornaam.Location = new System.Drawing.Point(193, 109);
            this.lblVoornaam.Name = "lblVoornaam";
            this.lblVoornaam.Size = new System.Drawing.Size(70, 16);
            this.lblVoornaam.TabIndex = 39;
            this.lblVoornaam.Text = "Voornaam";
            // 
            // lblStudentNummer
            // 
            this.lblStudentNummer.AutoSize = true;
            this.lblStudentNummer.Location = new System.Drawing.Point(200, 78);
            this.lblStudentNummer.Name = "lblStudentNummer";
            this.lblStudentNummer.Size = new System.Drawing.Size(63, 16);
            this.lblStudentNummer.TabIndex = 38;
            this.lblStudentNummer.Text = "Studentnr";
            // 
            // lblKlas
            // 
            this.lblKlas.AutoSize = true;
            this.lblKlas.Location = new System.Drawing.Point(230, 168);
            this.lblKlas.Name = "lblKlas";
            this.lblKlas.Size = new System.Drawing.Size(33, 16);
            this.lblKlas.TabIndex = 37;
            this.lblKlas.Text = "Klas";
            // 
            // cbxKlas
            // 
            this.cbxKlas.FormattingEnabled = true;
            this.cbxKlas.Location = new System.Drawing.Point(294, 165);
            this.cbxKlas.Name = "cbxKlas";
            this.cbxKlas.Size = new System.Drawing.Size(201, 24);
            this.cbxKlas.TabIndex = 36;
            // 
            // cbxKluisnr
            // 
            this.cbxKluisnr.FormattingEnabled = true;
            this.cbxKluisnr.Location = new System.Drawing.Point(294, 195);
            this.cbxKluisnr.Name = "cbxKluisnr";
            this.cbxKluisnr.Size = new System.Drawing.Size(201, 24);
            this.cbxKluisnr.TabIndex = 45;
            // 
            // lblKluisNr
            // 
            this.lblKluisNr.AutoSize = true;
            this.lblKluisNr.Location = new System.Drawing.Point(174, 198);
            this.lblKluisNr.Name = "lblKluisNr";
            this.lblKluisNr.Size = new System.Drawing.Size(89, 16);
            this.lblKluisNr.TabIndex = 46;
            this.lblKluisNr.Text = "Kluis Nummer";
            // 
            // lblOpmerkingen
            // 
            this.lblOpmerkingen.AutoSize = true;
            this.lblOpmerkingen.Location = new System.Drawing.Point(175, 231);
            this.lblOpmerkingen.Name = "lblOpmerkingen";
            this.lblOpmerkingen.Size = new System.Drawing.Size(88, 16);
            this.lblOpmerkingen.TabIndex = 47;
            this.lblOpmerkingen.Text = "Opmerkingen";
            // 
            // txtOpmerkingen
            // 
            this.txtOpmerkingen.Location = new System.Drawing.Point(294, 225);
            this.txtOpmerkingen.Name = "txtOpmerkingen";
            this.txtOpmerkingen.Size = new System.Drawing.Size(201, 22);
            this.txtOpmerkingen.TabIndex = 48;
            // 
            // Invoer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtOpmerkingen);
            this.Controls.Add(this.lblOpmerkingen);
            this.Controls.Add(this.lblKluisNr);
            this.Controls.Add(this.cbxKluisnr);
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

        private System.Windows.Forms.Button btnInvoer;
        private System.Windows.Forms.TextBox txtStudentnr;
        private System.Windows.Forms.TextBox txtVoornaam;
        private System.Windows.Forms.TextBox txtAchternaam;
        private System.Windows.Forms.Label lblAchternaam;
        private System.Windows.Forms.Label lblVoornaam;
        private System.Windows.Forms.Label lblStudentNummer;
        private System.Windows.Forms.Label lblKlas;
        private System.Windows.Forms.ComboBox cbxKlas;
        private System.Windows.Forms.ComboBox cbxKluisnr;
        private System.Windows.Forms.Label lblKluisNr;
        private System.Windows.Forms.Label lblOpmerkingen;
        private System.Windows.Forms.TextBox txtOpmerkingen;
    }
}