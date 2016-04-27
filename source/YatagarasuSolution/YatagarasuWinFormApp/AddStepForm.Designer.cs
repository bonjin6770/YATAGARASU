namespace YatagarasuWinFormApp
{
    partial class AddStepForm
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
            this.detailTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(12, 22);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(631, 19);
            this.titleTextBox.TabIndex = 0;
            // 
            // detailTextBox
            // 
            this.detailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailTextBox.Location = new System.Drawing.Point(12, 68);
            this.detailTextBox.Multiline = true;
            this.detailTextBox.Name = "detailTextBox";
            this.detailTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.detailTextBox.Size = new System.Drawing.Size(631, 252);
            this.detailTextBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(568, 345);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "追加";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // AddStepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 380);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.detailTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Name = "AddStepForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "手順の追加";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox detailTextBox;
        private System.Windows.Forms.Button addButton;
    }
}