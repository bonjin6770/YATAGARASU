namespace YatagarasuWinFormApp
{
    partial class ShowTestCaseForm
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
            this.testCaseListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // testCaseListBox
            // 
            this.testCaseListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.testCaseListBox.FormattingEnabled = true;
            this.testCaseListBox.ItemHeight = 12;
            this.testCaseListBox.Location = new System.Drawing.Point(12, 12);
            this.testCaseListBox.Name = "testCaseListBox";
            this.testCaseListBox.Size = new System.Drawing.Size(412, 292);
            this.testCaseListBox.TabIndex = 0;
            this.testCaseListBox.DoubleClick += new System.EventHandler(this.testCaseListBox_DoubleClick);
            // 
            // ShowTestCaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 321);
            this.Controls.Add(this.testCaseListBox);
            this.Name = "ShowTestCaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "テストケースの表示";
            this.Shown += new System.EventHandler(this.ShowTestCaseForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox testCaseListBox;
    }
}