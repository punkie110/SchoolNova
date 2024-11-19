namespace Les1Opdracht2
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
            this.txtKlas = new System.Windows.Forms.TextBox();
            this.txtAchternaam = new System.Windows.Forms.TextBox();
            this.txtVoornaam = new System.Windows.Forms.TextBox();
            this.btnVoerIn = new System.Windows.Forms.Button();
            this.lblStudentnummer = new System.Windows.Forms.Label();
            this.lblVoornaam = new System.Windows.Forms.Label();
            this.lblAchternaam = new System.Windows.Forms.Label();
            this.lblKlascode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtStudentnr
            // 
            this.txtStudentnr.Location = new System.Drawing.Point(97, 49);
            this.txtStudentnr.Name = "txtStudentnr";
            this.txtStudentnr.Size = new System.Drawing.Size(267, 22);
            this.txtStudentnr.TabIndex = 0;
            // 
            // txtKlas
            // 
            this.txtKlas.Location = new System.Drawing.Point(97, 205);
            this.txtKlas.Name = "txtKlas";
            this.txtKlas.Size = new System.Drawing.Size(267, 22);
            this.txtKlas.TabIndex = 1;
            // 
            // txtAchternaam
            // 
            this.txtAchternaam.Location = new System.Drawing.Point(97, 153);
            this.txtAchternaam.Name = "txtAchternaam";
            this.txtAchternaam.Size = new System.Drawing.Size(267, 22);
            this.txtAchternaam.TabIndex = 2;
            // 
            // txtVoornaam
            // 
            this.txtVoornaam.Location = new System.Drawing.Point(97, 101);
            this.txtVoornaam.Name = "txtVoornaam";
            this.txtVoornaam.Size = new System.Drawing.Size(267, 22);
            this.txtVoornaam.TabIndex = 3;
            // 
            // btnVoerIn
            // 
            this.btnVoerIn.Location = new System.Drawing.Point(447, 70);
            this.btnVoerIn.Name = "btnVoerIn";
            this.btnVoerIn.Size = new System.Drawing.Size(312, 156);
            this.btnVoerIn.TabIndex = 4;
            this.btnVoerIn.Text = "Voer In";
            this.btnVoerIn.UseVisualStyleBackColor = true;
            this.btnVoerIn.Click += new System.EventHandler(this.btnVoerIn_Click);
            // 
            // lblStudentnummer
            // 
            this.lblStudentnummer.AutoSize = true;
            this.lblStudentnummer.Location = new System.Drawing.Point(133, 30);
            this.lblStudentnummer.Name = "lblStudentnummer";
            this.lblStudentnummer.Size = new System.Drawing.Size(103, 16);
            this.lblStudentnummer.TabIndex = 5;
            this.lblStudentnummer.Text = "Student nummer";
            // 
            // lblVoornaam
            // 
            this.lblVoornaam.AutoSize = true;
            this.lblVoornaam.Location = new System.Drawing.Point(133, 82);
            this.lblVoornaam.Name = "lblVoornaam";
            this.lblVoornaam.Size = new System.Drawing.Size(70, 16);
            this.lblVoornaam.TabIndex = 6;
            this.lblVoornaam.Text = "Voornaam";
            // 
            // lblAchternaam
            // 
            this.lblAchternaam.AutoSize = true;
            this.lblAchternaam.Location = new System.Drawing.Point(133, 134);
            this.lblAchternaam.Name = "lblAchternaam";
            this.lblAchternaam.Size = new System.Drawing.Size(79, 16);
            this.lblAchternaam.TabIndex = 7;
            this.lblAchternaam.Text = "Achternaam";
            // 
            // lblKlascode
            // 
            this.lblKlascode.AutoSize = true;
            this.lblKlascode.Location = new System.Drawing.Point(133, 186);
            this.lblKlascode.Name = "lblKlascode";
            this.lblKlascode.Size = new System.Drawing.Size(64, 16);
            this.lblKlascode.TabIndex = 8;
            this.lblKlascode.Text = "Klascode";
            // 
            // Invoer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKlascode);
            this.Controls.Add(this.lblAchternaam);
            this.Controls.Add(this.lblVoornaam);
            this.Controls.Add(this.lblStudentnummer);
            this.Controls.Add(this.btnVoerIn);
            this.Controls.Add(this.txtVoornaam);
            this.Controls.Add(this.txtAchternaam);
            this.Controls.Add(this.txtKlas);
            this.Controls.Add(this.txtStudentnr);
            this.Name = "Invoer";
            this.Text = "Invoer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStudentnr;
        private System.Windows.Forms.TextBox txtKlas;
        private System.Windows.Forms.TextBox txtAchternaam;
        private System.Windows.Forms.TextBox txtVoornaam;
        private System.Windows.Forms.Button btnVoerIn;
        private System.Windows.Forms.Label lblStudentnummer;
        private System.Windows.Forms.Label lblVoornaam;
        private System.Windows.Forms.Label lblAchternaam;
        private System.Windows.Forms.Label lblKlascode;
    }
}