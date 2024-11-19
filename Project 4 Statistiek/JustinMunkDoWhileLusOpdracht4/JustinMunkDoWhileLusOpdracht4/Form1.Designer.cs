namespace JustinMunkDoWhileLusOpdracht4
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
            this.btnResultaat = new System.Windows.Forms.Button();
            this.txtResultaat = new System.Windows.Forms.TextBox();
            this.txtGetal = new System.Windows.Forms.TextBox();
            this.lblGetal = new System.Windows.Forms.Label();
            this.lblDoWhile = new System.Windows.Forms.Label();
            this.pbxResultaat = new System.Windows.Forms.PictureBox();
            this.lblPogingen = new System.Windows.Forms.Label();
            this.txtPogingen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxResultaat)).BeginInit();
            this.SuspendLayout();
            // 
            // btnResultaat
            // 
            this.btnResultaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultaat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnResultaat.Location = new System.Drawing.Point(274, 358);
            this.btnResultaat.Margin = new System.Windows.Forms.Padding(4);
            this.btnResultaat.Name = "btnResultaat";
            this.btnResultaat.Size = new System.Drawing.Size(128, 98);
            this.btnResultaat.TabIndex = 11;
            this.btnResultaat.Text = "Raad het getal";
            this.btnResultaat.UseVisualStyleBackColor = true;
            this.btnResultaat.Click += new System.EventHandler(this.btnResultaat_Click);
            // 
            // txtResultaat
            // 
            this.txtResultaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultaat.Location = new System.Drawing.Point(416, 358);
            this.txtResultaat.Margin = new System.Windows.Forms.Padding(4);
            this.txtResultaat.Multiline = true;
            this.txtResultaat.Name = "txtResultaat";
            this.txtResultaat.ReadOnly = true;
            this.txtResultaat.Size = new System.Drawing.Size(383, 98);
            this.txtResultaat.TabIndex = 10;
            // 
            // txtGetal
            // 
            this.txtGetal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGetal.Location = new System.Drawing.Point(148, 425);
            this.txtGetal.Margin = new System.Windows.Forms.Padding(4);
            this.txtGetal.Name = "txtGetal";
            this.txtGetal.Size = new System.Drawing.Size(104, 30);
            this.txtGetal.TabIndex = 9;
            // 
            // lblGetal
            // 
            this.lblGetal.AutoSize = true;
            this.lblGetal.Location = new System.Drawing.Point(7, 425);
            this.lblGetal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGetal.Name = "lblGetal";
            this.lblGetal.Size = new System.Drawing.Size(104, 32);
            this.lblGetal.TabIndex = 8;
            this.lblGetal.Text = "Raad het getal \r\ntussen 1 t/m 100:";
            // 
            // lblDoWhile
            // 
            this.lblDoWhile.AutoSize = true;
            this.lblDoWhile.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoWhile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDoWhile.Location = new System.Drawing.Point(2, -6);
            this.lblDoWhile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDoWhile.Name = "lblDoWhile";
            this.lblDoWhile.Size = new System.Drawing.Size(339, 91);
            this.lblDoWhile.TabIndex = 7;
            this.lblDoWhile.Text = "DoWhile";
            // 
            // pbxResultaat
            // 
            this.pbxResultaat.Image = global::JustinMunkDoWhileLusOpdracht4.Properties.Resources.thinkmark;
            this.pbxResultaat.Location = new System.Drawing.Point(392, 12);
            this.pbxResultaat.Name = "pbxResultaat";
            this.pbxResultaat.Size = new System.Drawing.Size(396, 339);
            this.pbxResultaat.TabIndex = 12;
            this.pbxResultaat.TabStop = false;
            // 
            // lblPogingen
            // 
            this.lblPogingen.AutoSize = true;
            this.lblPogingen.Location = new System.Drawing.Point(7, 390);
            this.lblPogingen.Name = "lblPogingen";
            this.lblPogingen.Size = new System.Drawing.Size(109, 16);
            this.lblPogingen.TabIndex = 13;
            this.lblPogingen.Text = "Aantal Pogingen:";
            // 
            // txtPogingen
            // 
            this.txtPogingen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPogingen.Location = new System.Drawing.Point(148, 380);
            this.txtPogingen.Margin = new System.Windows.Forms.Padding(4);
            this.txtPogingen.Name = "txtPogingen";
            this.txtPogingen.Size = new System.Drawing.Size(104, 30);
            this.txtPogingen.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.txtPogingen);
            this.Controls.Add(this.lblPogingen);
            this.Controls.Add(this.pbxResultaat);
            this.Controls.Add(this.btnResultaat);
            this.Controls.Add(this.txtResultaat);
            this.Controls.Add(this.txtGetal);
            this.Controls.Add(this.lblGetal);
            this.Controls.Add(this.lblDoWhile);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxResultaat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResultaat;
        private System.Windows.Forms.TextBox txtResultaat;
        private System.Windows.Forms.TextBox txtGetal;
        private System.Windows.Forms.Label lblGetal;
        private System.Windows.Forms.Label lblDoWhile;
        private System.Windows.Forms.PictureBox pbxResultaat;
        private System.Windows.Forms.Label lblPogingen;
        private System.Windows.Forms.TextBox txtPogingen;
    }
}

