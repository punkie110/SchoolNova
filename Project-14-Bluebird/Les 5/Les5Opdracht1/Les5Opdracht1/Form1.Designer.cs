namespace Les5Opdracht1
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
            this.btnLaatst = new System.Windows.Forms.Button();
            this.btnInvoer = new System.Windows.Forms.Button();
            this.btnEerst = new System.Windows.Forms.Button();
            this.lbxOverzicht = new System.Windows.Forms.ListBox();
            this.lblTotaal = new System.Windows.Forms.Label();
            this.txtTotaal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLaatst
            // 
            this.btnLaatst.Location = new System.Drawing.Point(578, 26);
            this.btnLaatst.Name = "btnLaatst";
            this.btnLaatst.Size = new System.Drawing.Size(210, 59);
            this.btnLaatst.TabIndex = 0;
            this.btnLaatst.Text = "Laatst ingevoerde";
            this.btnLaatst.UseVisualStyleBackColor = true;
            this.btnLaatst.Click += new System.EventHandler(this.btnLaatst_Click);
            // 
            // btnInvoer
            // 
            this.btnInvoer.Location = new System.Drawing.Point(578, 179);
            this.btnInvoer.Name = "btnInvoer";
            this.btnInvoer.Size = new System.Drawing.Size(210, 59);
            this.btnInvoer.TabIndex = 1;
            this.btnInvoer.Text = "Invoer Studenten";
            this.btnInvoer.UseVisualStyleBackColor = true;
            this.btnInvoer.Click += new System.EventHandler(this.btnInvoer_Click);
            // 
            // btnEerst
            // 
            this.btnEerst.Location = new System.Drawing.Point(578, 102);
            this.btnEerst.Name = "btnEerst";
            this.btnEerst.Size = new System.Drawing.Size(210, 59);
            this.btnEerst.TabIndex = 2;
            this.btnEerst.Text = "Eerste ingevoerde";
            this.btnEerst.UseVisualStyleBackColor = true;
            this.btnEerst.Click += new System.EventHandler(this.btnEerst_Click);
            // 
            // lbxOverzicht
            // 
            this.lbxOverzicht.FormattingEnabled = true;
            this.lbxOverzicht.ItemHeight = 16;
            this.lbxOverzicht.Location = new System.Drawing.Point(32, 12);
            this.lbxOverzicht.Name = "lbxOverzicht";
            this.lbxOverzicht.Size = new System.Drawing.Size(520, 308);
            this.lbxOverzicht.TabIndex = 3;
            // 
            // lblTotaal
            // 
            this.lblTotaal.AutoSize = true;
            this.lblTotaal.Location = new System.Drawing.Point(53, 379);
            this.lblTotaal.Name = "lblTotaal";
            this.lblTotaal.Size = new System.Drawing.Size(133, 16);
            this.lblTotaal.TabIndex = 4;
            this.lblTotaal.Text = "Totaal aantal kluizen:";
            // 
            // txtTotaal
            // 
            this.txtTotaal.Location = new System.Drawing.Point(192, 373);
            this.txtTotaal.Name = "txtTotaal";
            this.txtTotaal.Size = new System.Drawing.Size(168, 22);
            this.txtTotaal.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTotaal);
            this.Controls.Add(this.lblTotaal);
            this.Controls.Add(this.lbxOverzicht);
            this.Controls.Add(this.btnEerst);
            this.Controls.Add(this.btnInvoer);
            this.Controls.Add(this.btnLaatst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLaatst;
        private System.Windows.Forms.Button btnInvoer;
        private System.Windows.Forms.Button btnEerst;
        private System.Windows.Forms.ListBox lbxOverzicht;
        private System.Windows.Forms.Label lblTotaal;
        private System.Windows.Forms.TextBox txtTotaal;
    }
}

