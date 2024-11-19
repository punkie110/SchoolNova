namespace JustinMunkOperatorenBooleans2
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
            this.lblGelijkAan = new System.Windows.Forms.Label();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.txtInput1 = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnResultaat
            // 
            this.btnResultaat.Location = new System.Drawing.Point(268, 245);
            this.btnResultaat.Name = "btnResultaat";
            this.btnResultaat.Size = new System.Drawing.Size(269, 45);
            this.btnResultaat.TabIndex = 0;
            this.btnResultaat.Text = "Resultaat";
            this.btnResultaat.UseVisualStyleBackColor = true;
            this.btnResultaat.Click += new System.EventHandler(this.btnResultaat_Click);
            // 
            // lblGelijkAan
            // 
            this.lblGelijkAan.AutoSize = true;
            this.lblGelijkAan.Location = new System.Drawing.Point(351, 145);
            this.lblGelijkAan.Name = "lblGelijkAan";
            this.lblGelijkAan.Size = new System.Drawing.Size(103, 16);
            this.lblGelijkAan.TabIndex = 1;
            this.lblGelijkAan.Text = "Is gelijk aan (==)";
            // 
            // txtInput2
            // 
            this.txtInput2.Location = new System.Drawing.Point(541, 139);
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(161, 22);
            this.txtInput2.TabIndex = 2;
            // 
            // txtInput1
            // 
            this.txtInput1.Location = new System.Drawing.Point(117, 142);
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.Size = new System.Drawing.Size(161, 22);
            this.txtInput1.TabIndex = 3;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(268, 338);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(269, 22);
            this.txtOutput.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput1);
            this.Controls.Add(this.txtInput2);
            this.Controls.Add(this.lblGelijkAan);
            this.Controls.Add(this.btnResultaat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResultaat;
        private System.Windows.Forms.Label lblGelijkAan;
        private System.Windows.Forms.TextBox txtInput2;
        private System.Windows.Forms.TextBox txtInput1;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

