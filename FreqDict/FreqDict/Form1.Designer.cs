namespace FreqDict
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonExe = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonExe
            // 
            this.buttonExe.Location = new System.Drawing.Point(11, 29);
            this.buttonExe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonExe.Name = "buttonExe";
            this.buttonExe.Size = new System.Drawing.Size(228, 28);
            this.buttonExe.TabIndex = 1;
            this.buttonExe.Text = "Exe";
            this.buttonExe.UseVisualStyleBackColor = true;
            this.buttonExe.Click += new System.EventHandler(this.buttonExe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 99);
            this.Controls.Add(this.buttonExe);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Frequency dictionary";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonExe;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

