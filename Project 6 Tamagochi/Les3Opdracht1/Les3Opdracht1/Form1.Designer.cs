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
            this.btnBereken = new System.Windows.Forms.Button();
            this.pbAantal = new Les3Opdracht1.CustomProgressBar();
            this.txtAantal = new System.Windows.Forms.TextBox();
            this.lblAantal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(208, 171);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(375, 97);
            this.btnBereken.TabIndex = 0;
            this.btnBereken.Text = "bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // pbAantal
            // 
            this.pbAantal.Location = new System.Drawing.Point(135, 12);
            this.pbAantal.Name = "pbAantal";
            this.pbAantal.Size = new System.Drawing.Size(541, 61);
            this.pbAantal.TabIndex = 1;
            // 
            // txtAantal
            // 
            this.txtAantal.Location = new System.Drawing.Point(378, 112);
            this.txtAantal.Name = "txtAantal";
            this.txtAantal.Size = new System.Drawing.Size(163, 22);
            this.txtAantal.TabIndex = 2;
            // 
            // lblAantal
            // 
            this.lblAantal.AutoSize = true;
            this.lblAantal.Location = new System.Drawing.Point(150, 119);
            this.lblAantal.Name = "lblAantal";
            this.lblAantal.Size = new System.Drawing.Size(142, 16);
            this.lblAantal.TabIndex = 3;
            this.lblAantal.Text = "Aantal tussen 1 en 100:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAantal);
            this.Controls.Add(this.txtAantal);
            this.Controls.Add(this.pbAantal);
            this.Controls.Add(this.btnBereken);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.ProgressBar pbAantal;
        private System.Windows.Forms.TextBox txtAantal;
        private System.Windows.Forms.Label lblAantal;
    }
}

