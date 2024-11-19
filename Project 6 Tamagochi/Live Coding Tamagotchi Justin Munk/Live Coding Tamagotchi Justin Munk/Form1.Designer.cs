namespace Live_Coding_Tamagotchi_Justin_Munk
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
            this.grbBasisabonnement = new System.Windows.Forms.GroupBox();
            this.grbOpties = new System.Windows.Forms.GroupBox();
            this.lblPrijsPerMaand = new System.Windows.Forms.Label();
            this.btnBereken = new System.Windows.Forms.Button();
            this.rdbInternetCompleet = new System.Windows.Forms.RadioButton();
            this.rdbInternetMax = new System.Windows.Forms.RadioButton();
            this.txtPrijsPerMaand = new System.Windows.Forms.TextBox();
            this.txtTvAansluitingen = new System.Windows.Forms.TextBox();
            this.chkSafeOnline = new System.Windows.Forms.CheckBox();
            this.chkMoviesSeries = new System.Windows.Forms.CheckBox();
            this.lblAantalExtra = new System.Windows.Forms.Label();
            this.grbBasisabonnement.SuspendLayout();
            this.grbOpties.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbBasisabonnement
            // 
            this.grbBasisabonnement.Controls.Add(this.rdbInternetMax);
            this.grbBasisabonnement.Controls.Add(this.rdbInternetCompleet);
            this.grbBasisabonnement.Location = new System.Drawing.Point(61, 37);
            this.grbBasisabonnement.Name = "grbBasisabonnement";
            this.grbBasisabonnement.Size = new System.Drawing.Size(331, 103);
            this.grbBasisabonnement.TabIndex = 0;
            this.grbBasisabonnement.TabStop = false;
            this.grbBasisabonnement.Text = "Basisabonnement";
            // 
            // grbOpties
            // 
            this.grbOpties.Controls.Add(this.lblAantalExtra);
            this.grbOpties.Controls.Add(this.chkMoviesSeries);
            this.grbOpties.Controls.Add(this.chkSafeOnline);
            this.grbOpties.Controls.Add(this.txtTvAansluitingen);
            this.grbOpties.Location = new System.Drawing.Point(61, 181);
            this.grbOpties.Name = "grbOpties";
            this.grbOpties.Size = new System.Drawing.Size(331, 129);
            this.grbOpties.TabIndex = 1;
            this.grbOpties.TabStop = false;
            this.grbOpties.Text = "Opties";
            // 
            // lblPrijsPerMaand
            // 
            this.lblPrijsPerMaand.AutoSize = true;
            this.lblPrijsPerMaand.Location = new System.Drawing.Point(619, 52);
            this.lblPrijsPerMaand.Name = "lblPrijsPerMaand";
            this.lblPrijsPerMaand.Size = new System.Drawing.Size(101, 16);
            this.lblPrijsPerMaand.TabIndex = 2;
            this.lblPrijsPerMaand.Text = "Prijs per maand";
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(61, 351);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(313, 42);
            this.btnBereken.TabIndex = 3;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // rdbInternetCompleet
            // 
            this.rdbInternetCompleet.AutoSize = true;
            this.rdbInternetCompleet.Location = new System.Drawing.Point(28, 21);
            this.rdbInternetCompleet.Name = "rdbInternetCompleet";
            this.rdbInternetCompleet.Size = new System.Drawing.Size(204, 20);
            this.rdbInternetCompleet.TabIndex = 0;
            this.rdbInternetCompleet.TabStop = true;
            this.rdbInternetCompleet.Text = "Internet Compleet (59,95 euro)";
            this.rdbInternetCompleet.UseVisualStyleBackColor = true;
            // 
            // rdbInternetMax
            // 
            this.rdbInternetMax.AutoSize = true;
            this.rdbInternetMax.Location = new System.Drawing.Point(28, 64);
            this.rdbInternetMax.Name = "rdbInternetMax";
            this.rdbInternetMax.Size = new System.Drawing.Size(171, 20);
            this.rdbInternetMax.TabIndex = 1;
            this.rdbInternetMax.TabStop = true;
            this.rdbInternetMax.Text = "Internet Max (67,50 euro)";
            this.rdbInternetMax.UseVisualStyleBackColor = true;
            // 
            // txtPrijsPerMaand
            // 
            this.txtPrijsPerMaand.Location = new System.Drawing.Point(622, 86);
            this.txtPrijsPerMaand.Name = "txtPrijsPerMaand";
            this.txtPrijsPerMaand.ReadOnly = true;
            this.txtPrijsPerMaand.Size = new System.Drawing.Size(118, 22);
            this.txtPrijsPerMaand.TabIndex = 4;
            // 
            // txtTvAansluitingen
            // 
            this.txtTvAansluitingen.Location = new System.Drawing.Point(16, 101);
            this.txtTvAansluitingen.Name = "txtTvAansluitingen";
            this.txtTvAansluitingen.Size = new System.Drawing.Size(88, 22);
            this.txtTvAansluitingen.TabIndex = 0;
            // 
            // chkSafeOnline
            // 
            this.chkSafeOnline.AutoSize = true;
            this.chkSafeOnline.Location = new System.Drawing.Point(12, 39);
            this.chkSafeOnline.Name = "chkSafeOnline";
            this.chkSafeOnline.Size = new System.Drawing.Size(163, 20);
            this.chkSafeOnline.TabIndex = 1;
            this.chkSafeOnline.Text = "Safe Online (6,95 euro)";
            this.chkSafeOnline.UseVisualStyleBackColor = true;
            // 
            // chkMoviesSeries
            // 
            this.chkMoviesSeries.AutoSize = true;
            this.chkMoviesSeries.Location = new System.Drawing.Point(12, 75);
            this.chkMoviesSeries.Name = "chkMoviesSeries";
            this.chkMoviesSeries.Size = new System.Drawing.Size(187, 20);
            this.chkMoviesSeries.TabIndex = 2;
            this.chkMoviesSeries.Text = "Movies Series (11,95 euro)";
            this.chkMoviesSeries.UseVisualStyleBackColor = true;
            // 
            // lblAantalExtra
            // 
            this.lblAantalExtra.AutoSize = true;
            this.lblAantalExtra.Location = new System.Drawing.Point(122, 104);
            this.lblAantalExtra.Name = "lblAantalExtra";
            this.lblAantalExtra.Size = new System.Drawing.Size(173, 16);
            this.lblAantalExtra.TabIndex = 3;
            this.lblAantalExtra.Text = "Aantal extra tv-aansluitingen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPrijsPerMaand);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.lblPrijsPerMaand);
            this.Controls.Add(this.grbOpties);
            this.Controls.Add(this.grbBasisabonnement);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbBasisabonnement.ResumeLayout(false);
            this.grbBasisabonnement.PerformLayout();
            this.grbOpties.ResumeLayout(false);
            this.grbOpties.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbBasisabonnement;
        private System.Windows.Forms.RadioButton rdbInternetMax;
        private System.Windows.Forms.RadioButton rdbInternetCompleet;
        private System.Windows.Forms.GroupBox grbOpties;
        private System.Windows.Forms.Label lblPrijsPerMaand;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.TextBox txtPrijsPerMaand;
        private System.Windows.Forms.Label lblAantalExtra;
        private System.Windows.Forms.CheckBox chkMoviesSeries;
        private System.Windows.Forms.CheckBox chkSafeOnline;
        private System.Windows.Forms.TextBox txtTvAansluitingen;
    }
}

