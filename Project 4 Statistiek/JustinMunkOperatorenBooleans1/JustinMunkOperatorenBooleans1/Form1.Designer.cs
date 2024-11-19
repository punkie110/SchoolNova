namespace JustinMunkOperatorenBooleans1
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
            this.lblCijfer = new System.Windows.Forms.Label();
            this.txtCijfer = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnResultaat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCijfer
            // 
            this.lblCijfer.AutoSize = true;
            this.lblCijfer.Location = new System.Drawing.Point(65, 149);
            this.lblCijfer.Name = "lblCijfer";
            this.lblCijfer.Size = new System.Drawing.Size(40, 16);
            this.lblCijfer.TabIndex = 0;
            this.lblCijfer.Text = "Cijfer:";
            // 
            // txtCijfer
            // 
            this.txtCijfer.Location = new System.Drawing.Point(139, 143);
            this.txtCijfer.Name = "txtCijfer";
            this.txtCijfer.Size = new System.Drawing.Size(117, 22);
            this.txtCijfer.TabIndex = 1;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(113, 245);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(173, 22);
            this.txtOutput.TabIndex = 2;
            // 
            // btnResultaat
            // 
            this.btnResultaat.Location = new System.Drawing.Point(113, 187);
            this.btnResultaat.Name = "btnResultaat";
            this.btnResultaat.Size = new System.Drawing.Size(147, 28);
            this.btnResultaat.TabIndex = 3;
            this.btnResultaat.Text = "Resultaat";
            this.btnResultaat.UseVisualStyleBackColor = true;
            this.btnResultaat.Click += new System.EventHandler(this.btnResultaat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 450);
            this.Controls.Add(this.btnResultaat);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtCijfer);
            this.Controls.Add(this.lblCijfer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCijfer;
        private System.Windows.Forms.TextBox txtCijfer;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnResultaat;
    }
}

