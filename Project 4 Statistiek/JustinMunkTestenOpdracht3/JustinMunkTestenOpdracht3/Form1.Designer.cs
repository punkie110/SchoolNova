namespace JustinMunkTestenOpdracht3
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
            this.lblBeginWaarde = new System.Windows.Forms.Label();
            this.lblEindWaarde = new System.Windows.Forms.Label();
            this.btnAdvies = new System.Windows.Forms.Button();
            this.lbxWaarden = new System.Windows.Forms.ListBox();
            this.txtBeginwaarde = new System.Windows.Forms.TextBox();
            this.txtEindwaarde = new System.Windows.Forms.TextBox();
            this.rdbFor = new System.Windows.Forms.RadioButton();
            this.rdbWhile = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblBeginWaarde
            // 
            this.lblBeginWaarde.AutoSize = true;
            this.lblBeginWaarde.Location = new System.Drawing.Point(47, 107);
            this.lblBeginWaarde.Name = "lblBeginWaarde";
            this.lblBeginWaarde.Size = new System.Drawing.Size(89, 16);
            this.lblBeginWaarde.TabIndex = 0;
            this.lblBeginWaarde.Text = "beginwaarde:";
            // 
            // lblEindWaarde
            // 
            this.lblEindWaarde.AutoSize = true;
            this.lblEindWaarde.Location = new System.Drawing.Point(47, 150);
            this.lblEindWaarde.Name = "lblEindWaarde";
            this.lblEindWaarde.Size = new System.Drawing.Size(81, 16);
            this.lblEindWaarde.TabIndex = 1;
            this.lblEindWaarde.Text = "eindwaarde:";
            // 
            // btnAdvies
            // 
            this.btnAdvies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAdvies.Location = new System.Drawing.Point(247, 239);
            this.btnAdvies.Name = "btnAdvies";
            this.btnAdvies.Size = new System.Drawing.Size(316, 47);
            this.btnAdvies.TabIndex = 2;
            this.btnAdvies.Text = "Geef Advies";
            this.btnAdvies.UseVisualStyleBackColor = false;
            this.btnAdvies.Click += new System.EventHandler(this.btnAdvies_Click);
            // 
            // lbxWaarden
            // 
            this.lbxWaarden.FormattingEnabled = true;
            this.lbxWaarden.ItemHeight = 16;
            this.lbxWaarden.Location = new System.Drawing.Point(247, 292);
            this.lbxWaarden.Name = "lbxWaarden";
            this.lbxWaarden.Size = new System.Drawing.Size(320, 148);
            this.lbxWaarden.TabIndex = 3;
            // 
            // txtBeginwaarde
            // 
            this.txtBeginwaarde.Location = new System.Drawing.Point(247, 107);
            this.txtBeginwaarde.Name = "txtBeginwaarde";
            this.txtBeginwaarde.Size = new System.Drawing.Size(270, 22);
            this.txtBeginwaarde.TabIndex = 4;
            // 
            // txtEindwaarde
            // 
            this.txtEindwaarde.Location = new System.Drawing.Point(247, 150);
            this.txtEindwaarde.Name = "txtEindwaarde";
            this.txtEindwaarde.Size = new System.Drawing.Size(270, 22);
            this.txtEindwaarde.TabIndex = 5;
            // 
            // rdbFor
            // 
            this.rdbFor.AutoSize = true;
            this.rdbFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFor.Location = new System.Drawing.Point(274, 183);
            this.rdbFor.Name = "rdbFor";
            this.rdbFor.Size = new System.Drawing.Size(91, 50);
            this.rdbFor.TabIndex = 6;
            this.rdbFor.TabStop = true;
            this.rdbFor.Text = "for";
            this.rdbFor.UseVisualStyleBackColor = true;
            // 
            // rdbWhile
            // 
            this.rdbWhile.AutoSize = true;
            this.rdbWhile.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbWhile.Location = new System.Drawing.Point(426, 183);
            this.rdbWhile.Name = "rdbWhile";
            this.rdbWhile.Size = new System.Drawing.Size(137, 50);
            this.rdbWhile.TabIndex = 7;
            this.rdbWhile.TabStop = true;
            this.rdbWhile.Text = "while";
            this.rdbWhile.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdbWhile);
            this.Controls.Add(this.rdbFor);
            this.Controls.Add(this.txtEindwaarde);
            this.Controls.Add(this.txtBeginwaarde);
            this.Controls.Add(this.lbxWaarden);
            this.Controls.Add(this.btnAdvies);
            this.Controls.Add(this.lblEindWaarde);
            this.Controls.Add(this.lblBeginWaarde);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBeginWaarde;
        private System.Windows.Forms.Label lblEindWaarde;
        private System.Windows.Forms.Button btnAdvies;
        private System.Windows.Forms.ListBox lbxWaarden;
        private System.Windows.Forms.TextBox txtBeginwaarde;
        private System.Windows.Forms.TextBox txtEindwaarde;
        private System.Windows.Forms.RadioButton rdbFor;
        private System.Windows.Forms.RadioButton rdbWhile;
    }
}

