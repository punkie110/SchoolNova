namespace JustinMunkOpdrachtGeldautomaat
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
            this.lblWelkom = new System.Windows.Forms.Label();
            this.btnNeemGeldOp = new System.Windows.Forms.Button();
            this.txtGeldOpnemen = new System.Windows.Forms.TextBox();
            this.lblHoveel = new System.Windows.Forms.Label();
            this.txtHuidigSaldo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelkom
            // 
            this.lblWelkom.AutoSize = true;
            this.lblWelkom.BackColor = System.Drawing.Color.Silver;
            this.lblWelkom.Font = new System.Drawing.Font("Yu Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelkom.Location = new System.Drawing.Point(143, 9);
            this.lblWelkom.Name = "lblWelkom";
            this.lblWelkom.Size = new System.Drawing.Size(502, 60);
            this.lblWelkom.TabIndex = 0;
            this.lblWelkom.Text = "Welkom, uw saldo is:";
            // 
            // btnNeemGeldOp
            // 
            this.btnNeemGeldOp.Font = new System.Drawing.Font("Yu Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNeemGeldOp.Location = new System.Drawing.Point(432, 224);
            this.btnNeemGeldOp.Name = "btnNeemGeldOp";
            this.btnNeemGeldOp.Size = new System.Drawing.Size(345, 108);
            this.btnNeemGeldOp.TabIndex = 2;
            this.btnNeemGeldOp.Text = "Neem Geld op!";
            this.btnNeemGeldOp.UseVisualStyleBackColor = true;
            this.btnNeemGeldOp.Click += new System.EventHandler(this.btnNeemGeldOp_Click);
            // 
            // txtGeldOpnemen
            // 
            this.txtGeldOpnemen.Location = new System.Drawing.Point(88, 299);
            this.txtGeldOpnemen.Name = "txtGeldOpnemen";
            this.txtGeldOpnemen.Size = new System.Drawing.Size(305, 22);
            this.txtGeldOpnemen.TabIndex = 3;
            // 
            // lblHoveel
            // 
            this.lblHoveel.AutoSize = true;
            this.lblHoveel.BackColor = System.Drawing.Color.Silver;
            this.lblHoveel.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoveel.Location = new System.Drawing.Point(35, 239);
            this.lblHoveel.Name = "lblHoveel";
            this.lblHoveel.Size = new System.Drawing.Size(358, 36);
            this.lblHoveel.TabIndex = 4;
            this.lblHoveel.Text = "Hoeveel wilt u opnemen?";
            // 
            // txtHuidigSaldo
            // 
            this.txtHuidigSaldo.Location = new System.Drawing.Point(211, 90);
            this.txtHuidigSaldo.Name = "txtHuidigSaldo";
            this.txtHuidigSaldo.ReadOnly = true;
            this.txtHuidigSaldo.Size = new System.Drawing.Size(399, 22);
            this.txtHuidigSaldo.TabIndex = 5;
            this.txtHuidigSaldo.Text = "1226";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "€";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHuidigSaldo);
            this.Controls.Add(this.lblHoveel);
            this.Controls.Add(this.txtGeldOpnemen);
            this.Controls.Add(this.btnNeemGeldOp);
            this.Controls.Add(this.lblWelkom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelkom;
        private System.Windows.Forms.Button btnNeemGeldOp;
        private System.Windows.Forms.TextBox txtGeldOpnemen;
        private System.Windows.Forms.Label lblHoveel;
        private System.Windows.Forms.TextBox txtHuidigSaldo;
        private System.Windows.Forms.Label label1;
    }
}

