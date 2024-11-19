namespace Project_Bluebird
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
            this.gbClass = new System.Windows.Forms.GroupBox();
            this.rdbAlle = new System.Windows.Forms.RadioButton();
            this.rdbEconomy = new System.Windows.Forms.RadioButton();
            this.rdbBusiness = new System.Windows.Forms.RadioButton();
            this.rdbFirst = new System.Windows.Forms.RadioButton();
            this.lbxClass = new System.Windows.Forms.ListBox();
            this.lblNaam = new System.Windows.Forms.Label();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.lblStoelnummer = new System.Windows.Forms.Label();
            this.cbxStoelNummer = new System.Windows.Forms.ComboBox();
            this.btnAfsluiten = new RoundedButton();
            this.btnVrijgeven = new RoundedButton();
            this.btnToevoegen = new RoundedButton();
            this.lblBluebird = new System.Windows.Forms.Label();
            this.gbClass.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbClass
            // 
            this.gbClass.Controls.Add(this.rdbAlle);
            this.gbClass.Controls.Add(this.rdbEconomy);
            this.gbClass.Controls.Add(this.rdbBusiness);
            this.gbClass.Controls.Add(this.rdbFirst);
            this.gbClass.Location = new System.Drawing.Point(375, 341);
            this.gbClass.Name = "gbClass";
            this.gbClass.Size = new System.Drawing.Size(627, 290);
            this.gbClass.TabIndex = 0;
            this.gbClass.TabStop = false;
            this.gbClass.Text = "Class";
            // 
            // rdbAlle
            // 
            this.rdbAlle.AutoSize = true;
            this.rdbAlle.Font = new System.Drawing.Font("NSimSun", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAlle.Location = new System.Drawing.Point(356, 239);
            this.rdbAlle.Name = "rdbAlle";
            this.rdbAlle.Size = new System.Drawing.Size(243, 32);
            this.rdbAlle.TabIndex = 3;
            this.rdbAlle.TabStop = true;
            this.rdbAlle.Text = "Selecteer Alle";
            this.rdbAlle.UseVisualStyleBackColor = true;
            this.rdbAlle.CheckedChanged += new System.EventHandler(this.rdbAlle_CheckedChanged);
            // 
            // rdbEconomy
            // 
            this.rdbEconomy.AutoSize = true;
            this.rdbEconomy.Font = new System.Drawing.Font("Niagara Engraved", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEconomy.Location = new System.Drawing.Point(30, 190);
            this.rdbEconomy.Name = "rdbEconomy";
            this.rdbEconomy.Size = new System.Drawing.Size(189, 47);
            this.rdbEconomy.TabIndex = 2;
            this.rdbEconomy.TabStop = true;
            this.rdbEconomy.Text = "Economy Class";
            this.rdbEconomy.UseVisualStyleBackColor = true;
            this.rdbEconomy.CheckedChanged += new System.EventHandler(this.rdbEconomy_CheckedChanged);
            // 
            // rdbBusiness
            // 
            this.rdbBusiness.AutoSize = true;
            this.rdbBusiness.Font = new System.Drawing.Font("Old English Text MT", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbBusiness.Location = new System.Drawing.Point(30, 113);
            this.rdbBusiness.Name = "rdbBusiness";
            this.rdbBusiness.Size = new System.Drawing.Size(283, 48);
            this.rdbBusiness.TabIndex = 1;
            this.rdbBusiness.TabStop = true;
            this.rdbBusiness.Text = "Business Class";
            this.rdbBusiness.UseVisualStyleBackColor = true;
            this.rdbBusiness.CheckedChanged += new System.EventHandler(this.rdbBusiness_CheckedChanged);
            // 
            // rdbFirst
            // 
            this.rdbFirst.AutoSize = true;
            this.rdbFirst.Font = new System.Drawing.Font("Vladimir Script", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFirst.Location = new System.Drawing.Point(30, 50);
            this.rdbFirst.Name = "rdbFirst";
            this.rdbFirst.Size = new System.Drawing.Size(172, 44);
            this.rdbFirst.TabIndex = 0;
            this.rdbFirst.TabStop = true;
            this.rdbFirst.Text = "First Class";
            this.rdbFirst.UseVisualStyleBackColor = true;
            this.rdbFirst.CheckedChanged += new System.EventHandler(this.rdbFirst_CheckedChanged);
            // 
            // lbxClass
            // 
            this.lbxClass.Font = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxClass.FormattingEnabled = true;
            this.lbxClass.ItemHeight = 23;
            this.lbxClass.Location = new System.Drawing.Point(1379, 88);
            this.lbxClass.Name = "lbxClass";
            this.lbxClass.Size = new System.Drawing.Size(298, 671);
            this.lbxClass.TabIndex = 1;
            this.lbxClass.SelectedIndexChanged += new System.EventHandler(this.lbxClass_SelectedIndexChanged);
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Font = new System.Drawing.Font("MS Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaam.Location = new System.Drawing.Point(358, 168);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(117, 37);
            this.lblNaam.TabIndex = 2;
            this.lblNaam.Text = "Naam:";
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(286, 237);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(278, 22);
            this.txtNaam.TabIndex = 3;
            // 
            // lblStoelnummer
            // 
            this.lblStoelnummer.AutoSize = true;
            this.lblStoelnummer.Font = new System.Drawing.Font("MS Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoelnummer.Location = new System.Drawing.Point(443, 727);
            this.lblStoelnummer.Name = "lblStoelnummer";
            this.lblStoelnummer.Size = new System.Drawing.Size(257, 37);
            this.lblStoelnummer.TabIndex = 4;
            this.lblStoelnummer.Text = "Stoelnummer:";
            // 
            // cbxStoelNummer
            // 
            this.cbxStoelNummer.FormattingEnabled = true;
            this.cbxStoelNummer.Location = new System.Drawing.Point(882, 740);
            this.cbxStoelNummer.Name = "cbxStoelNummer";
            this.cbxStoelNummer.Size = new System.Drawing.Size(283, 24);
            this.cbxStoelNummer.TabIndex = 5;
            // 
            // btnAfsluiten
            // 
            this.btnAfsluiten.BackColor = System.Drawing.Color.LightGray;
            this.btnAfsluiten.BorderColor = System.Drawing.Color.Black;
            this.btnAfsluiten.BorderWidth = 2;
            this.btnAfsluiten.CornerRadius = 20;
            this.btnAfsluiten.DefaultBackColor = System.Drawing.Color.LightGray;
            this.btnAfsluiten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAfsluiten.Font = new System.Drawing.Font("MS Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfsluiten.HoverBackColor = System.Drawing.Color.Gray;
            this.btnAfsluiten.Location = new System.Drawing.Point(1530, 875);
            this.btnAfsluiten.Name = "btnAfsluiten";
            this.btnAfsluiten.PressedBackColor = System.Drawing.Color.MistyRose;
            this.btnAfsluiten.Size = new System.Drawing.Size(358, 146);
            this.btnAfsluiten.TabIndex = 8;
            this.btnAfsluiten.Text = "Afsluiten";
            this.btnAfsluiten.UseVisualStyleBackColor = false;
            this.btnAfsluiten.Click += new System.EventHandler(this.btnAfsluiten_Click);
            // 
            // btnVrijgeven
            // 
            this.btnVrijgeven.BackColor = System.Drawing.Color.LightGray;
            this.btnVrijgeven.BorderColor = System.Drawing.Color.Black;
            this.btnVrijgeven.BorderWidth = 2;
            this.btnVrijgeven.CornerRadius = 20;
            this.btnVrijgeven.DefaultBackColor = System.Drawing.Color.LightGray;
            this.btnVrijgeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVrijgeven.Font = new System.Drawing.Font("MS Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVrijgeven.HoverBackColor = System.Drawing.Color.Gray;
            this.btnVrijgeven.Location = new System.Drawing.Point(807, 875);
            this.btnVrijgeven.Name = "btnVrijgeven";
            this.btnVrijgeven.PressedBackColor = System.Drawing.Color.DarkGray;
            this.btnVrijgeven.Size = new System.Drawing.Size(358, 146);
            this.btnVrijgeven.TabIndex = 7;
            this.btnVrijgeven.Text = "Stoel Vrijgeven";
            this.btnVrijgeven.UseVisualStyleBackColor = true;
            this.btnVrijgeven.Click += new System.EventHandler(this.btnVrijgeven_Click);
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.BackColor = System.Drawing.Color.LightGray;
            this.btnToevoegen.BorderColor = System.Drawing.Color.Black;
            this.btnToevoegen.BorderWidth = 2;
            this.btnToevoegen.CornerRadius = 20;
            this.btnToevoegen.DefaultBackColor = System.Drawing.Color.LightGray;
            this.btnToevoegen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToevoegen.Font = new System.Drawing.Font("MS Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToevoegen.HoverBackColor = System.Drawing.Color.Gray;
            this.btnToevoegen.Location = new System.Drawing.Point(57, 875);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.PressedBackColor = System.Drawing.Color.DarkGray;
            this.btnToevoegen.Size = new System.Drawing.Size(358, 146);
            this.btnToevoegen.TabIndex = 6;
            this.btnToevoegen.Text = "Stoel Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // lblBluebird
            // 
            this.lblBluebird.AutoSize = true;
            this.lblBluebird.Font = new System.Drawing.Font("Old English Text MT", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBluebird.Location = new System.Drawing.Point(603, 9);
            this.lblBluebird.Name = "lblBluebird";
            this.lblBluebird.Size = new System.Drawing.Size(623, 95);
            this.lblBluebird.TabIndex = 9;
            this.lblBluebird.Text = "Bluebird Airlines";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1922, 1033);
            this.Controls.Add(this.lblBluebird);
            this.Controls.Add(this.btnAfsluiten);
            this.Controls.Add(this.btnVrijgeven);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.cbxStoelNummer);
            this.Controls.Add(this.lblStoelnummer);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.lbxClass);
            this.Controls.Add(this.gbClass);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbClass.ResumeLayout(false);
            this.gbClass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbClass;
        private System.Windows.Forms.ListBox lbxClass;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.RadioButton rdbEconomy;
        private System.Windows.Forms.RadioButton rdbBusiness;
        private System.Windows.Forms.RadioButton rdbFirst;
        private System.Windows.Forms.Label lblStoelnummer;
        private System.Windows.Forms.ComboBox cbxStoelNummer;
        private RoundedButton btnToevoegen;
        private RoundedButton btnVrijgeven;
        private RoundedButton btnAfsluiten;
        private System.Windows.Forms.RadioButton rdbAlle;
        private System.Windows.Forms.Label lblBluebird;
    }
}

