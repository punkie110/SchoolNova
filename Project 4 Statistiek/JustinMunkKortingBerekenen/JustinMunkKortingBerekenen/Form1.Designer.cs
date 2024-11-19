namespace JustinMunkKortingBerekenen
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
            this.lblKortingBerekenen = new System.Windows.Forms.Label();
            this.lblBedrag = new System.Windows.Forms.Label();
            this.lblKorting = new System.Windows.Forms.Label();
            this.txtBedrag = new System.Windows.Forms.TextBox();
            this.txtPercentage = new System.Windows.Forms.TextBox();
            this.lblNieuwBedrag = new System.Windows.Forms.Label();
            this.txtNieuwBedrag = new System.Windows.Forms.TextBox();
            this.btnBereken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKortingBerekenen
            // 
            this.lblKortingBerekenen.AutoSize = true;
            this.lblKortingBerekenen.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKortingBerekenen.ForeColor = System.Drawing.Color.Red;
            this.lblKortingBerekenen.Location = new System.Drawing.Point(12, 43);
            this.lblKortingBerekenen.Name = "lblKortingBerekenen";
            this.lblKortingBerekenen.Size = new System.Drawing.Size(304, 38);
            this.lblKortingBerekenen.TabIndex = 0;
            this.lblKortingBerekenen.Text = "Korting Berekenen";
            // 
            // lblBedrag
            // 
            this.lblBedrag.AutoSize = true;
            this.lblBedrag.Location = new System.Drawing.Point(12, 132);
            this.lblBedrag.Name = "lblBedrag";
            this.lblBedrag.Size = new System.Drawing.Size(120, 16);
            this.lblBedrag.TabIndex = 1;
            this.lblBedrag.Text = "Voer het bedrag in:";
            // 
            // lblKorting
            // 
            this.lblKorting.AutoSize = true;
            this.lblKorting.Location = new System.Drawing.Point(12, 181);
            this.lblKorting.Name = "lblKorting";
            this.lblKorting.Size = new System.Drawing.Size(194, 16);
            this.lblKorting.TabIndex = 2;
            this.lblKorting.Text = "Voer de korting in (percentage):";
            // 
            // txtBedrag
            // 
            this.txtBedrag.Location = new System.Drawing.Point(252, 126);
            this.txtBedrag.Name = "txtBedrag";
            this.txtBedrag.Size = new System.Drawing.Size(145, 22);
            this.txtBedrag.TabIndex = 3;
            // 
            // txtPercentage
            // 
            this.txtPercentage.Location = new System.Drawing.Point(252, 181);
            this.txtPercentage.Name = "txtPercentage";
            this.txtPercentage.Size = new System.Drawing.Size(145, 22);
            this.txtPercentage.TabIndex = 4;
            // 
            // lblNieuwBedrag
            // 
            this.lblNieuwBedrag.AutoSize = true;
            this.lblNieuwBedrag.Location = new System.Drawing.Point(35, 297);
            this.lblNieuwBedrag.Name = "lblNieuwBedrag";
            this.lblNieuwBedrag.Size = new System.Drawing.Size(123, 16);
            this.lblNieuwBedrag.TabIndex = 5;
            this.lblNieuwBedrag.Text = "Het nieuwe bedrag:";
            // 
            // txtNieuwBedrag
            // 
            this.txtNieuwBedrag.Location = new System.Drawing.Point(252, 294);
            this.txtNieuwBedrag.Name = "txtNieuwBedrag";
            this.txtNieuwBedrag.Size = new System.Drawing.Size(145, 22);
            this.txtNieuwBedrag.TabIndex = 6;
            // 
            // btnBereken
            // 
            this.btnBereken.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnBereken.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBereken.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBereken.ForeColor = System.Drawing.Color.Black;
            this.btnBereken.Location = new System.Drawing.Point(252, 234);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(155, 37);
            this.btnBereken.TabIndex = 7;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = false;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(489, 450);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.txtNieuwBedrag);
            this.Controls.Add(this.lblNieuwBedrag);
            this.Controls.Add(this.txtPercentage);
            this.Controls.Add(this.txtBedrag);
            this.Controls.Add(this.lblKorting);
            this.Controls.Add(this.lblBedrag);
            this.Controls.Add(this.lblKortingBerekenen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKortingBerekenen;
        private System.Windows.Forms.Label lblBedrag;
        private System.Windows.Forms.Label lblKorting;
        private System.Windows.Forms.TextBox txtBedrag;
        private System.Windows.Forms.TextBox txtPercentage;
        private System.Windows.Forms.Label lblNieuwBedrag;
        private System.Windows.Forms.TextBox txtNieuwBedrag;
        private System.Windows.Forms.Button btnBereken;
    }
}

