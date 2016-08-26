namespace SimpleCompiler
{
    partial class ReferencesConfigWindow
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
            this.txtNewReference = new System.Windows.Forms.TextBox();
            this.btnAddReference = new System.Windows.Forms.Button();
            this.referencesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtNewReference
            // 
            this.txtNewReference.Location = new System.Drawing.Point(12, 14);
            this.txtNewReference.Name = "txtNewReference";
            this.txtNewReference.Size = new System.Drawing.Size(274, 20);
            this.txtNewReference.TabIndex = 0;
            // 
            // btnAddReference
            // 
            this.btnAddReference.Location = new System.Drawing.Point(292, 12);
            this.btnAddReference.Name = "btnAddReference";
            this.btnAddReference.Size = new System.Drawing.Size(52, 23);
            this.btnAddReference.TabIndex = 1;
            this.btnAddReference.Text = "Add";
            this.btnAddReference.UseVisualStyleBackColor = true;
            this.btnAddReference.Click += new System.EventHandler(this.btnAddReference_Click);
            // 
            // referencesListBox
            // 
            this.referencesListBox.FormattingEnabled = true;
            this.referencesListBox.Location = new System.Drawing.Point(12, 40);
            this.referencesListBox.Name = "referencesListBox";
            this.referencesListBox.Size = new System.Drawing.Size(332, 381);
            this.referencesListBox.TabIndex = 2;
            // 
            // ReferencesConfigWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 438);
            this.Controls.Add(this.referencesListBox);
            this.Controls.Add(this.btnAddReference);
            this.Controls.Add(this.txtNewReference);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReferencesConfigWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "References configuration";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ReferencesConfigWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewReference;
        private System.Windows.Forms.Button btnAddReference;
        private System.Windows.Forms.ListBox referencesListBox;
    }
}