namespace Justin_Munk_While_Lus_2
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
            this.lblWhileLus2 = new System.Windows.Forms.Label();
            this.lbxCijfersNulTotNegen = new System.Windows.Forms.ListBox();
            this.lbxCijfersNegentigTotHonderd = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWhileLus2
            // 
            this.lblWhileLus2.AutoSize = true;
            this.lblWhileLus2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhileLus2.ForeColor = System.Drawing.Color.Red;
            this.lblWhileLus2.Location = new System.Drawing.Point(238, 36);
            this.lblWhileLus2.Name = "lblWhileLus2";
            this.lblWhileLus2.Size = new System.Drawing.Size(276, 54);
            this.lblWhileLus2.TabIndex = 0;
            this.lblWhileLus2.Text = "While Lus 2";
            // 
            // lbxCijfersNulTotNegen
            // 
            this.lbxCijfersNulTotNegen.FormattingEnabled = true;
            this.lbxCijfersNulTotNegen.ItemHeight = 16;
            this.lbxCijfersNulTotNegen.Location = new System.Drawing.Point(121, 105);
            this.lbxCijfersNulTotNegen.Name = "lbxCijfersNulTotNegen";
            this.lbxCijfersNulTotNegen.Size = new System.Drawing.Size(180, 212);
            this.lbxCijfersNulTotNegen.TabIndex = 1;
            // 
            // lbxCijfersNegentigTotHonderd
            // 
            this.lbxCijfersNegentigTotHonderd.FormattingEnabled = true;
            this.lbxCijfersNegentigTotHonderd.ItemHeight = 16;
            this.lbxCijfersNegentigTotHonderd.Location = new System.Drawing.Point(463, 105);
            this.lbxCijfersNegentigTotHonderd.Name = "lbxCijfersNegentigTotHonderd";
            this.lbxCijfersNegentigTotHonderd.Size = new System.Drawing.Size(183, 212);
            this.lbxCijfersNegentigTotHonderd.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 58);
            this.button1.TabIndex = 3;
            this.button1.Text = "Geef Statistiek 1 tot 10";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(455, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 58);
            this.button2.TabIndex = 4;
            this.button2.Text = "Geef statistiek 90 tot 100";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(765, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbxCijfersNegentigTotHonderd);
            this.Controls.Add(this.lbxCijfersNulTotNegen);
            this.Controls.Add(this.lblWhileLus2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWhileLus2;
        private System.Windows.Forms.ListBox lbxCijfersNulTotNegen;
        private System.Windows.Forms.ListBox lbxCijfersNegentigTotHonderd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

