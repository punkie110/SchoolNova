
namespace YildizKurtLes1Boolean1
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
            this.txtResGroter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGetalD = new System.Windows.Forms.TextBox();
            this.txtGetalC = new System.Windows.Forms.TextBox();
            this.txtResKleiner = new System.Windows.Forms.TextBox();
            this.lblGelijkAan = new System.Windows.Forms.Label();
            this.txtGetalB = new System.Windows.Forms.TextBox();
            this.txtGetalA = new System.Windows.Forms.TextBox();
            this.BUTTON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResGroter
            // 
            this.txtResGroter.Location = new System.Drawing.Point(451, 48);
            this.txtResGroter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtResGroter.Name = "txtResGroter";
            this.txtResGroter.Size = new System.Drawing.Size(68, 22);
            this.txtResGroter.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "kleiner dan (<)";
            // 
            // txtGetalD
            // 
            this.txtGetalD.Location = new System.Drawing.Point(265, 81);
            this.txtGetalD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGetalD.Name = "txtGetalD";
            this.txtGetalD.Size = new System.Drawing.Size(68, 22);
            this.txtGetalD.TabIndex = 15;
            // 
            // txtGetalC
            // 
            this.txtGetalC.Location = new System.Drawing.Point(36, 81);
            this.txtGetalC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGetalC.Name = "txtGetalC";
            this.txtGetalC.Size = new System.Drawing.Size(68, 22);
            this.txtGetalC.TabIndex = 14;
            // 
            // txtResKleiner
            // 
            this.txtResKleiner.Location = new System.Drawing.Point(451, 81);
            this.txtResKleiner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtResKleiner.Name = "txtResKleiner";
            this.txtResKleiner.Size = new System.Drawing.Size(68, 22);
            this.txtResKleiner.TabIndex = 13;
            // 
            // lblGelijkAan
            // 
            this.lblGelijkAan.AutoSize = true;
            this.lblGelijkAan.Location = new System.Drawing.Point(132, 48);
            this.lblGelijkAan.Name = "lblGelijkAan";
            this.lblGelijkAan.Size = new System.Drawing.Size(86, 16);
            this.lblGelijkAan.TabIndex = 12;
            this.lblGelijkAan.Text = "groter dan (>)";
            // 
            // txtGetalB
            // 
            this.txtGetalB.Location = new System.Drawing.Point(265, 48);
            this.txtGetalB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGetalB.Name = "txtGetalB";
            this.txtGetalB.Size = new System.Drawing.Size(68, 22);
            this.txtGetalB.TabIndex = 11;
            // 
            // txtGetalA
            // 
            this.txtGetalA.Location = new System.Drawing.Point(36, 48);
            this.txtGetalA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGetalA.Name = "txtGetalA";
            this.txtGetalA.Size = new System.Drawing.Size(68, 22);
            this.txtGetalA.TabIndex = 10;
            this.txtGetalA.TextChanged += new System.EventHandler(this.hallo_TextChanged);
            // 
            // BUTTON
            // 
            this.BUTTON.Location = new System.Drawing.Point(356, 48);
            this.BUTTON.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BUTTON.Name = "BUTTON";
            this.BUTTON.Size = new System.Drawing.Size(77, 54);
            this.BUTTON.TabIndex = 9;
            this.BUTTON.Text = "Geef resultaat (=)";
            this.BUTTON.UseVisualStyleBackColor = true;
            this.BUTTON.Click += new System.EventHandler(this.BUTTON_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 178);
            this.Controls.Add(this.txtResGroter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGetalD);
            this.Controls.Add(this.txtGetalC);
            this.Controls.Add(this.txtResKleiner);
            this.Controls.Add(this.lblGelijkAan);
            this.Controls.Add(this.txtGetalB);
            this.Controls.Add(this.txtGetalA);
            this.Controls.Add(this.BUTTON);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResGroter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGetalD;
        private System.Windows.Forms.TextBox txtGetalC;
        private System.Windows.Forms.TextBox txtResKleiner;
        private System.Windows.Forms.Label lblGelijkAan;
        private System.Windows.Forms.TextBox txtGetalB;
        private System.Windows.Forms.TextBox txtGetalA;
        private System.Windows.Forms.Button BUTTON;
    }
}

