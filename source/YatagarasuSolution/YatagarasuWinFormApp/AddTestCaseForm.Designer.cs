namespace YatagarasuWinFormApp
{
    partial class AddTestCaseForm
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
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.detailTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.projectLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleTextBox
            // 
            this.titleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleTextBox.Font = new System.Drawing.Font("Consolas", 9F);
            this.titleTextBox.Location = new System.Drawing.Point(12, 72);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(605, 22);
            this.titleTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "タイトル";
            // 
            // detailTextBox
            // 
            this.detailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailTextBox.Location = new System.Drawing.Point(12, 120);
            this.detailTextBox.Multiline = true;
            this.detailTextBox.Name = "detailTextBox";
            this.detailTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.detailTextBox.Size = new System.Drawing.Size(605, 260);
            this.detailTextBox.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(542, 401);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "追加";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "詳細";
            // 
            // projectLabel
            // 
            this.projectLabel.AutoSize = true;
            this.projectLabel.Font = new System.Drawing.Font("MS UI Gothic", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.projectLabel.Location = new System.Drawing.Point(12, 10);
            this.projectLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.projectLabel.Name = "projectLabel";
            this.projectLabel.Size = new System.Drawing.Size(78, 27);
            this.projectLabel.TabIndex = 5;
            this.projectLabel.Text = "label3";
            // 
            // AddTestCaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 436);
            this.Controls.Add(this.projectLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.detailTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleTextBox);
            this.Name = "AddTestCaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "テストケース追加";
            this.Load += new System.EventHandler(this.AddTestCaseForm_Load);
            this.Shown += new System.EventHandler(this.AddTestCaseForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox detailTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label projectLabel;
    }
}