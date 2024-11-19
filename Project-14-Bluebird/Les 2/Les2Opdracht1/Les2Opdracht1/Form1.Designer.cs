namespace Les2Opdracht1
{
    partial class Form1
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
            this.cbxKlassen = new System.Windows.Forms.ComboBox();
            this.lblVoornaam = new System.Windows.Forms.Label();
            this.lblKlas = new System.Windows.Forms.Label();
            this.lblStudentNummer = new System.Windows.Forms.Label();
            this.lblAchternaam = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbxKlassen
            // 
            this.cbxKlassen.FormattingEnabled = true;
            this.cbxKlassen.Location = new System.Drawing.Point(192, 211);
            this.cbxKlassen.Name = "cbxKlassen";
            this.cbxKlassen.Size = new System.Drawing.Size(272, 24);
            this.cbxKlassen.TabIndex = 0;
            // 
            // lblVoornaam
            // 
            this.lblVoornaam.AutoSize = true;
            this.lblVoornaam.Location = new System.Drawing.Point(104, 103);
            this.lblVoornaam.Name = "lblVoornaam";
            this.lblVoornaam.Size = new System.Drawing.Size(70, 16);
            this.lblVoornaam.TabIndex = 1;
            this.lblVoornaam.Text = "Voornaam";
            // 
            // lblKlas
            // 
            this.lblKlas.AutoSize = true;
            this.lblKlas.Location = new System.Drawing.Point(133, 156);
            this.lblKlas.Name = "lblKlas";
            this.lblKlas.Size = new System.Drawing.Size(32, 16);
            this.lblKlas.TabIndex = 2;
            this.lblKlas.Text = "klas";
            // 
            // lblStudentNummer
            // 
            this.lblStudentNummer.AutoSize = true;
            this.lblStudentNummer.Location = new System.Drawing.Point(71, 75);
            this.lblStudentNummer.Name = "lblStudentNummer";
            this.lblStudentNummer.Size = new System.Drawing.Size(103, 16);
            this.lblStudentNummer.TabIndex = 3;
            this.lblStudentNummer.Text = "StudentNummer";
            // 
            // lblAchternaam
            // 
            this.lblAchternaam.AutoSize = true;
            this.lblAchternaam.Location = new System.Drawing.Point(95, 131);
            this.lblAchternaam.Name = "lblAchternaam";
            this.lblAchternaam.Size = new System.Drawing.Size(79, 16);
            this.lblAchternaam.TabIndex = 4;
            this.lblAchternaam.Text = "Achternaam";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(210, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(210, 156);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(214, 22);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(210, 128);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(214, 22);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(210, 100);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(214, 22);
            this.textBox4.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblAchternaam);
            this.Controls.Add(this.lblStudentNummer);
            this.Controls.Add(this.lblKlas);
            this.Controls.Add(this.lblVoornaam);
            this.Controls.Add(this.cbxKlassen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxKlassen;
        private System.Windows.Forms.Label lblVoornaam;
        private System.Windows.Forms.Label lblKlas;
        private System.Windows.Forms.Label lblStudentNummer;
        private System.Windows.Forms.Label lblAchternaam;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}

