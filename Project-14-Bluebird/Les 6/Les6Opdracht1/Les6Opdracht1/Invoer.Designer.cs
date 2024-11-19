namespace Les6Opdracht1
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
            this.txtOpmerkingen = new System.Windows.Forms.TextBox();
            this.lblOpmerkingen = new System.Windows.Forms.Label();
            this.lblKluisNr = new System.Windows.Forms.Label();
            this.cbxKluisnr = new System.Windows.Forms.ComboBox();
            this.btnInvoer = new System.Windows.Forms.Button();
            this.txtStudentnr = new System.Windows.Forms.TextBox();
            this.txtVoornaam = new System.Windows.Forms.TextBox();
            this.txtAchternaam = new System.Windows.Forms.TextBox();
            this.lblAchternaam = new System.Windows.Forms.Label();
            this.lblVoornaam = new System.Windows.Forms.Label();
            this.lblStudentNummer = new System.Windows.Forms.Label();
            this.lblKlas = new System.Windows.Forms.Label();
            this.cbxKlas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtOpmerkingen
            // 
            this.txtOpmerkingen.Location = new System.Drawing.Point(303, 198);
            this.txtOpmerkingen.Name = "txtOpmerkingen";
            this.txtOpmerkingen.Size = new System.Drawing.Size(201, 22);
            this.txtOpmerkingen.TabIndex = 61;
            // 
            // lblOpmerkingen
            // 
            this.lblOpmerkingen.AutoSize = true;
            this.lblOpmerkingen.Location = new System.Drawing.Point(184, 204);
            this.lblOpmerkingen.Name = "lblOpmerkingen";
            this.lblOpmerkingen.Size = new System.Drawing.Size(88, 16);
            this.lblOpmerkingen.TabIndex = 60;
            this.lblOpmerkingen.Text = "Opmerkingen";
            // 
            // lblKluisNr
            // 
            this.lblKluisNr.AutoSize = true;
            this.lblKluisNr.Location = new System.Drawing.Point(183, 171);
            this.lblKluisNr.Name = "lblKluisNr";
            this.lblKluisNr.Size = new System.Drawing.Size(89, 16);
            this.lblKluisNr.TabIndex = 59;
            this.lblKluisNr.Text = "Kluis Nummer";
            // 
            // cbxKluisnr
            // 
            this.cbxKluisnr.FormattingEnabled = true;
            this.cbxKluisnr.Location = new System.Drawing.Point(303, 168);
            this.cbxKluisnr.Name = "cbxKluisnr";
            this.cbxKluisnr.Size = new System.Drawing.Size(201, 24);
            this.cbxKluisnr.TabIndex = 58;
            // 
            // btnInvoer
            // 
            this.btnInvoer.Location = new System.Drawing.Point(205, 260);
            this.btnInvoer.Name = "btnInvoer";
            this.btnInvoer.Size = new System.Drawing.Size(412, 140);
            this.btnInvoer.TabIndex = 57;
            this.btnInvoer.Text = "Voer In";
            this.btnInvoer.UseVisualStyleBackColor = true;
            this.btnInvoer.Click += new System.EventHandler(this.btnInvoer_Click);
            // 
            // txtStudentnr
            // 
            this.txtStudentnr.Location = new System.Drawing.Point(303, 51);
            this.txtStudentnr.Name = "txtStudentnr";
            this.txtStudentnr.Size = new System.Drawing.Size(201, 22);
            this.txtStudentnr.TabIndex = 56;
            // 
            // txtVoornaam
            // 
            this.txtVoornaam.Location = new System.Drawing.Point(303, 82);
            this.txtVoornaam.Name = "txtVoornaam";
            this.txtVoornaam.Size = new System.Drawing.Size(201, 22);
            this.txtVoornaam.TabIndex = 55;
            // 
            // txtAchternaam
            // 
            this.txtAchternaam.Location = new System.Drawing.Point(303, 110);
            this.txtAchternaam.Name = "txtAchternaam";
            this.txtAchternaam.Size = new System.Drawing.Size(201, 22);
            this.txtAchternaam.TabIndex = 54;
            // 
            // lblAchternaam
            // 
            this.lblAchternaam.AutoSize = true;
            this.lblAchternaam.Location = new System.Drawing.Point(193, 110);
            this.lblAchternaam.Name = "lblAchternaam";
            this.lblAchternaam.Size = new System.Drawing.Size(79, 16);
            this.lblAchternaam.TabIndex = 53;
            this.lblAchternaam.Text = "Achternaam";
            // 
            // lblVoornaam
            // 
            this.lblVoornaam.AutoSize = true;
            this.lblVoornaam.Location = new System.Drawing.Point(202, 82);
            this.lblVoornaam.Name = "lblVoornaam";
            this.lblVoornaam.Size = new System.Drawing.Size(70, 16);
            this.lblVoornaam.TabIndex = 52;
            this.lblVoornaam.Text = "Voornaam";
            // 
            // lblStudentNummer
            // 
            this.lblStudentNummer.AutoSize = true;
            this.lblStudentNummer.Location = new System.Drawing.Point(209, 51);
            this.lblStudentNummer.Name = "lblStudentNummer";
            this.lblStudentNummer.Size = new System.Drawing.Size(63, 16);
            this.lblStudentNummer.TabIndex = 51;
            this.lblStudentNummer.Text = "Studentnr";
            // 
            // lblKlas
            // 
            this.lblKlas.AutoSize = true;
            this.lblKlas.Location = new System.Drawing.Point(239, 141);
            this.lblKlas.Name = "lblKlas";
            this.lblKlas.Size = new System.Drawing.Size(33, 16);
            this.lblKlas.TabIndex = 50;
            this.lblKlas.Text = "Klas";
            // 
            // cbxKlas
            // 
            this.cbxKlas.FormattingEnabled = true;
            this.cbxKlas.Location = new System.Drawing.Point(303, 138);
            this.cbxKlas.Name = "cbxKlas";
            this.cbxKlas.Size = new System.Drawing.Size(201, 24);
            this.cbxKlas.TabIndex = 49;
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

        private System.Windows.Forms.TextBox txtOpmerkingen;
        private System.Windows.Forms.Label lblOpmerkingen;
        private System.Windows.Forms.Label lblKluisNr;
        private System.Windows.Forms.ComboBox cbxKluisnr;
        private System.Windows.Forms.Button btnInvoer;
        private System.Windows.Forms.TextBox txtStudentnr;
        private System.Windows.Forms.TextBox txtVoornaam;
        private System.Windows.Forms.TextBox txtAchternaam;
        private System.Windows.Forms.Label lblAchternaam;
        private System.Windows.Forms.Label lblVoornaam;
        private System.Windows.Forms.Label lblStudentNummer;
        private System.Windows.Forms.Label lblKlas;
        private System.Windows.Forms.ComboBox cbxKlas;
    }
}