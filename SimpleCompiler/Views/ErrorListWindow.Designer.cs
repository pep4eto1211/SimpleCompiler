namespace SimpleCompiler.Views
{
    partial class ErrorListWindow
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
            this.errorsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // errorsListBox
            // 
            this.errorsListBox.FormattingEnabled = true;
            this.errorsListBox.Location = new System.Drawing.Point(12, 12);
            this.errorsListBox.Name = "errorsListBox";
            this.errorsListBox.Size = new System.Drawing.Size(746, 238);
            this.errorsListBox.TabIndex = 0;
            // 
            // ErrorListWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 261);
            this.Controls.Add(this.errorsListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ErrorListWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ErrorListWindow";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox errorsListBox;
    }
}