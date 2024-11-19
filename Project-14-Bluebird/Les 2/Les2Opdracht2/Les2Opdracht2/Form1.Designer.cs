namespace Les2Opdracht2
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
            this.btnInvoer = new System.Windows.Forms.Button();
            this.txtAantal = new System.Windows.Forms.TextBox();
            this.lblAantalStudenten = new System.Windows.Forms.Label();
            this.lbxOverzicht = new System.Windows.Forms.ListBox();
            this.btnOverzicht = new System.Windows.Forms.Button();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.rdbA01 = new System.Windows.Forms.RadioButton();
            this.rdbA02 = new System.Windows.Forms.RadioButton();
            this.rdbA03 = new System.Windows.Forms.RadioButton();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInvoer
            // 
            this.btnInvoer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoer.Location = new System.Drawing.Point(286, 374);
            this.btnInvoer.Name = "btnInvoer";
            this.btnInvoer.Size = new System.Drawing.Size(208, 46);
            this.btnInvoer.TabIndex = 18;
            this.btnInvoer.Text = "Invoeren";
            this.btnInvoer.UseVisualStyleBackColor = true;
            this.btnInvoer.Click += new System.EventHandler(this.btnInvoer_Click);
            // 
            // txtAantal
            // 
            this.txtAantal.Location = new System.Drawing.Point(142, 317);
            this.txtAantal.Name = "txtAantal";
            this.txtAantal.ReadOnly = true;
            this.txtAantal.Size = new System.Drawing.Size(361, 22);
            this.txtAantal.TabIndex = 17;
            // 
            // lblAantalStudenten
            // 
            this.lblAantalStudenten.AutoSize = true;
            this.lblAantalStudenten.Location = new System.Drawing.Point(22, 320);
            this.lblAantalStudenten.Name = "lblAantalStudenten";
            this.lblAantalStudenten.Size = new System.Drawing.Size(111, 16);
            this.lblAantalStudenten.TabIndex = 16;
            this.lblAantalStudenten.Text = "Aantal Studenten:";
            // 
            // lbxOverzicht
            // 
            this.lbxOverzicht.FormattingEnabled = true;
            this.lbxOverzicht.ItemHeight = 16;
            this.lbxOverzicht.Location = new System.Drawing.Point(12, 89);
            this.lbxOverzicht.Name = "lbxOverzicht";
            this.lbxOverzicht.Size = new System.Drawing.Size(534, 212);
            this.lbxOverzicht.TabIndex = 15;
            // 
            // btnOverzicht
            // 
            this.btnOverzicht.Location = new System.Drawing.Point(25, 374);
            this.btnOverzicht.Name = "btnOverzicht";
            this.btnOverzicht.Size = new System.Drawing.Size(214, 46);
            this.btnOverzicht.TabIndex = 14;
            this.btnOverzicht.Text = "Overzicht Studenten";
            this.btnOverzicht.UseVisualStyleBackColor = true;
            this.btnOverzicht.Click += new System.EventHandler(this.btnOverzicht_Click);
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.rdbA03);
            this.gbFilter.Controls.Add(this.rdbA02);
            this.gbFilter.Controls.Add(this.rdbA01);
            this.gbFilter.Location = new System.Drawing.Point(14, 8);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(531, 72);
            this.gbFilter.TabIndex = 19;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filteren";
            // 
            // rdbA01
            // 
            this.rdbA01.AutoSize = true;
            this.rdbA01.Location = new System.Drawing.Point(45, 35);
            this.rdbA01.Name = "rdbA01";
            this.rdbA01.Size = new System.Drawing.Size(91, 20);
            this.rdbA01.TabIndex = 0;
            this.rdbA01.TabStop = true;
            this.rdbA01.Text = "SBICOA01";
            this.rdbA01.UseVisualStyleBackColor = true;
            this.rdbA01.CheckedChanged += new System.EventHandler(this.rdbA01_CheckedChanged);
            // 
            // rdbA02
            // 
            this.rdbA02.AutoSize = true;
            this.rdbA02.Location = new System.Drawing.Point(213, 35);
            this.rdbA02.Name = "rdbA02";
            this.rdbA02.Size = new System.Drawing.Size(91, 20);
            this.rdbA02.TabIndex = 1;
            this.rdbA02.TabStop = true;
            this.rdbA02.Text = "SBICOA02";
            this.rdbA02.UseVisualStyleBackColor = true;
            this.rdbA02.CheckedChanged += new System.EventHandler(this.rdbA02_CheckedChanged);
            // 
            // rdbA03
            // 
            this.rdbA03.AutoSize = true;
            this.rdbA03.Location = new System.Drawing.Point(389, 35);
            this.rdbA03.Name = "rdbA03";
            this.rdbA03.Size = new System.Drawing.Size(91, 20);
            this.rdbA03.TabIndex = 2;
            this.rdbA03.TabStop = true;
            this.rdbA03.Text = "SBICOA03";
            this.rdbA03.UseVisualStyleBackColor = true;
            this.rdbA03.CheckedChanged += new System.EventHandler(this.rdbA03_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 450);
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.btnInvoer);
            this.Controls.Add(this.txtAantal);
            this.Controls.Add(this.lblAantalStudenten);
            this.Controls.Add(this.lbxOverzicht);
            this.Controls.Add(this.btnOverzicht);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInvoer;
        private System.Windows.Forms.TextBox txtAantal;
        private System.Windows.Forms.Label lblAantalStudenten;
        private System.Windows.Forms.ListBox lbxOverzicht;
        private System.Windows.Forms.Button btnOverzicht;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.RadioButton rdbA03;
        private System.Windows.Forms.RadioButton rdbA02;
        private System.Windows.Forms.RadioButton rdbA01;
    }
}

