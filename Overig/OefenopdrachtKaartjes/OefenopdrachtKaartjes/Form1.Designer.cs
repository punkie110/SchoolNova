namespace OefenopdrachtKaartjes
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
            this.lblScore = new System.Windows.Forms.Label();
            this.lblNwaarde = new System.Windows.Forms.Label();
            this.lblLwaarde = new System.Windows.Forms.Label();
            this.btnCijfer = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtNwaarde = new System.Windows.Forms.TextBox();
            this.txtCSE = new System.Windows.Forms.TextBox();
            this.txtLwaarde = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(72, 134);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(173, 16);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score op het examen (0/90):";
            // 
            // lblNwaarde
            // 
            this.lblNwaarde.AutoSize = true;
            this.lblNwaarde.Location = new System.Drawing.Point(72, 226);
            this.lblNwaarde.Name = "lblNwaarde";
            this.lblNwaarde.Size = new System.Drawing.Size(119, 16);
            this.lblNwaarde.TabIndex = 1;
            this.lblNwaarde.Text = "N-Waarde(0.8-2.5):";
            // 
            // lblLwaarde
            // 
            this.lblLwaarde.AutoSize = true;
            this.lblLwaarde.Location = new System.Drawing.Point(72, 181);
            this.lblLwaarde.Name = "lblLwaarde";
            this.lblLwaarde.Size = new System.Drawing.Size(133, 16);
            this.lblLwaarde.TabIndex = 2;
            this.lblLwaarde.Text = "L-waarde (max.cijfer):";
            // 
            // btnCijfer
            // 
            this.btnCijfer.Location = new System.Drawing.Point(173, 286);
            this.btnCijfer.Name = "btnCijfer";
            this.btnCijfer.Size = new System.Drawing.Size(288, 23);
            this.btnCijfer.TabIndex = 3;
            this.btnCijfer.Text = "Bereken CSE-cijfer";
            this.btnCijfer.UseVisualStyleBackColor = true;
            this.btnCijfer.Click += new System.EventHandler(this.btnCijfer_Click);
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(289, 131);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(100, 22);
            this.txtScore.TabIndex = 4;
            // 
            // txtNwaarde
            // 
            this.txtNwaarde.Location = new System.Drawing.Point(289, 226);
            this.txtNwaarde.Name = "txtNwaarde";
            this.txtNwaarde.Size = new System.Drawing.Size(100, 22);
            this.txtNwaarde.TabIndex = 5;
            // 
            // txtCSE
            // 
            this.txtCSE.Location = new System.Drawing.Point(289, 339);
            this.txtCSE.Name = "txtCSE";
            this.txtCSE.ReadOnly = true;
            this.txtCSE.Size = new System.Drawing.Size(109, 22);
            this.txtCSE.TabIndex = 6;
            this.txtCSE.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtLwaarde
            // 
            this.txtLwaarde.Location = new System.Drawing.Point(289, 178);
            this.txtLwaarde.Name = "txtLwaarde";
            this.txtLwaarde.Size = new System.Drawing.Size(100, 22);
            this.txtLwaarde.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "CSE-Cijfer(10/100):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLwaarde);
            this.Controls.Add(this.txtCSE);
            this.Controls.Add(this.txtNwaarde);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.btnCijfer);
            this.Controls.Add(this.lblLwaarde);
            this.Controls.Add(this.lblNwaarde);
            this.Controls.Add(this.lblScore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblNwaarde;
        private System.Windows.Forms.Label lblLwaarde;
        private System.Windows.Forms.Button btnCijfer;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.TextBox txtNwaarde;
        private System.Windows.Forms.TextBox txtCSE;
        private System.Windows.Forms.TextBox txtLwaarde;
        private System.Windows.Forms.Label label1;
    }
}

