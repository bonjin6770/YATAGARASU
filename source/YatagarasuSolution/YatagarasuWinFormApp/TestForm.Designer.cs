namespace YatagarasuWinFormApp
{
    partial class TestForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.addTestCaseButton = new System.Windows.Forms.Button();
            this.makeTestProjectButton = new System.Windows.Forms.Button();
            this.selectProjectButton = new System.Windows.Forms.Button();
            this.selectedProjectTextBox = new System.Windows.Forms.TextBox();
            this.showTestCaseButton = new System.Windows.Forms.Button();
            this.selectedCaseTextBox = new System.Windows.Forms.TextBox();
            this.addStepButton = new System.Windows.Forms.Button();
            this.showStepButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.環境設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addTestCaseButton
            // 
            this.addTestCaseButton.Location = new System.Drawing.Point(204, 99);
            this.addTestCaseButton.Name = "addTestCaseButton";
            this.addTestCaseButton.Size = new System.Drawing.Size(186, 23);
            this.addTestCaseButton.TabIndex = 0;
            this.addTestCaseButton.Text = "テストケース追加";
            this.addTestCaseButton.UseVisualStyleBackColor = true;
            this.addTestCaseButton.Click += new System.EventHandler(this.addTestCaseButton_Click);
            // 
            // makeTestProjectButton
            // 
            this.makeTestProjectButton.Location = new System.Drawing.Point(12, 99);
            this.makeTestProjectButton.Name = "makeTestProjectButton";
            this.makeTestProjectButton.Size = new System.Drawing.Size(186, 23);
            this.makeTestProjectButton.TabIndex = 1;
            this.makeTestProjectButton.Text = "テストプロジェクト作成";
            this.makeTestProjectButton.UseVisualStyleBackColor = true;
            this.makeTestProjectButton.Click += new System.EventHandler(this.makeTestProjectButton_Click);
            // 
            // selectProjectButton
            // 
            this.selectProjectButton.Location = new System.Drawing.Point(12, 128);
            this.selectProjectButton.Name = "selectProjectButton";
            this.selectProjectButton.Size = new System.Drawing.Size(186, 23);
            this.selectProjectButton.TabIndex = 2;
            this.selectProjectButton.Text = "テストプロジェクトの選択";
            this.selectProjectButton.UseVisualStyleBackColor = true;
            this.selectProjectButton.Click += new System.EventHandler(this.selectProjectButton_Click);
            // 
            // selectedProjectTextBox
            // 
            this.selectedProjectTextBox.Location = new System.Drawing.Point(12, 40);
            this.selectedProjectTextBox.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.selectedProjectTextBox.Name = "selectedProjectTextBox";
            this.selectedProjectTextBox.Size = new System.Drawing.Size(570, 19);
            this.selectedProjectTextBox.TabIndex = 3;
            // 
            // showTestCaseButton
            // 
            this.showTestCaseButton.Location = new System.Drawing.Point(204, 128);
            this.showTestCaseButton.Name = "showTestCaseButton";
            this.showTestCaseButton.Size = new System.Drawing.Size(186, 23);
            this.showTestCaseButton.TabIndex = 4;
            this.showTestCaseButton.Text = "テストケース表示";
            this.showTestCaseButton.UseVisualStyleBackColor = true;
            this.showTestCaseButton.Click += new System.EventHandler(this.showTestCaseButton_Click);
            // 
            // selectedCaseTextBox
            // 
            this.selectedCaseTextBox.Location = new System.Drawing.Point(12, 63);
            this.selectedCaseTextBox.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.selectedCaseTextBox.Name = "selectedCaseTextBox";
            this.selectedCaseTextBox.Size = new System.Drawing.Size(570, 19);
            this.selectedCaseTextBox.TabIndex = 5;
            // 
            // addStepButton
            // 
            this.addStepButton.Location = new System.Drawing.Point(396, 99);
            this.addStepButton.Name = "addStepButton";
            this.addStepButton.Size = new System.Drawing.Size(186, 23);
            this.addStepButton.TabIndex = 6;
            this.addStepButton.Text = "テスト手順追加";
            this.addStepButton.UseVisualStyleBackColor = true;
            this.addStepButton.Click += new System.EventHandler(this.addStepButton_Click);
            // 
            // showStepButton
            // 
            this.showStepButton.Location = new System.Drawing.Point(396, 128);
            this.showStepButton.Name = "showStepButton";
            this.showStepButton.Size = new System.Drawing.Size(186, 23);
            this.showStepButton.TabIndex = 7;
            this.showStepButton.Text = "テスト手順表示";
            this.showStepButton.UseVisualStyleBackColor = true;
            this.showStepButton.Click += new System.EventHandler(this.showStepButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 316);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(604, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.ヘルプToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(604, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.環境設定ToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.ファイルToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 環境設定ToolStripMenuItem
            // 
            this.環境設定ToolStripMenuItem.Name = "環境設定ToolStripMenuItem";
            this.環境設定ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemcomma)));
            this.環境設定ToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.環境設定ToolStripMenuItem.Text = "環境設定";
            // 
            // ヘルプToolStripMenuItem
            // 
            this.ヘルプToolStripMenuItem.Name = "ヘルプToolStripMenuItem";
            this.ヘルプToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ヘルプToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 338);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.showStepButton);
            this.Controls.Add(this.addStepButton);
            this.Controls.Add(this.selectedCaseTextBox);
            this.Controls.Add(this.showTestCaseButton);
            this.Controls.Add(this.selectedProjectTextBox);
            this.Controls.Add(this.selectProjectButton);
            this.Controls.Add(this.makeTestProjectButton);
            this.Controls.Add(this.addTestCaseButton);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TestForm";
            this.Text = "八咫烏";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addTestCaseButton;
        private System.Windows.Forms.Button makeTestProjectButton;
        private System.Windows.Forms.Button selectProjectButton;
        private System.Windows.Forms.TextBox selectedProjectTextBox;
        private System.Windows.Forms.Button showTestCaseButton;
        private System.Windows.Forms.TextBox selectedCaseTextBox;
        private System.Windows.Forms.Button addStepButton;
        private System.Windows.Forms.Button showStepButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 環境設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

