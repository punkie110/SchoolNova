namespace Les2Opdracht2._2
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
            this.txtVerkochteArtikelen = new System.Windows.Forms.TextBox();
            this.txtLoon = new System.Windows.Forms.TextBox();
            this.txtBrutoLoon = new System.Windows.Forms.TextBox();
            this.btnBereken = new System.Windows.Forms.Button();
            this.lblLoon = new System.Windows.Forms.Label();
            this.lblArtikelen = new System.Windows.Forms.Label();
            this.lblBrutoLoon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtVerkochteArtikelen
            // 
            this.txtVerkochteArtikelen.Location = new System.Drawing.Point(465, 181);
            this.txtVerkochteArtikelen.Name = "txtVerkochteArtikelen";
            this.txtVerkochteArtikelen.Size = new System.Drawing.Size(147, 22);
            this.txtVerkochteArtikelen.TabIndex = 20;
            this.txtVerkochteArtikelen.TextChanged += new System.EventHandler(this.txtVerkochteArtikelen_TextChanged);
            // 
            // txtLoon
            // 
            this.txtLoon.Location = new System.Drawing.Point(465, 295);
            this.txtLoon.Name = "txtLoon";
            this.txtLoon.ReadOnly = true;
            this.txtLoon.Size = new System.Drawing.Size(147, 22);
            this.txtLoon.TabIndex = 19;
            this.txtLoon.TextChanged += new System.EventHandler(this.txtLoon_TextChanged);
            // 
            // txtBrutoLoon
            // 
            this.txtBrutoLoon.Location = new System.Drawing.Point(465, 134);
            this.txtBrutoLoon.Name = "txtBrutoLoon";
            this.txtBrutoLoon.Size = new System.Drawing.Size(147, 22);
            this.txtBrutoLoon.TabIndex = 18;
            this.txtBrutoLoon.TextChanged += new System.EventHandler(this.txtBrutoLoon_TextChanged);
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(465, 245);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(147, 23);
            this.btnBereken.TabIndex = 17;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // lblLoon
            // 
            this.lblLoon.AutoSize = true;
            this.lblLoon.Location = new System.Drawing.Point(315, 301);
            this.lblLoon.Name = "lblLoon";
            this.lblLoon.Size = new System.Drawing.Size(68, 16);
            this.lblLoon.TabIndex = 16;
            this.lblLoon.Text = "Geef loon:";
            this.lblLoon.Click += new System.EventHandler(this.lblLoon_Click);
            // 
            // lblArtikelen
            // 
            this.lblArtikelen.AutoSize = true;
            this.lblArtikelen.Location = new System.Drawing.Point(188, 184);
            this.lblArtikelen.Name = "lblArtikelen";
            this.lblArtikelen.Size = new System.Drawing.Size(195, 16);
            this.lblArtikelen.TabIndex = 15;
            this.lblArtikelen.Text = "Geef aantal verkochte artikelen:";
            this.lblArtikelen.Click += new System.EventHandler(this.lblArtikelen_Click);
            // 
            // lblBrutoLoon
            // 
            this.lblBrutoLoon.AutoSize = true;
            this.lblBrutoLoon.Location = new System.Drawing.Point(281, 137);
            this.lblBrutoLoon.Name = "lblBrutoLoon";
            this.lblBrutoLoon.Size = new System.Drawing.Size(102, 16);
            this.lblBrutoLoon.TabIndex = 14;
            this.lblBrutoLoon.Text = "Geef Bruto loon:";
            this.lblBrutoLoon.Click += new System.EventHandler(this.lblBrutoLoon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtVerkochteArtikelen);
            this.Controls.Add(this.txtLoon);
            this.Controls.Add(this.txtBrutoLoon);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.lblLoon);
            this.Controls.Add(this.lblArtikelen);
            this.Controls.Add(this.lblBrutoLoon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVerkochteArtikelen;
        private System.Windows.Forms.TextBox txtLoon;
        private System.Windows.Forms.TextBox txtBrutoLoon;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.Label lblLoon;
        private System.Windows.Forms.Label lblArtikelen;
        private System.Windows.Forms.Label lblBrutoLoon;
    }
}

