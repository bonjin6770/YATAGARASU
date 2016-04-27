namespace YatagarasuWinFormApp
{
    partial class SelectProjectForm
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
            this.projectListBox = new System.Windows.Forms.ListBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // projectListBox
            // 
            this.projectListBox.FormattingEnabled = true;
            this.projectListBox.ItemHeight = 12;
            this.projectListBox.Location = new System.Drawing.Point(10, 16);
            this.projectListBox.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.projectListBox.Name = "projectListBox";
            this.projectListBox.Size = new System.Drawing.Size(292, 316);
            this.projectListBox.TabIndex = 0;
            this.projectListBox.DoubleClick += new System.EventHandler(this.projectListBox_DoubleClick);
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(223, 347);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 4;
            this.selectButton.Text = "選択";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // SelectProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 406);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.projectListBox);
            this.Name = "SelectProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "テストプロジェクトの選択";
            this.Shown += new System.EventHandler(this.SelectProject_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox projectListBox;
        private System.Windows.Forms.Button selectButton;
    }
}