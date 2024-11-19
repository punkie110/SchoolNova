namespace Les3Opdracht2
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
            this.lblAantal = new System.Windows.Forms.Label();
            this.txtAantal = new System.Windows.Forms.TextBox();
            this.btnBereken = new System.Windows.Forms.Button();
            this.txtTotaal = new System.Windows.Forms.TextBox();
            this.lblTotaal = new System.Windows.Forms.Label();
            this.pbValue = new Les3Opdracht2.CustomProgressBar();
            this.SuspendLayout();
            // 
            // lblAantal
            // 
            this.lblAantal.AutoSize = true;
            this.lblAantal.Location = new System.Drawing.Point(184, 154);
            this.lblAantal.Name = "lblAantal";
            this.lblAantal.Size = new System.Drawing.Size(132, 16);
            this.lblAantal.TabIndex = 6;
            this.lblAantal.Text = "Aantal kamers bezet:";
            // 
            // txtAantal
            // 
            this.txtAantal.Location = new System.Drawing.Point(412, 147);
            this.txtAantal.Name = "txtAantal";
            this.txtAantal.Size = new System.Drawing.Size(163, 22);
            this.txtAantal.TabIndex = 5;
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(209, 285);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(375, 97);
            this.btnBereken.TabIndex = 4;
            this.btnBereken.Text = "bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // txtTotaal
            // 
            this.txtTotaal.Location = new System.Drawing.Point(412, 229);
            this.txtTotaal.Name = "txtTotaal";
            this.txtTotaal.Size = new System.Drawing.Size(163, 22);
            this.txtTotaal.TabIndex = 8;
            // 
            // lblTotaal
            // 
            this.lblTotaal.AutoSize = true;
            this.lblTotaal.Location = new System.Drawing.Point(184, 232);
            this.lblTotaal.Name = "lblTotaal";
            this.lblTotaal.Size = new System.Drawing.Size(137, 16);
            this.lblTotaal.TabIndex = 9;
            this.lblTotaal.Text = "Totaal aantal kamers:";
            // 
            // pbValue
            // 
            this.pbValue.Location = new System.Drawing.Point(103, 25);
            this.pbValue.Name = "pbValue";
            this.pbValue.Size = new System.Drawing.Size(583, 93);
            this.pbValue.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbValue);
            this.Controls.Add(this.lblTotaal);
            this.Controls.Add(this.txtTotaal);
            this.Controls.Add(this.lblAantal);
            this.Controls.Add(this.txtAantal);
            this.Controls.Add(this.btnBereken);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAantal;
        private System.Windows.Forms.TextBox txtAantal;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.TextBox txtTotaal;
        private System.Windows.Forms.Label lblTotaal;
        private CustomProgressBar pbValue;
    }
}

