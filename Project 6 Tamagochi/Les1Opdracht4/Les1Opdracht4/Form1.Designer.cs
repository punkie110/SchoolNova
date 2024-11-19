namespace Les1Opdracht4
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
            this.lblBrutoLoon = new System.Windows.Forms.Label();
            this.lblArtikelen = new System.Windows.Forms.Label();
            this.lblLoon = new System.Windows.Forms.Label();
            this.btnBereken = new System.Windows.Forms.Button();
            this.txtBrutoLoon = new System.Windows.Forms.TextBox();
            this.txtLoon = new System.Windows.Forms.TextBox();
            this.txtVerkochteArtikelen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblBrutoLoon
            // 
            this.lblBrutoLoon.AutoSize = true;
            this.lblBrutoLoon.Location = new System.Drawing.Point(173, 102);
            this.lblBrutoLoon.Name = "lblBrutoLoon";
            this.lblBrutoLoon.Size = new System.Drawing.Size(102, 16);
            this.lblBrutoLoon.TabIndex = 0;
            this.lblBrutoLoon.Text = "Geef Bruto loon:";
            // 
            // lblArtikelen
            // 
            this.lblArtikelen.AutoSize = true;
            this.lblArtikelen.Location = new System.Drawing.Point(80, 149);
            this.lblArtikelen.Name = "lblArtikelen";
            this.lblArtikelen.Size = new System.Drawing.Size(195, 16);
            this.lblArtikelen.TabIndex = 1;
            this.lblArtikelen.Text = "Geef aantal verkochte artikelen:";
            // 
            // lblLoon
            // 
            this.lblLoon.AutoSize = true;
            this.lblLoon.Location = new System.Drawing.Point(207, 266);
            this.lblLoon.Name = "lblLoon";
            this.lblLoon.Size = new System.Drawing.Size(68, 16);
            this.lblLoon.TabIndex = 2;
            this.lblLoon.Text = "Geef loon:";
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(357, 210);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(147, 23);
            this.btnBereken.TabIndex = 3;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // txtBrutoLoon
            // 
            this.txtBrutoLoon.Location = new System.Drawing.Point(357, 99);
            this.txtBrutoLoon.Name = "txtBrutoLoon";
            this.txtBrutoLoon.Size = new System.Drawing.Size(147, 22);
            this.txtBrutoLoon.TabIndex = 4;
            // 
            // txtLoon
            // 
            this.txtLoon.Location = new System.Drawing.Point(357, 260);
            this.txtLoon.Name = "txtLoon";
            this.txtLoon.ReadOnly = true;
            this.txtLoon.Size = new System.Drawing.Size(147, 22);
            this.txtLoon.TabIndex = 5;
            // 
            // txtVerkochteArtikelen
            // 
            this.txtVerkochteArtikelen.Location = new System.Drawing.Point(357, 146);
            this.txtVerkochteArtikelen.Name = "txtVerkochteArtikelen";
            this.txtVerkochteArtikelen.Size = new System.Drawing.Size(147, 22);
            this.txtVerkochteArtikelen.TabIndex = 6;
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

        private System.Windows.Forms.Label lblBrutoLoon;
        private System.Windows.Forms.Label lblArtikelen;
        private System.Windows.Forms.Label lblLoon;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.TextBox txtBrutoLoon;
        private System.Windows.Forms.TextBox txtLoon;
        private System.Windows.Forms.TextBox txtVerkochteArtikelen;
    }
}

