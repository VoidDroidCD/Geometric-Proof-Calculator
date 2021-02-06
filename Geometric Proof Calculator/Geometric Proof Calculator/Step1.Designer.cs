namespace Geometric_Proof_Calculator
{
    partial class step1
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
            this.figureNameTB = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.text2 = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.warnings = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GIVENS = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // figureNameTB
            // 
            this.figureNameTB.Location = new System.Drawing.Point(427, 37);
            this.figureNameTB.MaxLength = 4;
            this.figureNameTB.Name = "figureNameTB";
            this.figureNameTB.Size = new System.Drawing.Size(144, 20);
            this.figureNameTB.TabIndex = 0;
            this.figureNameTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // submit
            // 
            this.submit.AccessibleName = "submit";
            this.submit.Location = new System.Drawing.Point(464, 63);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 2;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Location = new System.Drawing.Point(12, 9);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(162, 13);
            this.text2.TabIndex = 3;
            this.text2.Text = "Created by Coleman E. Donahue";
            // 
            // info
            // 
            this.info.AccessibleDescription = "info";
            this.info.AccessibleName = "info";
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(12, 497);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(98, 13);
            this.info.TabIndex = 4;
            this.info.Text = "Current information:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(412, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ENTER FIGURE NAME (Eg. ABCD)";
            // 
            // warnings
            // 
            this.warnings.AutoSize = true;
            this.warnings.Location = new System.Drawing.Point(12, 411);
            this.warnings.Name = "warnings";
            this.warnings.Size = new System.Drawing.Size(143, 13);
            this.warnings.TabIndex = 6;
            this.warnings.Text = "Warnings: All systems online.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(630, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "SELECT GIVENS";
            // 
            // GIVENS
            // 
            this.GIVENS.FormattingEnabled = true;
            this.GIVENS.Location = new System.Drawing.Point(613, 37);
            this.GIVENS.Name = "GIVENS";
            this.GIVENS.Size = new System.Drawing.Size(120, 498);
            this.GIVENS.TabIndex = 8;
            // 
            // step1
            // 
            this.AcceptButton = this.submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 564);
            this.Controls.Add(this.GIVENS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.warnings);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.info);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.figureNameTB);
            this.Name = "step1";
            this.Text = "Step 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox figureNameTB;

        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.Label info;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label warnings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox GIVENS;
    }
}

