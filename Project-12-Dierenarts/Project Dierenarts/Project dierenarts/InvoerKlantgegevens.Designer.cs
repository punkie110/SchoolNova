namespace Project_dierenarts
{
    partial class InvoerKlantgegevens
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
            this.btnVoerIn = new System.Windows.Forms.Button();
            this.txtVoorletters = new System.Windows.Forms.TextBox();
            this.txtWoonplaats = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtAchternaam = new System.Windows.Forms.TextBox();
            this.lblVoorletters = new System.Windows.Forms.Label();
            this.lblWoonplaats = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblAchternaam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVoerIn
            // 
            this.btnVoerIn.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoerIn.Location = new System.Drawing.Point(158, 286);
            this.btnVoerIn.Name = "btnVoerIn";
            this.btnVoerIn.Size = new System.Drawing.Size(483, 79);
            this.btnVoerIn.TabIndex = 0;
            this.btnVoerIn.Text = "Voer in";
            this.btnVoerIn.UseVisualStyleBackColor = true;
            this.btnVoerIn.Click += new System.EventHandler(this.btnVoerIn_Click);
            // 
            // txtVoorletters
            // 
            this.txtVoorletters.Location = new System.Drawing.Point(401, 90);
            this.txtVoorletters.Name = "txtVoorletters";
            this.txtVoorletters.Size = new System.Drawing.Size(169, 22);
            this.txtVoorletters.TabIndex = 1;
            // 
            // txtWoonplaats
            // 
            this.txtWoonplaats.Location = new System.Drawing.Point(401, 236);
            this.txtWoonplaats.Name = "txtWoonplaats";
            this.txtWoonplaats.Size = new System.Drawing.Size(169, 22);
            this.txtWoonplaats.TabIndex = 2;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(401, 188);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(169, 22);
            this.txtAdres.TabIndex = 3;
            // 
            // txtAchternaam
            // 
            this.txtAchternaam.Location = new System.Drawing.Point(401, 139);
            this.txtAchternaam.Name = "txtAchternaam";
            this.txtAchternaam.Size = new System.Drawing.Size(169, 22);
            this.txtAchternaam.TabIndex = 4;
            // 
            // lblVoorletters
            // 
            this.lblVoorletters.AutoSize = true;
            this.lblVoorletters.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoorletters.Location = new System.Drawing.Point(182, 85);
            this.lblVoorletters.Name = "lblVoorletters";
            this.lblVoorletters.Size = new System.Drawing.Size(130, 27);
            this.lblVoorletters.TabIndex = 5;
            this.lblVoorletters.Text = "Voorletters:";
            // 
            // lblWoonplaats
            // 
            this.lblWoonplaats.AutoSize = true;
            this.lblWoonplaats.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWoonplaats.Location = new System.Drawing.Point(182, 231);
            this.lblWoonplaats.Name = "lblWoonplaats";
            this.lblWoonplaats.Size = new System.Drawing.Size(140, 27);
            this.lblWoonplaats.TabIndex = 6;
            this.lblWoonplaats.Text = "Woonplaats:";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdres.Location = new System.Drawing.Point(182, 183);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(76, 27);
            this.lblAdres.TabIndex = 7;
            this.lblAdres.Text = "Adres:";
            // 
            // lblAchternaam
            // 
            this.lblAchternaam.AutoSize = true;
            this.lblAchternaam.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAchternaam.Location = new System.Drawing.Point(182, 134);
            this.lblAchternaam.Name = "lblAchternaam";
            this.lblAchternaam.Size = new System.Drawing.Size(141, 27);
            this.lblAchternaam.TabIndex = 8;
            this.lblAchternaam.Text = "Achternaam:";
            // 
            // InvoerKlantgegevens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAchternaam);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblWoonplaats);
            this.Controls.Add(this.lblVoorletters);
            this.Controls.Add(this.txtAchternaam);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtWoonplaats);
            this.Controls.Add(this.txtVoorletters);
            this.Controls.Add(this.btnVoerIn);
            this.Name = "InvoerKlantgegevens";
            this.Text = "InvoerKlantgegevens";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoerIn;
        private System.Windows.Forms.TextBox txtVoorletters;
        private System.Windows.Forms.TextBox txtWoonplaats;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtAchternaam;
        private System.Windows.Forms.Label lblVoorletters;
        private System.Windows.Forms.Label lblWoonplaats;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblAchternaam;
    }
}