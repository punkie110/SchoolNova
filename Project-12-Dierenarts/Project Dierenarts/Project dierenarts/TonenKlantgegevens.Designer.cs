namespace Project_dierenarts
{
    partial class TonenKlantgegevens
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
            this.lbxOverzicht = new System.Windows.Forms.ListBox();
            this.btnNieuw = new System.Windows.Forms.Button();
            this.txtInfoWoonplaats = new System.Windows.Forms.TextBox();
            this.txtInfoAdres = new System.Windows.Forms.TextBox();
            this.txtInfoAchternaam = new System.Windows.Forms.TextBox();
            this.txtInfoVoorletters = new System.Windows.Forms.TextBox();
            this.lblVoorletters = new System.Windows.Forms.Label();
            this.btnwijzig = new System.Windows.Forms.Button();
            this.lblKlant = new System.Windows.Forms.Label();
            this.lblWoonplaats = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblAchternaam = new System.Windows.Forms.Label();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.btnBehandelingen = new System.Windows.Forms.Button();
            this.btnAlleBehandelingen = new System.Windows.Forms.Button();
            this.btnVoegBehandelingen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxOverzicht
            // 
            this.lbxOverzicht.BackColor = System.Drawing.SystemColors.Menu;
            this.lbxOverzicht.FormattingEnabled = true;
            this.lbxOverzicht.ItemHeight = 16;
            this.lbxOverzicht.Location = new System.Drawing.Point(12, 99);
            this.lbxOverzicht.Name = "lbxOverzicht";
            this.lbxOverzicht.Size = new System.Drawing.Size(423, 276);
            this.lbxOverzicht.TabIndex = 0;
            this.lbxOverzicht.SelectedIndexChanged += new System.EventHandler(this.lbxOverzicht_SelectedIndexChanged);
            // 
            // btnNieuw
            // 
            this.btnNieuw.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNieuw.Location = new System.Drawing.Point(12, 378);
            this.btnNieuw.Name = "btnNieuw";
            this.btnNieuw.Size = new System.Drawing.Size(207, 60);
            this.btnNieuw.TabIndex = 1;
            this.btnNieuw.Text = "Nieuwe Klant";
            this.btnNieuw.UseVisualStyleBackColor = true;
            this.btnNieuw.Click += new System.EventHandler(this.btnNieuw_Click);
            // 
            // txtInfoWoonplaats
            // 
            this.txtInfoWoonplaats.Location = new System.Drawing.Point(625, 237);
            this.txtInfoWoonplaats.Margin = new System.Windows.Forms.Padding(2);
            this.txtInfoWoonplaats.Name = "txtInfoWoonplaats";
            this.txtInfoWoonplaats.Size = new System.Drawing.Size(135, 22);
            this.txtInfoWoonplaats.TabIndex = 18;
            // 
            // txtInfoAdres
            // 
            this.txtInfoAdres.Location = new System.Drawing.Point(625, 192);
            this.txtInfoAdres.Margin = new System.Windows.Forms.Padding(2);
            this.txtInfoAdres.Name = "txtInfoAdres";
            this.txtInfoAdres.Size = new System.Drawing.Size(135, 22);
            this.txtInfoAdres.TabIndex = 17;
            // 
            // txtInfoAchternaam
            // 
            this.txtInfoAchternaam.Location = new System.Drawing.Point(625, 152);
            this.txtInfoAchternaam.Margin = new System.Windows.Forms.Padding(2);
            this.txtInfoAchternaam.Name = "txtInfoAchternaam";
            this.txtInfoAchternaam.Size = new System.Drawing.Size(135, 22);
            this.txtInfoAchternaam.TabIndex = 16;
            // 
            // txtInfoVoorletters
            // 
            this.txtInfoVoorletters.Location = new System.Drawing.Point(625, 108);
            this.txtInfoVoorletters.Margin = new System.Windows.Forms.Padding(2);
            this.txtInfoVoorletters.Name = "txtInfoVoorletters";
            this.txtInfoVoorletters.Size = new System.Drawing.Size(135, 22);
            this.txtInfoVoorletters.TabIndex = 10;
            // 
            // lblVoorletters
            // 
            this.lblVoorletters.AutoSize = true;
            this.lblVoorletters.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoorletters.Location = new System.Drawing.Point(467, 111);
            this.lblVoorletters.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVoorletters.Name = "lblVoorletters";
            this.lblVoorletters.Size = new System.Drawing.Size(88, 19);
            this.lblVoorletters.TabIndex = 7;
            this.lblVoorletters.Text = "Voorletters:";
            // 
            // btnwijzig
            // 
            this.btnwijzig.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnwijzig.Location = new System.Drawing.Point(691, 347);
            this.btnwijzig.Margin = new System.Windows.Forms.Padding(2);
            this.btnwijzig.Name = "btnwijzig";
            this.btnwijzig.Size = new System.Drawing.Size(98, 28);
            this.btnwijzig.TabIndex = 5;
            this.btnwijzig.Text = "wijzigen";
            this.btnwijzig.UseVisualStyleBackColor = true;
            this.btnwijzig.Click += new System.EventHandler(this.btnwijzig_Click);
            // 
            // lblKlant
            // 
            this.lblKlant.AutoSize = true;
            this.lblKlant.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKlant.Location = new System.Drawing.Point(620, 53);
            this.lblKlant.Name = "lblKlant";
            this.lblKlant.Size = new System.Drawing.Size(63, 25);
            this.lblKlant.TabIndex = 19;
            this.lblKlant.Text = "Klant:";
            // 
            // lblWoonplaats
            // 
            this.lblWoonplaats.AutoSize = true;
            this.lblWoonplaats.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWoonplaats.Location = new System.Drawing.Point(467, 238);
            this.lblWoonplaats.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWoonplaats.Name = "lblWoonplaats";
            this.lblWoonplaats.Size = new System.Drawing.Size(93, 19);
            this.lblWoonplaats.TabIndex = 20;
            this.lblWoonplaats.Text = "Woonplaats:";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdres.Location = new System.Drawing.Point(484, 195);
            this.lblAdres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(52, 19);
            this.lblAdres.TabIndex = 21;
            this.lblAdres.Text = "Adres:";
            // 
            // lblAchternaam
            // 
            this.lblAchternaam.AutoSize = true;
            this.lblAchternaam.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAchternaam.Location = new System.Drawing.Point(467, 152);
            this.lblAchternaam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAchternaam.Name = "lblAchternaam";
            this.lblAchternaam.Size = new System.Drawing.Size(94, 19);
            this.lblAchternaam.TabIndex = 22;
            this.lblAchternaam.Text = "Achternaam:";
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerwijder.Location = new System.Drawing.Point(536, 347);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(102, 28);
            this.btnVerwijder.TabIndex = 23;
            this.btnVerwijder.Text = "Verwijder";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // btnBehandelingen
            // 
            this.btnBehandelingen.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBehandelingen.Location = new System.Drawing.Point(609, 395);
            this.btnBehandelingen.Name = "btnBehandelingen";
            this.btnBehandelingen.Size = new System.Drawing.Size(151, 43);
            this.btnBehandelingen.TabIndex = 24;
            this.btnBehandelingen.Text = "Behandelingen";
            this.btnBehandelingen.UseVisualStyleBackColor = true;
            this.btnBehandelingen.Click += new System.EventHandler(this.btnBehandelingen_Click);
            // 
            // btnAlleBehandelingen
            // 
            this.btnAlleBehandelingen.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlleBehandelingen.Location = new System.Drawing.Point(252, 378);
            this.btnAlleBehandelingen.Name = "btnAlleBehandelingen";
            this.btnAlleBehandelingen.Size = new System.Drawing.Size(183, 60);
            this.btnAlleBehandelingen.TabIndex = 25;
            this.btnAlleBehandelingen.Text = "Alle Behandelingen";
            this.btnAlleBehandelingen.UseVisualStyleBackColor = true;
            this.btnAlleBehandelingen.Click += new System.EventHandler(this.btnAlleBehandelingen_Click);
            // 
            // btnVoegBehandelingen
            // 
            this.btnVoegBehandelingen.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoegBehandelingen.Location = new System.Drawing.Point(591, 294);
            this.btnVoegBehandelingen.Name = "btnVoegBehandelingen";
            this.btnVoegBehandelingen.Size = new System.Drawing.Size(169, 36);
            this.btnVoegBehandelingen.TabIndex = 26;
            this.btnVoegBehandelingen.Text = "Voeg behandeling toe";
            this.btnVoegBehandelingen.UseVisualStyleBackColor = true;
            this.btnVoegBehandelingen.Click += new System.EventHandler(this.btnVoegBehandelingen_Click);
            // 
            // TonenKlantgegevens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoegBehandelingen);
            this.Controls.Add(this.btnAlleBehandelingen);
            this.Controls.Add(this.btnBehandelingen);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.lblAchternaam);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblWoonplaats);
            this.Controls.Add(this.lblKlant);
            this.Controls.Add(this.txtInfoWoonplaats);
            this.Controls.Add(this.txtInfoAdres);
            this.Controls.Add(this.txtInfoAchternaam);
            this.Controls.Add(this.btnwijzig);
            this.Controls.Add(this.btnNieuw);
            this.Controls.Add(this.lbxOverzicht);
            this.Controls.Add(this.lblVoorletters);
            this.Controls.Add(this.txtInfoVoorletters);
            this.Name = "TonenKlantgegevens";
            this.Text = "TonenKlantgegevens";
            this.Load += new System.EventHandler(this.TonenKlantgegevens_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxOverzicht;
        private System.Windows.Forms.Button btnNieuw;
        private System.Windows.Forms.TextBox txtInfoWoonplaats;
        private System.Windows.Forms.TextBox txtInfoAdres;
        private System.Windows.Forms.TextBox txtInfoAchternaam;
        private System.Windows.Forms.TextBox txtInfoVoorletters;
        private System.Windows.Forms.Label lblVoorletters;
        private System.Windows.Forms.Button btnwijzig;
        private System.Windows.Forms.Label lblKlant;
        private System.Windows.Forms.Label lblWoonplaats;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblAchternaam;
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.Button btnBehandelingen;
        private System.Windows.Forms.Button btnAlleBehandelingen;
        private System.Windows.Forms.Button btnVoegBehandelingen;
    }
}