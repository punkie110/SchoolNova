namespace Les6Opdracht1
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
            this.btnReservering = new System.Windows.Forms.Button();
            this.txtTotaal = new System.Windows.Forms.TextBox();
            this.lblTotaal = new System.Windows.Forms.Label();
            this.lbxOverzicht = new System.Windows.Forms.ListBox();
            this.btnInvoer = new System.Windows.Forms.Button();
            this.btnWijzig = new System.Windows.Forms.Button();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.txtStudentNr = new System.Windows.Forms.TextBox();
            this.txtAchternaam = new System.Windows.Forms.TextBox();
            this.txtVoornaam = new System.Windows.Forms.TextBox();
            this.cbxKluisNr = new System.Windows.Forms.ComboBox();
            this.cbxKlas = new System.Windows.Forms.ComboBox();
            this.lblVoornaam = new System.Windows.Forms.Label();
            this.lblAchternaam = new System.Windows.Forms.Label();
            this.lblKlas = new System.Windows.Forms.Label();
            this.lblKluisNr = new System.Windows.Forms.Label();
            this.lblStudentnummer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReservering
            // 
            this.btnReservering.Location = new System.Drawing.Point(523, 12);
            this.btnReservering.Name = "btnReservering";
            this.btnReservering.Size = new System.Drawing.Size(165, 45);
            this.btnReservering.TabIndex = 9;
            this.btnReservering.Text = "Wel Reservering";
            this.btnReservering.UseVisualStyleBackColor = true;
            this.btnReservering.Click += new System.EventHandler(this.btnReservering_Click);
            // 
            // txtTotaal
            // 
            this.txtTotaal.Location = new System.Drawing.Point(235, 423);
            this.txtTotaal.Name = "txtTotaal";
            this.txtTotaal.Size = new System.Drawing.Size(194, 22);
            this.txtTotaal.TabIndex = 7;
            this.txtTotaal.TextChanged += new System.EventHandler(this.txtTotaal_TextChanged);
            // 
            // lblTotaal
            // 
            this.lblTotaal.AutoSize = true;
            this.lblTotaal.Location = new System.Drawing.Point(53, 423);
            this.lblTotaal.Name = "lblTotaal";
            this.lblTotaal.Size = new System.Drawing.Size(149, 16);
            this.lblTotaal.TabIndex = 6;
            this.lblTotaal.Text = "Totaal aantal Studenten";
            this.lblTotaal.Click += new System.EventHandler(this.lblTotaal_Click);
            // 
            // lbxOverzicht
            // 
            this.lbxOverzicht.FormattingEnabled = true;
            this.lbxOverzicht.ItemHeight = 16;
            this.lbxOverzicht.Location = new System.Drawing.Point(8, 5);
            this.lbxOverzicht.Name = "lbxOverzicht";
            this.lbxOverzicht.Size = new System.Drawing.Size(478, 324);
            this.lbxOverzicht.TabIndex = 5;
            this.lbxOverzicht.SelectedIndexChanged += new System.EventHandler(this.lbxOverzicht_SelectedIndexChanged);
            // 
            // btnInvoer
            // 
            this.btnInvoer.Location = new System.Drawing.Point(523, 63);
            this.btnInvoer.Name = "btnInvoer";
            this.btnInvoer.Size = new System.Drawing.Size(165, 40);
            this.btnInvoer.TabIndex = 10;
            this.btnInvoer.Text = "Invoer Studenten";
            this.btnInvoer.UseVisualStyleBackColor = true;
            this.btnInvoer.Click += new System.EventHandler(this.btnInvoer_Click);
            // 
            // btnWijzig
            // 
            this.btnWijzig.Location = new System.Drawing.Point(493, 269);
            this.btnWijzig.Name = "btnWijzig";
            this.btnWijzig.Size = new System.Drawing.Size(137, 40);
            this.btnWijzig.TabIndex = 11;
            this.btnWijzig.Text = "Wijzig Student";
            this.btnWijzig.UseVisualStyleBackColor = true;
            this.btnWijzig.Click += new System.EventHandler(this.btnWijzig_Click);
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(636, 268);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(152, 41);
            this.btnVerwijder.TabIndex = 12;
            this.btnVerwijder.Text = "Verwijder Student";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // txtStudentNr
            // 
            this.txtStudentNr.Location = new System.Drawing.Point(614, 109);
            this.txtStudentNr.Name = "txtStudentNr";
            this.txtStudentNr.Size = new System.Drawing.Size(174, 22);
            this.txtStudentNr.TabIndex = 13;
            // 
            // txtAchternaam
            // 
            this.txtAchternaam.Location = new System.Drawing.Point(614, 165);
            this.txtAchternaam.Name = "txtAchternaam";
            this.txtAchternaam.Size = new System.Drawing.Size(174, 22);
            this.txtAchternaam.TabIndex = 15;
            // 
            // txtVoornaam
            // 
            this.txtVoornaam.Location = new System.Drawing.Point(614, 137);
            this.txtVoornaam.Name = "txtVoornaam";
            this.txtVoornaam.Size = new System.Drawing.Size(174, 22);
            this.txtVoornaam.TabIndex = 16;
            // 
            // cbxKluisNr
            // 
            this.cbxKluisNr.FormattingEnabled = true;
            this.cbxKluisNr.Location = new System.Drawing.Point(614, 223);
            this.cbxKluisNr.Name = "cbxKluisNr";
            this.cbxKluisNr.Size = new System.Drawing.Size(174, 24);
            this.cbxKluisNr.TabIndex = 17;
            // 
            // cbxKlas
            // 
            this.cbxKlas.FormattingEnabled = true;
            this.cbxKlas.Location = new System.Drawing.Point(614, 193);
            this.cbxKlas.Name = "cbxKlas";
            this.cbxKlas.Size = new System.Drawing.Size(174, 24);
            this.cbxKlas.TabIndex = 18;
            // 
            // lblVoornaam
            // 
            this.lblVoornaam.AutoSize = true;
            this.lblVoornaam.Location = new System.Drawing.Point(519, 140);
            this.lblVoornaam.Name = "lblVoornaam";
            this.lblVoornaam.Size = new System.Drawing.Size(70, 16);
            this.lblVoornaam.TabIndex = 19;
            this.lblVoornaam.Text = "Voornaam";
            // 
            // lblAchternaam
            // 
            this.lblAchternaam.AutoSize = true;
            this.lblAchternaam.Location = new System.Drawing.Point(510, 168);
            this.lblAchternaam.Name = "lblAchternaam";
            this.lblAchternaam.Size = new System.Drawing.Size(79, 16);
            this.lblAchternaam.TabIndex = 20;
            this.lblAchternaam.Text = "Achternaam";
            // 
            // lblKlas
            // 
            this.lblKlas.AutoSize = true;
            this.lblKlas.Location = new System.Drawing.Point(559, 201);
            this.lblKlas.Name = "lblKlas";
            this.lblKlas.Size = new System.Drawing.Size(33, 16);
            this.lblKlas.TabIndex = 21;
            this.lblKlas.Text = "Klas";
            // 
            // lblKluisNr
            // 
            this.lblKluisNr.AutoSize = true;
            this.lblKluisNr.Location = new System.Drawing.Point(503, 226);
            this.lblKluisNr.Name = "lblKluisNr";
            this.lblKluisNr.Size = new System.Drawing.Size(89, 16);
            this.lblKluisNr.TabIndex = 23;
            this.lblKluisNr.Text = "Kluis Nummer";
            // 
            // lblStudentnummer
            // 
            this.lblStudentnummer.AutoSize = true;
            this.lblStudentnummer.Location = new System.Drawing.Point(492, 115);
            this.lblStudentnummer.Name = "lblStudentnummer";
            this.lblStudentnummer.Size = new System.Drawing.Size(100, 16);
            this.lblStudentnummer.TabIndex = 24;
            this.lblStudentnummer.Text = "Studentnummer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStudentnummer);
            this.Controls.Add(this.lblKluisNr);
            this.Controls.Add(this.lblKlas);
            this.Controls.Add(this.lblAchternaam);
            this.Controls.Add(this.lblVoornaam);
            this.Controls.Add(this.cbxKlas);
            this.Controls.Add(this.cbxKluisNr);
            this.Controls.Add(this.txtVoornaam);
            this.Controls.Add(this.txtAchternaam);
            this.Controls.Add(this.txtStudentNr);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.btnWijzig);
            this.Controls.Add(this.btnInvoer);
            this.Controls.Add(this.btnReservering);
            this.Controls.Add(this.txtTotaal);
            this.Controls.Add(this.lblTotaal);
            this.Controls.Add(this.lbxOverzicht);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReservering;
        private System.Windows.Forms.TextBox txtTotaal;
        private System.Windows.Forms.Label lblTotaal;
        private System.Windows.Forms.ListBox lbxOverzicht;
        private System.Windows.Forms.Button btnInvoer;
        private System.Windows.Forms.Button btnWijzig;
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.TextBox txtStudentNr;
        private System.Windows.Forms.TextBox txtAchternaam;
        private System.Windows.Forms.TextBox txtVoornaam;
        private System.Windows.Forms.ComboBox cbxKluisNr;
        private System.Windows.Forms.ComboBox cbxKlas;
        private System.Windows.Forms.Label lblVoornaam;
        private System.Windows.Forms.Label lblAchternaam;
        private System.Windows.Forms.Label lblKlas;
        private System.Windows.Forms.Label lblKluisNr;
        private System.Windows.Forms.Label lblStudentnummer;
    }
}

