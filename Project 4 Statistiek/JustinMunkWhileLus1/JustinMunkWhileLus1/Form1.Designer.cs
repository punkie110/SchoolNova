namespace JustinMunkWhileLus1
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
            this.lblWhileLus = new System.Windows.Forms.Label();
            this.lbxCijfers = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWhileLus
            // 
            this.lblWhileLus.AutoSize = true;
            this.lblWhileLus.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhileLus.ForeColor = System.Drawing.Color.Red;
            this.lblWhileLus.Location = new System.Drawing.Point(70, 35);
            this.lblWhileLus.Name = "lblWhileLus";
            this.lblWhileLus.Size = new System.Drawing.Size(214, 52);
            this.lblWhileLus.TabIndex = 0;
            this.lblWhileLus.Text = "While Lus";
            // 
            // lbxCijfers
            // 
            this.lbxCijfers.FormattingEnabled = true;
            this.lbxCijfers.ItemHeight = 16;
            this.lbxCijfers.Location = new System.Drawing.Point(79, 115);
            this.lbxCijfers.Name = "lbxCijfers";
            this.lbxCijfers.Size = new System.Drawing.Size(205, 212);
            this.lbxCijfers.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(24, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(329, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "Geef Statistiek";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(365, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbxCijfers);
            this.Controls.Add(this.lblWhileLus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWhileLus;
        private System.Windows.Forms.ListBox lbxCijfers;
        private System.Windows.Forms.Button button1;
    }
}

