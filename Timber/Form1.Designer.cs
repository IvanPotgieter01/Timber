namespace Timber
{
    partial class Timber
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
            this.lboxResult = new System.Windows.Forms.ListBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbLength = new System.Windows.Forms.TextBox();
            this.tbBreadth = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblBreadth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lboxResult
            // 
            this.lboxResult.FormattingEnabled = true;
            this.lboxResult.Location = new System.Drawing.Point(277, 30);
            this.lboxResult.Margin = new System.Windows.Forms.Padding(2);
            this.lboxResult.Name = "lboxResult";
            this.lboxResult.Size = new System.Drawing.Size(302, 147);
            this.lboxResult.TabIndex = 11;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(55, 136);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(184, 43);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tbLength
            // 
            this.tbLength.Location = new System.Drawing.Point(136, 77);
            this.tbLength.Margin = new System.Windows.Forms.Padding(2);
            this.tbLength.Name = "tbLength";
            this.tbLength.Size = new System.Drawing.Size(92, 20);
            this.tbLength.TabIndex = 9;
            // 
            // tbBreadth
            // 
            this.tbBreadth.Location = new System.Drawing.Point(136, 30);
            this.tbBreadth.Margin = new System.Windows.Forms.Padding(2);
            this.tbBreadth.Name = "tbBreadth";
            this.tbBreadth.Size = new System.Drawing.Size(92, 20);
            this.tbBreadth.TabIndex = 8;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(54, 77);
            this.lblLength.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(40, 13);
            this.lblLength.TabIndex = 7;
            this.lblLength.Text = "Length";
            // 
            // lblBreadth
            // 
            this.lblBreadth.AutoSize = true;
            this.lblBreadth.Location = new System.Drawing.Point(54, 30);
            this.lblBreadth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBreadth.Name = "lblBreadth";
            this.lblBreadth.Size = new System.Drawing.Size(44, 13);
            this.lblBreadth.TabIndex = 6;
            this.lblBreadth.Text = "Breadth";
            // 
            // Timber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 226);
            this.Controls.Add(this.lboxResult);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbLength);
            this.Controls.Add(this.tbBreadth);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblBreadth);
            this.Name = "Timber";
            this.Text = "Timber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboxResult;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tbLength;
        private System.Windows.Forms.TextBox tbBreadth;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblBreadth;
    }
}

