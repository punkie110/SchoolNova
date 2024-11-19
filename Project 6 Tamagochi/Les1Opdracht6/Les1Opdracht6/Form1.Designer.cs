namespace Les1Opdracht6
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
            this.btnVoerUit = new System.Windows.Forms.Button();
            this.txtAantal = new System.Windows.Forms.TextBox();
            this.txt1cent = new System.Windows.Forms.TextBox();
            this.txt50cent = new System.Windows.Forms.TextBox();
            this.txt20cent = new System.Windows.Forms.TextBox();
            this.txt10cent = new System.Windows.Forms.TextBox();
            this.txt5cent = new System.Windows.Forms.TextBox();
            this.lbl50cent = new System.Windows.Forms.Label();
            this.lbl20cent = new System.Windows.Forms.Label();
            this.lbl10cent = new System.Windows.Forms.Label();
            this.lbl5cent = new System.Windows.Forms.Label();
            this.lbl1cent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAantal
            // 
            this.lblAantal.AutoSize = true;
            this.lblAantal.Location = new System.Drawing.Point(110, 91);
            this.lblAantal.Name = "lblAantal";
            this.lblAantal.Size = new System.Drawing.Size(93, 16);
            this.lblAantal.TabIndex = 0;
            this.lblAantal.Text = "Aantal Centen:";
            // 
            // btnVoerUit
            // 
            this.btnVoerUit.Location = new System.Drawing.Point(178, 129);
            this.btnVoerUit.Name = "btnVoerUit";
            this.btnVoerUit.Size = new System.Drawing.Size(237, 51);
            this.btnVoerUit.TabIndex = 1;
            this.btnVoerUit.Text = "Voer Splitsing uit";
            this.btnVoerUit.UseVisualStyleBackColor = true;
            this.btnVoerUit.Click += new System.EventHandler(this.btnVoerUit_Click);
            // 
            // txtAantal
            // 
            this.txtAantal.Location = new System.Drawing.Point(267, 91);
            this.txtAantal.Name = "txtAantal";
            this.txtAantal.Size = new System.Drawing.Size(100, 22);
            this.txtAantal.TabIndex = 2;
            // 
            // txt1cent
            // 
            this.txt1cent.Location = new System.Drawing.Point(277, 361);
            this.txt1cent.Name = "txt1cent";
            this.txt1cent.Size = new System.Drawing.Size(100, 22);
            this.txt1cent.TabIndex = 3;
            // 
            // txt50cent
            // 
            this.txt50cent.Location = new System.Drawing.Point(277, 195);
            this.txt50cent.Name = "txt50cent";
            this.txt50cent.Size = new System.Drawing.Size(100, 22);
            this.txt50cent.TabIndex = 4;
            // 
            // txt20cent
            // 
            this.txt20cent.Location = new System.Drawing.Point(277, 236);
            this.txt20cent.Name = "txt20cent";
            this.txt20cent.Size = new System.Drawing.Size(100, 22);
            this.txt20cent.TabIndex = 5;
            // 
            // txt10cent
            // 
            this.txt10cent.Location = new System.Drawing.Point(277, 278);
            this.txt10cent.Name = "txt10cent";
            this.txt10cent.Size = new System.Drawing.Size(100, 22);
            this.txt10cent.TabIndex = 6;
            // 
            // txt5cent
            // 
            this.txt5cent.Location = new System.Drawing.Point(277, 319);
            this.txt5cent.Name = "txt5cent";
            this.txt5cent.Size = new System.Drawing.Size(100, 22);
            this.txt5cent.TabIndex = 7;
            // 
            // lbl50cent
            // 
            this.lbl50cent.AutoSize = true;
            this.lbl50cent.Location = new System.Drawing.Point(110, 195);
            this.lbl50cent.Name = "lbl50cent";
            this.lbl50cent.Size = new System.Drawing.Size(52, 16);
            this.lbl50cent.TabIndex = 8;
            this.lbl50cent.Text = "50 cent:";
            // 
            // lbl20cent
            // 
            this.lbl20cent.AutoSize = true;
            this.lbl20cent.Location = new System.Drawing.Point(110, 236);
            this.lbl20cent.Name = "lbl20cent";
            this.lbl20cent.Size = new System.Drawing.Size(52, 16);
            this.lbl20cent.TabIndex = 9;
            this.lbl20cent.Text = "20 cent:";
            // 
            // lbl10cent
            // 
            this.lbl10cent.AutoSize = true;
            this.lbl10cent.Location = new System.Drawing.Point(110, 278);
            this.lbl10cent.Name = "lbl10cent";
            this.lbl10cent.Size = new System.Drawing.Size(52, 16);
            this.lbl10cent.TabIndex = 10;
            this.lbl10cent.Text = "10 cent:";
            // 
            // lbl5cent
            // 
            this.lbl5cent.AutoSize = true;
            this.lbl5cent.Location = new System.Drawing.Point(110, 322);
            this.lbl5cent.Name = "lbl5cent";
            this.lbl5cent.Size = new System.Drawing.Size(45, 16);
            this.lbl5cent.TabIndex = 11;
            this.lbl5cent.Text = "5 cent:";
            // 
            // lbl1cent
            // 
            this.lbl1cent.AutoSize = true;
            this.lbl1cent.Location = new System.Drawing.Point(110, 367);
            this.lbl1cent.Name = "lbl1cent";
            this.lbl1cent.Size = new System.Drawing.Size(45, 16);
            this.lbl1cent.TabIndex = 12;
            this.lbl1cent.Text = "1 cent:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl1cent);
            this.Controls.Add(this.lbl5cent);
            this.Controls.Add(this.lbl10cent);
            this.Controls.Add(this.lbl20cent);
            this.Controls.Add(this.lbl50cent);
            this.Controls.Add(this.txt5cent);
            this.Controls.Add(this.txt10cent);
            this.Controls.Add(this.txt20cent);
            this.Controls.Add(this.txt50cent);
            this.Controls.Add(this.txt1cent);
            this.Controls.Add(this.txtAantal);
            this.Controls.Add(this.btnVoerUit);
            this.Controls.Add(this.lblAantal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAantal;
        private System.Windows.Forms.Button btnVoerUit;
        private System.Windows.Forms.TextBox txtAantal;
        private System.Windows.Forms.TextBox txt1cent;
        private System.Windows.Forms.TextBox txt50cent;
        private System.Windows.Forms.TextBox txt20cent;
        private System.Windows.Forms.TextBox txt10cent;
        private System.Windows.Forms.TextBox txt5cent;
        private System.Windows.Forms.Label lbl50cent;
        private System.Windows.Forms.Label lbl20cent;
        private System.Windows.Forms.Label lbl10cent;
        private System.Windows.Forms.Label lbl5cent;
        private System.Windows.Forms.Label lbl1cent;
    }
}

