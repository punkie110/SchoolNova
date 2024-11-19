namespace Les2Opdracht3
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
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.btnWisselOm = new System.Windows.Forms.Button();
            this.txtGetalA = new System.Windows.Forms.TextBox();
            this.txtGetalB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(223, 132);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(19, 16);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "A:";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(223, 197);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(19, 16);
            this.lblB.TabIndex = 1;
            this.lblB.Text = "B:";
            // 
            // btnWisselOm
            // 
            this.btnWisselOm.Location = new System.Drawing.Point(256, 228);
            this.btnWisselOm.Name = "btnWisselOm";
            this.btnWisselOm.Size = new System.Drawing.Size(253, 58);
            this.btnWisselOm.TabIndex = 2;
            this.btnWisselOm.Text = "Wissel Om";
            this.btnWisselOm.UseVisualStyleBackColor = true;
            this.btnWisselOm.Click += new System.EventHandler(this.btnWisselOm_Click);
            // 
            // txtGetalA
            // 
            this.txtGetalA.Location = new System.Drawing.Point(269, 129);
            this.txtGetalA.Name = "txtGetalA";
            this.txtGetalA.Size = new System.Drawing.Size(213, 22);
            this.txtGetalA.TabIndex = 3;
            // 
            // txtGetalB
            // 
            this.txtGetalB.Location = new System.Drawing.Point(269, 194);
            this.txtGetalB.Name = "txtGetalB";
            this.txtGetalB.Size = new System.Drawing.Size(213, 22);
            this.txtGetalB.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtGetalB);
            this.Controls.Add(this.txtGetalA);
            this.Controls.Add(this.btnWisselOm);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Button btnWisselOm;
        private System.Windows.Forms.TextBox txtGetalA;
        private System.Windows.Forms.TextBox txtGetalB;
    }
}

