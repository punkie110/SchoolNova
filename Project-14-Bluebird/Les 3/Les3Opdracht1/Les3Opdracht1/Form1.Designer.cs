namespace Les3Opdracht1
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
            this.lbxOverzicht = new System.Windows.Forms.ListBox();
            this.btnAlle = new System.Windows.Forms.Button();
            this.btnBeschikbaar = new System.Windows.Forms.Button();
            this.btnGereserveerd = new System.Windows.Forms.Button();
            this.lblTotaal = new System.Windows.Forms.Label();
            this.txtTotaleKluizen = new System.Windows.Forms.TextBox();
            this.btnInvoer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxOverzicht
            // 
            this.lbxOverzicht.FormattingEnabled = true;
            this.lbxOverzicht.ItemHeight = 16;
            this.lbxOverzicht.Location = new System.Drawing.Point(12, 12);
            this.lbxOverzicht.Name = "lbxOverzicht";
            this.lbxOverzicht.Size = new System.Drawing.Size(507, 260);
            this.lbxOverzicht.TabIndex = 0;
            // 
            // btnAlle
            // 
            this.btnAlle.Location = new System.Drawing.Point(557, 21);
            this.btnAlle.Name = "btnAlle";
            this.btnAlle.Size = new System.Drawing.Size(218, 50);
            this.btnAlle.TabIndex = 1;
            this.btnAlle.Text = "Alle Kluizen";
            this.btnAlle.UseVisualStyleBackColor = true;
            this.btnAlle.Click += new System.EventHandler(this.btnAlle_Click);
            // 
            // btnBeschikbaar
            // 
            this.btnBeschikbaar.Location = new System.Drawing.Point(557, 108);
            this.btnBeschikbaar.Name = "btnBeschikbaar";
            this.btnBeschikbaar.Size = new System.Drawing.Size(218, 50);
            this.btnBeschikbaar.TabIndex = 2;
            this.btnBeschikbaar.Text = "Beschikbare kluizen";
            this.btnBeschikbaar.UseVisualStyleBackColor = true;
            this.btnBeschikbaar.Click += new System.EventHandler(this.btnBeschikbaar_Click);
            // 
            // btnGereserveerd
            // 
            this.btnGereserveerd.Location = new System.Drawing.Point(557, 194);
            this.btnGereserveerd.Name = "btnGereserveerd";
            this.btnGereserveerd.Size = new System.Drawing.Size(218, 50);
            this.btnGereserveerd.TabIndex = 3;
            this.btnGereserveerd.Text = "Gereserveerde Kluizen";
            this.btnGereserveerd.UseVisualStyleBackColor = true;
            this.btnGereserveerd.Click += new System.EventHandler(this.btnGereserveerd_Click);
            // 
            // lblTotaal
            // 
            this.lblTotaal.AutoSize = true;
            this.lblTotaal.Location = new System.Drawing.Point(61, 290);
            this.lblTotaal.Name = "lblTotaal";
            this.lblTotaal.Size = new System.Drawing.Size(134, 16);
            this.lblTotaal.TabIndex = 4;
            this.lblTotaal.Text = "Totaal Aantal kluizen:";
            // 
            // txtTotaleKluizen
            // 
            this.txtTotaleKluizen.Location = new System.Drawing.Point(229, 287);
            this.txtTotaleKluizen.Name = "txtTotaleKluizen";
            this.txtTotaleKluizen.Size = new System.Drawing.Size(160, 22);
            this.txtTotaleKluizen.TabIndex = 5;
            // 
            // btnInvoer
            // 
            this.btnInvoer.Location = new System.Drawing.Point(42, 353);
            this.btnInvoer.Name = "btnInvoer";
            this.btnInvoer.Size = new System.Drawing.Size(239, 55);
            this.btnInvoer.TabIndex = 6;
            this.btnInvoer.Text = "Invoer Studenten";
            this.btnInvoer.UseVisualStyleBackColor = true;
            this.btnInvoer.Click += new System.EventHandler(this.btnInvoer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInvoer);
            this.Controls.Add(this.txtTotaleKluizen);
            this.Controls.Add(this.lblTotaal);
            this.Controls.Add(this.btnGereserveerd);
            this.Controls.Add(this.btnBeschikbaar);
            this.Controls.Add(this.btnAlle);
            this.Controls.Add(this.lbxOverzicht);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxOverzicht;
        private System.Windows.Forms.Button btnAlle;
        private System.Windows.Forms.Button btnBeschikbaar;
        private System.Windows.Forms.Button btnGereserveerd;
        private System.Windows.Forms.Label lblTotaal;
        private System.Windows.Forms.TextBox txtTotaleKluizen;
        private System.Windows.Forms.Button btnInvoer;
    }
}

