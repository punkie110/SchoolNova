namespace Les4Opdracht2
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
            this.inloggen = new System.Windows.Forms.GroupBox();
            this.btnInlog = new System.Windows.Forms.Button();
            this.gebruikersnaam = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGebruikersnaam = new System.Windows.Forms.TextBox();
            this.txtWachtwoord = new System.Windows.Forms.TextBox();
            this.inloggen.SuspendLayout();
            this.SuspendLayout();
            // 
            // inloggen
            // 
            this.inloggen.Controls.Add(this.btnInlog);
            this.inloggen.Controls.Add(this.gebruikersnaam);
            this.inloggen.Controls.Add(this.label2);
            this.inloggen.Controls.Add(this.txtGebruikersnaam);
            this.inloggen.Controls.Add(this.txtWachtwoord);
            this.inloggen.Location = new System.Drawing.Point(11, 21);
            this.inloggen.Margin = new System.Windows.Forms.Padding(2);
            this.inloggen.Name = "inloggen";
            this.inloggen.Padding = new System.Windows.Forms.Padding(2);
            this.inloggen.Size = new System.Drawing.Size(302, 151);
            this.inloggen.TabIndex = 6;
            this.inloggen.TabStop = false;
            this.inloggen.Text = "inloggen";
            // 
            // btnInlog
            // 
            this.btnInlog.Location = new System.Drawing.Point(163, 108);
            this.btnInlog.Margin = new System.Windows.Forms.Padding(2);
            this.btnInlog.Name = "btnInlog";
            this.btnInlog.Size = new System.Drawing.Size(105, 27);
            this.btnInlog.TabIndex = 0;
            this.btnInlog.Text = "inloggen";
            this.btnInlog.UseVisualStyleBackColor = true;
            this.btnInlog.Click += new System.EventHandler(this.btnInlog_Click);
            // 
            // gebruikersnaam
            // 
            this.gebruikersnaam.AutoSize = true;
            this.gebruikersnaam.Location = new System.Drawing.Point(26, 28);
            this.gebruikersnaam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gebruikersnaam.Name = "gebruikersnaam";
            this.gebruikersnaam.Size = new System.Drawing.Size(105, 16);
            this.gebruikersnaam.TabIndex = 1;
            this.gebruikersnaam.Text = "gebruikersnaam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "wachtwoord";
            // 
            // txtGebruikersnaam
            // 
            this.txtGebruikersnaam.Location = new System.Drawing.Point(163, 28);
            this.txtGebruikersnaam.Margin = new System.Windows.Forms.Padding(2);
            this.txtGebruikersnaam.Name = "txtGebruikersnaam";
            this.txtGebruikersnaam.Size = new System.Drawing.Size(107, 22);
            this.txtGebruikersnaam.TabIndex = 3;
            // 
            // txtWachtwoord
            // 
            this.txtWachtwoord.Location = new System.Drawing.Point(163, 67);
            this.txtWachtwoord.Margin = new System.Windows.Forms.Padding(2);
            this.txtWachtwoord.Name = "txtWachtwoord";
            this.txtWachtwoord.PasswordChar = '*';
            this.txtWachtwoord.Size = new System.Drawing.Size(107, 22);
            this.txtWachtwoord.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 193);
            this.Controls.Add(this.inloggen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.inloggen.ResumeLayout(false);
            this.inloggen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox inloggen;
        private System.Windows.Forms.Button btnInlog;
        private System.Windows.Forms.Label gebruikersnaam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGebruikersnaam;
        private System.Windows.Forms.TextBox txtWachtwoord;
    }
}

