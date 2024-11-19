namespace Project_dierenarts
{
    partial class ToevoegenBehandeling
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
            this.label1 = new System.Windows.Forms.Label();
            this.clbBehandelingen = new System.Windows.Forms.CheckedListBox();
            this.btnVoegToe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voeg een Behandeling toe aan deze klant";
            // 
            // clbBehandelingen
            // 
            this.clbBehandelingen.BackColor = System.Drawing.SystemColors.Menu;
            this.clbBehandelingen.FormattingEnabled = true;
            this.clbBehandelingen.Location = new System.Drawing.Point(108, 128);
            this.clbBehandelingen.Name = "clbBehandelingen";
            this.clbBehandelingen.Size = new System.Drawing.Size(223, 208);
            this.clbBehandelingen.TabIndex = 1;
            // 
            // btnVoegToe
            // 
            this.btnVoegToe.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoegToe.Location = new System.Drawing.Point(400, 308);
            this.btnVoegToe.Name = "btnVoegToe";
            this.btnVoegToe.Size = new System.Drawing.Size(335, 130);
            this.btnVoegToe.TabIndex = 2;
            this.btnVoegToe.Text = "Voeg Toe";
            this.btnVoegToe.UseVisualStyleBackColor = true;
            this.btnVoegToe.Click += new System.EventHandler(this.btnVoegToe_Click);
            // 
            // ToevoegenBehandeling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoegToe);
            this.Controls.Add(this.clbBehandelingen);
            this.Controls.Add(this.label1);
            this.Name = "ToevoegenBehandeling";
            this.Text = "ToevoegenBehandeling";
            this.Load += new System.EventHandler(this.ToevoegenBehandeling_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox clbBehandelingen;
        private System.Windows.Forms.Button btnVoegToe;
    }
}