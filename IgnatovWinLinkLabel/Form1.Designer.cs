namespace IgnatovWinLinkLabel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pervaya = new System.Windows.Forms.LinkLabel();
            this.vtoraya = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // pervaya
            // 
            this.pervaya.AutoSize = true;
            this.pervaya.Location = new System.Drawing.Point(217, 154);
            this.pervaya.Name = "pervaya";
            this.pervaya.Size = new System.Drawing.Size(67, 15);
            this.pervaya.TabIndex = 0;
            this.pervaya.TabStop = true;
            this.pervaya.Text = "Open Form";
            this.pervaya.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.pervaya_LinkClicked);
            // 
            // vtoraya
            // 
            this.vtoraya.AutoSize = true;
            this.vtoraya.Location = new System.Drawing.Point(408, 154);
            this.vtoraya.Name = "vtoraya";
            this.vtoraya.Size = new System.Drawing.Size(58, 15);
            this.vtoraya.TabIndex = 1;
            this.vtoraya.TabStop = true;
            this.vtoraya.Text = "Microsoft";
            this.vtoraya.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.vtoraya_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vtoraya);
            this.Controls.Add(this.pervaya);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel pervaya;
        private System.Windows.Forms.LinkLabel vtoraya;
    }
}
