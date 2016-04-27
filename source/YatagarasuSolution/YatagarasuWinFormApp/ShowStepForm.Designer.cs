namespace YatagarasuWinFormApp
{
    partial class ShowStepForm
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
            this.stepsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // stepsListBox
            // 
            this.stepsListBox.FormattingEnabled = true;
            this.stepsListBox.ItemHeight = 12;
            this.stepsListBox.Location = new System.Drawing.Point(12, 12);
            this.stepsListBox.Name = "stepsListBox";
            this.stepsListBox.Size = new System.Drawing.Size(260, 244);
            this.stepsListBox.TabIndex = 0;
            this.stepsListBox.DoubleClick += new System.EventHandler(this.stepsListBox_DoubleClick);
            // 
            // ShowStepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.stepsListBox);
            this.Name = "ShowStepForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ShowStepForm";
            this.Shown += new System.EventHandler(this.ShowStepForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox stepsListBox;
    }
}