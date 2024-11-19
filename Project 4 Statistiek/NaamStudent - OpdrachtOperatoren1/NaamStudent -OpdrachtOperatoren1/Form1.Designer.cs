
namespace NaamStudent___Les2Operatoren1
{
    partial class frmYildizKurtOpdrachtOperatoren1
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
            this.rdbAftrekken = new System.Windows.Forms.RadioButton();
            this.rdbOptellen = new System.Windows.Forms.RadioButton();
            this.lbxResultaten = new System.Windows.Forms.ListBox();
            this.lblTweede = new System.Windows.Forms.Label();
            this.lblBegin = new System.Windows.Forms.Label();
            this.txtGetal2 = new System.Windows.Forms.TextBox();
            this.txtGetal1 = new System.Windows.Forms.TextBox();
            this.btnResultaat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbAftrekken
            // 
            this.rdbAftrekken.AutoSize = true;
            this.rdbAftrekken.Location = new System.Drawing.Point(284, 167);
            this.rdbAftrekken.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbAftrekken.Name = "rdbAftrekken";
            this.rdbAftrekken.Size = new System.Drawing.Size(32, 20);
            this.rdbAftrekken.TabIndex = 15;
            this.rdbAftrekken.TabStop = true;
            this.rdbAftrekken.Text = "-";
            this.rdbAftrekken.UseVisualStyleBackColor = true;
            // 
            // rdbOptellen
            // 
            this.rdbOptellen.AutoSize = true;
            this.rdbOptellen.Location = new System.Drawing.Point(209, 167);
            this.rdbOptellen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbOptellen.Name = "rdbOptellen";
            this.rdbOptellen.Size = new System.Drawing.Size(35, 20);
            this.rdbOptellen.TabIndex = 14;
            this.rdbOptellen.TabStop = true;
            this.rdbOptellen.Text = "+";
            this.rdbOptellen.UseVisualStyleBackColor = true;
            this.rdbOptellen.CheckedChanged += new System.EventHandler(this.rbnOptellen_CheckedChanged);
            // 
            // lbxResultaten
            // 
            this.lbxResultaten.FormattingEnabled = true;
            this.lbxResultaten.ItemHeight = 16;
            this.lbxResultaten.Location = new System.Drawing.Point(209, 242);
            this.lbxResultaten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbxResultaten.Name = "lbxResultaten";
            this.lbxResultaten.Size = new System.Drawing.Size(116, 132);
            this.lbxResultaten.TabIndex = 13;
            // 
            // lblTweede
            // 
            this.lblTweede.AutoSize = true;
            this.lblTweede.Location = new System.Drawing.Point(105, 135);
            this.lblTweede.Name = "lblTweede";
            this.lblTweede.Size = new System.Drawing.Size(90, 16);
            this.lblTweede.TabIndex = 12;
            this.lblTweede.Text = "Tweede getal";
            // 
            // lblBegin
            // 
            this.lblBegin.AutoSize = true;
            this.lblBegin.Location = new System.Drawing.Point(105, 95);
            this.lblBegin.Name = "lblBegin";
            this.lblBegin.Size = new System.Drawing.Size(79, 16);
            this.lblBegin.TabIndex = 11;
            this.lblBegin.Text = "Eerste getal";
            // 
            // txtGetal2
            // 
            this.txtGetal2.Location = new System.Drawing.Point(209, 132);
            this.txtGetal2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGetal2.Name = "txtGetal2";
            this.txtGetal2.Size = new System.Drawing.Size(116, 22);
            this.txtGetal2.TabIndex = 10;
            // 
            // txtGetal1
            // 
            this.txtGetal1.Location = new System.Drawing.Point(209, 95);
            this.txtGetal1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGetal1.Name = "txtGetal1";
            this.txtGetal1.Size = new System.Drawing.Size(116, 22);
            this.txtGetal1.TabIndex = 9;
            // 
            // btnResultaat
            // 
            this.btnResultaat.Location = new System.Drawing.Point(209, 198);
            this.btnResultaat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResultaat.Name = "btnResultaat";
            this.btnResultaat.Size = new System.Drawing.Size(115, 34);
            this.btnResultaat.TabIndex = 8;
            this.btnResultaat.Text = "Geef resultaat";
            this.btnResultaat.UseVisualStyleBackColor = true;
            this.btnResultaat.Click += new System.EventHandler(this.btnResultaat_Click);
            // 
            // frmYildizKurtOpdrachtOperatoren1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 406);
            this.Controls.Add(this.rdbAftrekken);
            this.Controls.Add(this.rdbOptellen);
            this.Controls.Add(this.lbxResultaten);
            this.Controls.Add(this.lblTweede);
            this.Controls.Add(this.lblBegin);
            this.Controls.Add(this.txtGetal2);
            this.Controls.Add(this.txtGetal1);
            this.Controls.Add(this.btnResultaat);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmYildizKurtOpdrachtOperatoren1";
            this.Text = "Yildiz Kurt - OpdrachtOperatoren1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbAftrekken;
        private System.Windows.Forms.RadioButton rdbOptellen;
        private System.Windows.Forms.ListBox lbxResultaten;
        private System.Windows.Forms.Label lblTweede;
        private System.Windows.Forms.Label lblBegin;
        private System.Windows.Forms.TextBox txtGetal2;
        private System.Windows.Forms.TextBox txtGetal1;
        private System.Windows.Forms.Button btnResultaat;
    }
}

