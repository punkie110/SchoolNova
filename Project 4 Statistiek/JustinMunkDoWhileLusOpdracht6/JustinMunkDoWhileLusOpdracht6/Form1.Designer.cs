namespace JustinMunkDoWhileLusOpdracht6
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
            this.txtPogingen = new System.Windows.Forms.TextBox();
            this.lblPogingen = new System.Windows.Forms.Label();
            this.btnResultaat = new System.Windows.Forms.Button();
            this.txtResultaat = new System.Windows.Forms.TextBox();
            this.txtGetal = new System.Windows.Forms.TextBox();
            this.lblGetal = new System.Windows.Forms.Label();
            this.lblDoWhile = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.pbxResultaat = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxResultaat)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPogingen
            // 
            this.txtPogingen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPogingen.Location = new System.Drawing.Point(164, 133);
            this.txtPogingen.Margin = new System.Windows.Forms.Padding(4);
            this.txtPogingen.Name = "txtPogingen";
            this.txtPogingen.ReadOnly = true;
            this.txtPogingen.Size = new System.Drawing.Size(104, 30);
            this.txtPogingen.TabIndex = 21;
            // 
            // lblPogingen
            // 
            this.lblPogingen.AutoSize = true;
            this.lblPogingen.Location = new System.Drawing.Point(26, 143);
            this.lblPogingen.Name = "lblPogingen";
            this.lblPogingen.Size = new System.Drawing.Size(109, 16);
            this.lblPogingen.TabIndex = 20;
            this.lblPogingen.Text = "Aantal Pogingen:";
            // 
            // btnResultaat
            // 
            this.btnResultaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultaat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnResultaat.Location = new System.Drawing.Point(271, 349);
            this.btnResultaat.Margin = new System.Windows.Forms.Padding(4);
            this.btnResultaat.Name = "btnResultaat";
            this.btnResultaat.Size = new System.Drawing.Size(128, 98);
            this.btnResultaat.TabIndex = 18;
            this.btnResultaat.Text = "Raad het getal";
            this.btnResultaat.UseVisualStyleBackColor = true;
            this.btnResultaat.Click += new System.EventHandler(this.btnResultaat_Click);
            // 
            // txtResultaat
            // 
            this.txtResultaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultaat.Location = new System.Drawing.Point(413, 349);
            this.txtResultaat.Margin = new System.Windows.Forms.Padding(4);
            this.txtResultaat.Multiline = true;
            this.txtResultaat.Name = "txtResultaat";
            this.txtResultaat.ReadOnly = true;
            this.txtResultaat.Size = new System.Drawing.Size(383, 98);
            this.txtResultaat.TabIndex = 17;
            // 
            // txtGetal
            // 
            this.txtGetal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGetal.Location = new System.Drawing.Point(164, 243);
            this.txtGetal.Margin = new System.Windows.Forms.Padding(4);
            this.txtGetal.Name = "txtGetal";
            this.txtGetal.Size = new System.Drawing.Size(104, 30);
            this.txtGetal.TabIndex = 16;
            // 
            // lblGetal
            // 
            this.lblGetal.AutoSize = true;
            this.lblGetal.Location = new System.Drawing.Point(31, 241);
            this.lblGetal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGetal.Name = "lblGetal";
            this.lblGetal.Size = new System.Drawing.Size(104, 32);
            this.lblGetal.TabIndex = 15;
            this.lblGetal.Text = "Raad het getal \r\ntussen 1 t/m 100:";
            // 
            // lblDoWhile
            // 
            this.lblDoWhile.AutoSize = true;
            this.lblDoWhile.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoWhile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDoWhile.Location = new System.Drawing.Point(13, 3);
            this.lblDoWhile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDoWhile.Name = "lblDoWhile";
            this.lblDoWhile.Size = new System.Drawing.Size(339, 91);
            this.lblDoWhile.TabIndex = 22;
            this.lblDoWhile.Text = "DoWhile";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReset.Location = new System.Drawing.Point(7, 349);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(128, 98);
            this.btnReset.TabIndex = 23;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pbxResultaat
            // 
            this.pbxResultaat.Image = global::JustinMunkDoWhileLusOpdracht6.Properties.Resources.guessthenumber;
            this.pbxResultaat.Location = new System.Drawing.Point(389, 3);
            this.pbxResultaat.Name = "pbxResultaat";
            this.pbxResultaat.Size = new System.Drawing.Size(396, 339);
            this.pbxResultaat.TabIndex = 19;
            this.pbxResultaat.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblDoWhile);
            this.Controls.Add(this.txtPogingen);
            this.Controls.Add(this.lblPogingen);
            this.Controls.Add(this.pbxResultaat);
            this.Controls.Add(this.btnResultaat);
            this.Controls.Add(this.txtResultaat);
            this.Controls.Add(this.txtGetal);
            this.Controls.Add(this.lblGetal);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxResultaat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPogingen;
        private System.Windows.Forms.Label lblPogingen;
        private System.Windows.Forms.PictureBox pbxResultaat;
        private System.Windows.Forms.Button btnResultaat;
        private System.Windows.Forms.TextBox txtResultaat;
        private System.Windows.Forms.TextBox txtGetal;
        private System.Windows.Forms.Label lblGetal;
        private System.Windows.Forms.Label lblDoWhile;
        private System.Windows.Forms.Button btnReset;
    }
}

