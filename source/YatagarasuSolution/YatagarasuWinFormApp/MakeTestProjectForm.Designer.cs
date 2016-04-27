namespace YatagarasuWinFormApp
{
    partial class MakeTestProjectForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.projectNameTextBox = new System.Windows.Forms.TextBox();
            this.makeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "テストプロジェクト名";
            // 
            // projectNameTextBox
            // 
            this.projectNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.projectNameTextBox.Font = new System.Drawing.Font("Consolas", 9F);
            this.projectNameTextBox.Location = new System.Drawing.Point(4, 25);
            this.projectNameTextBox.Name = "projectNameTextBox";
            this.projectNameTextBox.Size = new System.Drawing.Size(558, 22);
            this.projectNameTextBox.TabIndex = 2;
            // 
            // makeButton
            // 
            this.makeButton.Location = new System.Drawing.Point(485, 62);
            this.makeButton.Name = "makeButton";
            this.makeButton.Size = new System.Drawing.Size(75, 23);
            this.makeButton.TabIndex = 4;
            this.makeButton.Text = "作成";
            this.makeButton.UseVisualStyleBackColor = true;
            this.makeButton.Click += new System.EventHandler(this.makeButton_Click);
            // 
            // MakeTestProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 97);
            this.Controls.Add(this.makeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.projectNameTextBox);
            this.Name = "MakeTestProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "テストプロジェクトの作成";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox projectNameTextBox;
        private System.Windows.Forms.Button makeButton;
    }
}