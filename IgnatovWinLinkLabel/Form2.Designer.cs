namespace IgnatovWinLinkLabel
{
    partial class Form2
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
            this.acceptBut = new System.Windows.Forms.Button();
            this.cancelBut = new System.Windows.Forms.Button();
            this.tex1 = new System.Windows.Forms.TextBox();
            this.tex2 = new System.Windows.Forms.TextBox();
            this.lab1 = new System.Windows.Forms.Label();
            this.lab2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // acceptBut
            // 
            this.acceptBut.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.acceptBut.Location = new System.Drawing.Point(603, 252);
            this.acceptBut.Name = "acceptBut";
            this.acceptBut.Size = new System.Drawing.Size(75, 23);
            this.acceptBut.TabIndex = 4;
            this.acceptBut.Text = "Accept";
            this.acceptBut.UseVisualStyleBackColor = true;
            // 
            // cancelBut
            // 
            this.cancelBut.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBut.Location = new System.Drawing.Point(603, 281);
            this.cancelBut.Name = "cancelBut";
            this.cancelBut.Size = new System.Drawing.Size(75, 23);
            this.cancelBut.TabIndex = 5;
            this.cancelBut.Text = "Cancel";
            this.cancelBut.UseVisualStyleBackColor = true;
            // 
            // tex1
            // 
            this.tex1.Location = new System.Drawing.Point(276, 74);
            this.tex1.Name = "tex1";
            this.tex1.Size = new System.Drawing.Size(100, 23);
            this.tex1.TabIndex = 1;
            // 
            // tex2
            // 
            this.tex2.Location = new System.Drawing.Point(382, 74);
            this.tex2.Name = "tex2";
            this.tex2.Size = new System.Drawing.Size(100, 23);
            this.tex2.TabIndex = 3;
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(276, 56);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(64, 15);
            this.lab1.TabIndex = 0;
            this.lab1.Text = "First Name";
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.Location = new System.Drawing.Point(382, 56);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(63, 15);
            this.lab2.TabIndex = 2;
            this.lab2.Text = "Last Name";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 308);
            this.Controls.Add(this.lab2);
            this.Controls.Add(this.lab1);
            this.Controls.Add(this.tex2);
            this.Controls.Add(this.tex1);
            this.Controls.Add(this.cancelBut);
            this.Controls.Add(this.acceptBut);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button acceptBut;
        private System.Windows.Forms.Button cancelBut;
        internal System.Windows.Forms.TextBox tex1;
        internal System.Windows.Forms.TextBox tex2;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Label lab2;
    }
}