﻿namespace _15_1_FirmaBruinsma
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTelefoon = new System.Windows.Forms.TextBox();
            this.txtWoonplaats = new System.Windows.Forms.TextBox();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.txtTHuisnummer = new System.Windows.Forms.TextBox();
            this.txtHuisnummer = new System.Windows.Forms.TextBox();
            this.txtStraat = new System.Windows.Forms.TextBox();
            this.txtAchternaam = new System.Windows.Forms.TextBox();
            this.txtVoorvoegsel = new System.Windows.Forms.TextBox();
            this.txtVoorletters = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Voorletters";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTelefoon);
            this.groupBox1.Controls.Add(this.txtWoonplaats);
            this.groupBox1.Controls.Add(this.txtPostcode);
            this.groupBox1.Controls.Add(this.txtTHuisnummer);
            this.groupBox1.Controls.Add(this.txtHuisnummer);
            this.groupBox1.Controls.Add(this.txtStraat);
            this.groupBox1.Controls.Add(this.txtAchternaam);
            this.groupBox1.Controls.Add(this.txtVoorvoegsel);
            this.groupBox1.Controls.Add(this.txtVoorletters);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
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
            // txtTelefoon
            // 
            this.txtTelefoon.Location = new System.Drawing.Point(211, 246);
            this.txtTelefoon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTelefoon.Name = "txtTelefoon";
            this.txtTelefoon.Size = new System.Drawing.Size(135, 22);
            this.txtTelefoon.TabIndex = 18;
            this.txtTelefoon.TextChanged += new System.EventHandler(this.txtTelefoon_TextChanged);
            // 
            // txtWoonplaats
            // 
            this.txtWoonplaats.Location = new System.Drawing.Point(211, 218);
            this.txtWoonplaats.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtWoonplaats.Name = "txtWoonplaats";
            this.txtWoonplaats.Size = new System.Drawing.Size(135, 22);
            this.txtWoonplaats.TabIndex = 17;
            this.txtWoonplaats.TextChanged += new System.EventHandler(this.txtWoonplaats_TextChanged);
            // 
            // txtPostcode
            // 
            this.txtPostcode.Location = new System.Drawing.Point(211, 191);
            this.txtPostcode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(135, 22);
            this.txtPostcode.TabIndex = 16;
            this.txtPostcode.TextChanged += new System.EventHandler(this.txtPostcode_TextChanged);
            // 
            // txtTHuisnummer
            // 
            this.txtTHuisnummer.Location = new System.Drawing.Point(211, 164);
            this.txtTHuisnummer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTHuisnummer.Name = "txtTHuisnummer";
            this.txtTHuisnummer.Size = new System.Drawing.Size(135, 22);
            this.txtTHuisnummer.TabIndex = 15;
            this.txtTHuisnummer.TextChanged += new System.EventHandler(this.txtTHuisnummer_TextChanged);
            // 
            // txtHuisnummer
            // 
            this.txtHuisnummer.Location = new System.Drawing.Point(211, 137);
            this.txtHuisnummer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHuisnummer.Name = "txtHuisnummer";
            this.txtHuisnummer.Size = new System.Drawing.Size(135, 22);
            this.txtHuisnummer.TabIndex = 14;
            this.txtHuisnummer.TextChanged += new System.EventHandler(this.txtHuisnummer_TextChanged);
            // 
            // txtStraat
            // 
            this.txtStraat.Location = new System.Drawing.Point(211, 110);
            this.txtStraat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStraat.Name = "txtStraat";
            this.txtStraat.Size = new System.Drawing.Size(135, 22);
            this.txtStraat.TabIndex = 13;
            this.txtStraat.TextChanged += new System.EventHandler(this.txtStraat_TextChanged);
            // 
            // txtAchternaam
            // 
            this.txtAchternaam.Location = new System.Drawing.Point(211, 83);
            this.txtAchternaam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAchternaam.Name = "txtAchternaam";
            this.txtAchternaam.Size = new System.Drawing.Size(135, 22);
            this.txtAchternaam.TabIndex = 12;
            this.txtAchternaam.TextChanged += new System.EventHandler(this.txtAchternaam_TextChanged);
            // 
            // txtVoorvoegsel
            // 
            this.txtVoorvoegsel.Location = new System.Drawing.Point(211, 58);
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 246);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Telefoonnummer";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 218);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Woonplaats";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 164);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Toevoeging huisnummer";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 191);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Postcode";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Huisnummer";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Straat";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Achternaam";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tussenvoegsel";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.Load += new System.EventHandler(this.FrmKlantInvoer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInvoeren;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTelefoon;
        private System.Windows.Forms.TextBox txtWoonplaats;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.TextBox txtTHuisnummer;
        private System.Windows.Forms.TextBox txtHuisnummer;
        private System.Windows.Forms.TextBox txtStraat;
        private System.Windows.Forms.TextBox txtAchternaam;
        private System.Windows.Forms.TextBox txtVoorvoegsel;
        private System.Windows.Forms.TextBox txtVoorletters;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}