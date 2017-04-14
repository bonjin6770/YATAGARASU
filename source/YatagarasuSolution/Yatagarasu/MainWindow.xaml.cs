using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Yatagarasu
{

    // これをやりたい
    // http://thinkami.hatenablog.com/entry/2014/09/19/061102#f-26e13bcb

    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // HotKey設定
            var hotkey = new HotKeyRegister(MOD_KEY.CONTROL_SHIFT, System.Windows.Forms.Keys.Space, this);
            hotkey.HotKeyPressed += (sender) =>
            {
                this.Show();
                this.WindowState = WindowState.Normal;
                this.Activate();
            };

            // コマンドのリスト取得
            DomainRegistory.LoadCommandList();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (_isQuit) { return; }

            e.Cancel = true;
            this.ShowInTaskbar = false;
            this.Hide();
        }

        private bool _isQuit = false;
        private void autoCompleteBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                var command = autoCompleteBox.Text;
                if (command.ToLower() == "quit")
                {
                    _isQuit = true;
                    this.Close();
                    return;
                }

                if(command.ToLower() == "version")
                {
                    //自分自身のバージョン情報を取得する
                    System.Diagnostics.FileVersionInfo ver =
                        System.Diagnostics.FileVersionInfo.GetVersionInfo(
                        System.Reflection.Assembly.GetExecutingAssembly().Location);

                    MessageBox.Show("Virsion " + ver.ProductVersion);
                    this.Close();
                    return;
                }

                if (command.ToLower() == "Config.Reload")
                {
                    DomainRegistory.LoadCommandList();
                    this.Close();
                    return;
                }

                if (DomainRegistory.CommandList.IsExists(command))
                {
                    DomainRegistory.CommandList.Execute(command);
                    autoCompleteBox.Text = String.Empty;
                    this.Close();
                }
            }

            if (e.Key == Key.Escape)
            {
                this.Close();
            }
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            FocusAutoCompleteBox();
        }

        private void FocusAutoCompleteBox()
        {
            // http://stackoverflow.com/questions/3572299/autocompletebox-focus-in-wpf
            Keyboard.Focus(autoCompleteBox);
            autoCompleteBox.MoveFocus(new TraversalRequest(FocusNavigationDirection.Next));
        }
    }
}
