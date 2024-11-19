namespace JustinMunkDoWhileLusOpdracht2
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
            this.lblGetal1 = new System.Windows.Forms.Label();
            this.lblGetal2 = new System.Windows.Forms.Label();
            this.lblDoWhile2 = new System.Windows.Forms.Label();
            this.txtGetal1 = new System.Windows.Forms.TextBox();
            this.txtGetal2 = new System.Windows.Forms.TextBox();
            this.rdbPlus = new System.Windows.Forms.RadioButton();
            this.rdbMin = new System.Windows.Forms.RadioButton();
            this.btnResultaat = new System.Windows.Forms.Button();
            this.txtResultaat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblGetal1
            // 
            this.lblGetal1.AutoSize = true;
            this.lblGetal1.Location = new System.Drawing.Point(139, 162);
            this.lblGetal1.Name = "lblGetal1";
            this.lblGetal1.Size = new System.Drawing.Size(84, 16);
            this.lblGetal1.TabIndex = 0;
            this.lblGetal1.Text = "Eerste Getal:";
            // 
            // lblGetal2
            // 
            this.lblGetal2.AutoSize = true;
            this.lblGetal2.Location = new System.Drawing.Point(139, 225);
            this.lblGetal2.Name = "lblGetal2";
            this.lblGetal2.Size = new System.Drawing.Size(95, 16);
            this.lblGetal2.TabIndex = 1;
            this.lblGetal2.Text = "Tweede Getal:";
            // 
            // lblDoWhile2
            // 
            this.lblDoWhile2.AutoSize = true;
            this.lblDoWhile2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoWhile2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblDoWhile2.Location = new System.Drawing.Point(479, 53);
            this.lblDoWhile2.Name = "lblDoWhile2";
            this.lblDoWhile2.Size = new System.Drawing.Size(214, 46);
            this.lblDoWhile2.TabIndex = 2;
            this.lblDoWhile2.Text = "DoWhile 2";
            // 
            // txtGetal1
            // 
            this.txtGetal1.Location = new System.Drawing.Point(315, 162);
            this.txtGetal1.Name = "txtGetal1";
            this.txtGetal1.Size = new System.Drawing.Size(155, 22);
            this.txtGetal1.TabIndex = 3;
            // 
            // txtGetal2
            // 
            this.txtGetal2.Location = new System.Drawing.Point(315, 225);
            this.txtGetal2.Name = "txtGetal2";
            this.txtGetal2.Size = new System.Drawing.Size(155, 22);
            this.txtGetal2.TabIndex = 4;
            // 
            // rdbPlus
            // 
            this.rdbPlus.AutoSize = true;
            this.rdbPlus.Location = new System.Drawing.Point(330, 288);
            this.rdbPlus.Name = "rdbPlus";
            this.rdbPlus.Size = new System.Drawing.Size(35, 20);
            this.rdbPlus.TabIndex = 5;
            this.rdbPlus.TabStop = true;
            this.rdbPlus.Text = "+";
            this.rdbPlus.UseVisualStyleBackColor = true;
            // 
            // rdbMin
            // 
            this.rdbMin.AutoSize = true;
            this.rdbMin.Location = new System.Drawing.Point(409, 288);
            this.rdbMin.Name = "rdbMin";
            this.rdbMin.Size = new System.Drawing.Size(32, 20);
            this.rdbMin.TabIndex = 6;
            this.rdbMin.TabStop = true;
            this.rdbMin.Text = "-";
            this.rdbMin.UseVisualStyleBackColor = true;
            // 
            // btnResultaat
            // 
            this.btnResultaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultaat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnResultaat.Location = new System.Drawing.Point(301, 323);
            this.btnResultaat.Name = "btnResultaat";
            this.btnResultaat.Size = new System.Drawing.Size(180, 38);
            this.btnResultaat.TabIndex = 7;
            this.btnResultaat.Text = "Resultaat";
            this.btnResultaat.UseVisualStyleBackColor = true;
            this.btnResultaat.Click += new System.EventHandler(this.btnResultaat_Click);
            // 
            // txtResultaat
            // 
            this.txtResultaat.Location = new System.Drawing.Point(311, 388);
            this.txtResultaat.Name = "txtResultaat";
            this.txtResultaat.ReadOnly = true;
            this.txtResultaat.Size = new System.Drawing.Size(170, 22);
            this.txtResultaat.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResultaat);
            this.Controls.Add(this.btnResultaat);
            this.Controls.Add(this.rdbMin);
            this.Controls.Add(this.rdbPlus);
            this.Controls.Add(this.txtGetal2);
            this.Controls.Add(this.txtGetal1);
            this.Controls.Add(this.lblDoWhile2);
            this.Controls.Add(this.lblGetal2);
            this.Controls.Add(this.lblGetal1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGetal1;
        private System.Windows.Forms.Label lblGetal2;
        private System.Windows.Forms.Label lblDoWhile2;
        private System.Windows.Forms.TextBox txtGetal1;
        private System.Windows.Forms.TextBox txtGetal2;
        private System.Windows.Forms.RadioButton rdbPlus;
        private System.Windows.Forms.RadioButton rdbMin;
        private System.Windows.Forms.Button btnResultaat;
        private System.Windows.Forms.TextBox txtResultaat;
    }
}

