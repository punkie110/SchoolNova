namespace _15_1_FirmaBruinsma
{
    partial class FrmKlantInvoer
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
            this.btnInvoeren = new System.Windows.Forms.Button();
            this.lblreceptNaam = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTHuisnummer = new System.Windows.Forms.TextBox();
            this.txtHuisnummer = new System.Windows.Forms.TextBox();
            this.txtStraat = new System.Windows.Forms.TextBox();
            this.txtAchternaam = new System.Windows.Forms.TextBox();
            this.txtVoorvoegsel = new System.Windows.Forms.TextBox();
            this.txtVoorletters = new System.Windows.Forms.TextBox();
            this.lblBereiding = new System.Windows.Forms.Label();
            this.lblingredienten = new System.Windows.Forms.Label();
            this.lblPersonen = new System.Windows.Forms.Label();
            this.lblBereidingstijd = new System.Windows.Forms.Label();
            this.lblcategorieId = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInvoeren
            // 
            this.btnInvoeren.Location = new System.Drawing.Point(323, 320);
            this.btnInvoeren.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInvoeren.Name = "btnInvoeren";
            this.btnInvoeren.Size = new System.Drawing.Size(98, 28);
            this.btnInvoeren.TabIndex = 0;
            this.btnInvoeren.Text = "Invoeren";
            this.btnInvoeren.UseVisualStyleBackColor = true;
            this.btnInvoeren.Click += new System.EventHandler(this.btnInvoeren_Click);
            // 
            // lblreceptNaam
            // 
            this.lblreceptNaam.AutoSize = true;
            this.lblreceptNaam.Location = new System.Drawing.Point(17, 33);
            this.lblreceptNaam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblreceptNaam.Name = "lblreceptNaam";
            this.lblreceptNaam.Size = new System.Drawing.Size(88, 16);
            this.lblreceptNaam.TabIndex = 1;
            this.lblreceptNaam.Text = "Recept naam";
            this.lblreceptNaam.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTHuisnummer);
            this.groupBox1.Controls.Add(this.txtHuisnummer);
            this.groupBox1.Controls.Add(this.txtStraat);
            this.groupBox1.Controls.Add(this.txtAchternaam);
            this.groupBox1.Controls.Add(this.txtVoorvoegsel);
            this.groupBox1.Controls.Add(this.txtVoorletters);
            this.groupBox1.Controls.Add(this.lblBereiding);
            this.groupBox1.Controls.Add(this.lblingredienten);
            this.groupBox1.Controls.Add(this.lblPersonen);
            this.groupBox1.Controls.Add(this.lblBereidingstijd);
            this.groupBox1.Controls.Add(this.lblcategorieId);
            this.groupBox1.Controls.Add(this.lblreceptNaam);
            this.groupBox1.Location = new System.Drawing.Point(54, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(367, 291);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invoeren";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtTHuisnummer
            // 
            this.txtTHuisnummer.Location = new System.Drawing.Point(211, 233);
            this.txtTHuisnummer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTHuisnummer.Name = "txtTHuisnummer";
            this.txtTHuisnummer.Size = new System.Drawing.Size(135, 22);
            this.txtTHuisnummer.TabIndex = 15;
            this.txtTHuisnummer.TextChanged += new System.EventHandler(this.txtTHuisnummer_TextChanged);
            // 
            // txtHuisnummer
            // 
            this.txtHuisnummer.Location = new System.Drawing.Point(211, 194);
            this.txtHuisnummer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHuisnummer.Name = "txtHuisnummer";
            this.txtHuisnummer.Size = new System.Drawing.Size(135, 22);
            this.txtHuisnummer.TabIndex = 14;
            this.txtHuisnummer.TextChanged += new System.EventHandler(this.txtHuisnummer_TextChanged);
            // 
            // txtStraat
            // 
            this.txtStraat.Location = new System.Drawing.Point(211, 149);
            this.txtStraat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStraat.Name = "txtStraat";
            this.txtStraat.Size = new System.Drawing.Size(135, 22);
            this.txtStraat.TabIndex = 13;
            this.txtStraat.TextChanged += new System.EventHandler(this.txtStraat_TextChanged);
            // 
            // txtAchternaam
            // 
            this.txtAchternaam.Location = new System.Drawing.Point(211, 104);
            this.txtAchternaam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAchternaam.Name = "txtAchternaam";
            this.txtAchternaam.Size = new System.Drawing.Size(135, 22);
            this.txtAchternaam.TabIndex = 12;
            this.txtAchternaam.TextChanged += new System.EventHandler(this.txtAchternaam_TextChanged);
            // 
            // txtVoorvoegsel
            // 
            this.txtVoorvoegsel.Location = new System.Drawing.Point(211, 68);
            this.txtVoorvoegsel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtVoorvoegsel.Name = "txtVoorvoegsel";
            this.txtVoorvoegsel.Size = new System.Drawing.Size(135, 22);
            this.txtVoorvoegsel.TabIndex = 11;
            this.txtVoorvoegsel.TextChanged += new System.EventHandler(this.txtVoorvoegsel_TextChanged);
            // 
            // txtVoorletters
            // 
            this.txtVoorletters.Location = new System.Drawing.Point(211, 33);
            this.txtVoorletters.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtVoorletters.Name = "txtVoorletters";
            this.txtVoorletters.Size = new System.Drawing.Size(135, 22);
            this.txtVoorletters.TabIndex = 10;
            this.txtVoorletters.TextChanged += new System.EventHandler(this.txtVoorletters_TextChanged);
            // 
            // lblBereiding
            // 
            this.lblBereiding.AutoSize = true;
            this.lblBereiding.Location = new System.Drawing.Point(17, 233);
            this.lblBereiding.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBereiding.Name = "lblBereiding";
            this.lblBereiding.Size = new System.Drawing.Size(68, 16);
            this.lblBereiding.TabIndex = 7;
            this.lblBereiding.Text = "Bereiding:";
            this.lblBereiding.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblingredienten
            // 
            this.lblingredienten.AutoSize = true;
            this.lblingredienten.Location = new System.Drawing.Point(23, 200);
            this.lblingredienten.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblingredienten.Name = "lblingredienten";
            this.lblingredienten.Size = new System.Drawing.Size(81, 16);
            this.lblingredienten.TabIndex = 5;
            this.lblingredienten.Text = "Ingredienten";
            this.lblingredienten.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblPersonen
            // 
            this.lblPersonen.AutoSize = true;
            this.lblPersonen.Location = new System.Drawing.Point(23, 155);
            this.lblPersonen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPersonen.Name = "lblPersonen";
            this.lblPersonen.Size = new System.Drawing.Size(104, 16);
            this.lblPersonen.TabIndex = 4;
            this.lblPersonen.Text = "aantal personen";
            this.lblPersonen.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblBereidingstijd
            // 
            this.lblBereidingstijd.AutoSize = true;
            this.lblBereidingstijd.Location = new System.Drawing.Point(17, 110);
            this.lblBereidingstijd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBereidingstijd.Name = "lblBereidingstijd";
            this.lblBereidingstijd.Size = new System.Drawing.Size(89, 16);
            this.lblBereidingstijd.TabIndex = 3;
            this.lblBereidingstijd.Text = "Bereidingstijd";
            this.lblBereidingstijd.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblcategorieId
            // 
            this.lblcategorieId.AutoSize = true;
            this.lblcategorieId.Location = new System.Drawing.Point(17, 74);
            this.lblcategorieId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcategorieId.Name = "lblcategorieId";
            this.lblcategorieId.Size = new System.Drawing.Size(83, 16);
            this.lblcategorieId.TabIndex = 2;
            this.lblcategorieId.Text = "Categorie-ID";
            this.lblcategorieId.Click += new System.EventHandler(this.label2_Click);
            // 
            // FrmKlantInvoer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 381);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnInvoeren);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmKlantInvoer";
            this.Text = "Invoer klanten";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInvoeren;
        private System.Windows.Forms.Label lblreceptNaam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTHuisnummer;
        private System.Windows.Forms.TextBox txtHuisnummer;
        private System.Windows.Forms.TextBox txtStraat;
        private System.Windows.Forms.TextBox txtAchternaam;
        private System.Windows.Forms.TextBox txtVoorvoegsel;
        private System.Windows.Forms.TextBox txtVoorletters;
        private System.Windows.Forms.Label lblBereiding;
        private System.Windows.Forms.Label lblingredienten;
        private System.Windows.Forms.Label lblPersonen;
        private System.Windows.Forms.Label lblBereidingstijd;
        private System.Windows.Forms.Label lblcategorieId;
    }
}