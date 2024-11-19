namespace Les4opdracht1
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
            this.lbxOverzicht = new System.Windows.Forms.ListBox();
            this.lblTotaal = new System.Windows.Forms.Label();
            this.txtTotaal = new System.Windows.Forms.TextBox();
            this.btnGeenReservering = new System.Windows.Forms.Button();
            this.btnReservering = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxOverzicht
            // 
            this.lbxOverzicht.FormattingEnabled = true;
            this.lbxOverzicht.ItemHeight = 16;
            this.lbxOverzicht.Location = new System.Drawing.Point(3, 2);
            this.lbxOverzicht.Name = "lbxOverzicht";
            this.lbxOverzicht.Size = new System.Drawing.Size(665, 388);
            this.lbxOverzicht.TabIndex = 0;
            // 
            // lblTotaal
            // 
            this.lblTotaal.AutoSize = true;
            this.lblTotaal.Location = new System.Drawing.Point(48, 420);
            this.lblTotaal.Name = "lblTotaal";
            this.lblTotaal.Size = new System.Drawing.Size(149, 16);
            this.lblTotaal.TabIndex = 1;
            this.lblTotaal.Text = "Totaal aantal Studenten";
            // 
            // txtTotaal
            // 
            this.txtTotaal.Location = new System.Drawing.Point(230, 420);
            this.txtTotaal.Name = "txtTotaal";
            this.txtTotaal.Size = new System.Drawing.Size(194, 22);
            this.txtTotaal.TabIndex = 2;
            // 
            // btnGeenReservering
            // 
            this.btnGeenReservering.Location = new System.Drawing.Point(674, 41);
            this.btnGeenReservering.Name = "btnGeenReservering";
            this.btnGeenReservering.Size = new System.Drawing.Size(114, 66);
            this.btnGeenReservering.TabIndex = 3;
            this.btnGeenReservering.Text = "Geen Reservering";
            this.btnGeenReservering.UseVisualStyleBackColor = true;
            this.btnGeenReservering.Click += new System.EventHandler(this.btnGeenReservering_Click);
            // 
            // btnReservering
            // 
            this.btnReservering.Location = new System.Drawing.Point(674, 122);
            this.btnReservering.Name = "btnReservering";
            this.btnReservering.Size = new System.Drawing.Size(114, 66);
            this.btnReservering.TabIndex = 4;
            this.btnReservering.Text = "Wel Reservering";
            this.btnReservering.UseVisualStyleBackColor = true;
            this.btnReservering.Click += new System.EventHandler(this.btnReservering_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReservering);
            this.Controls.Add(this.btnGeenReservering);
            this.Controls.Add(this.txtTotaal);
            this.Controls.Add(this.lblTotaal);
            this.Controls.Add(this.lbxOverzicht);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxOverzicht;
        private System.Windows.Forms.Label lblTotaal;
        private System.Windows.Forms.TextBox txtTotaal;
        private System.Windows.Forms.Button btnGeenReservering;
        private System.Windows.Forms.Button btnReservering;
    }
}

