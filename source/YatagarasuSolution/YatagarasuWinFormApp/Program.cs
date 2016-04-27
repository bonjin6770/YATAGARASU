using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using YatagarasuLibrary;

namespace YatagarasuWinFormApp
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Registory.TestProjectRepogitory = new TestProjectRepogitory();
            Registory.TestProjectFactory = new TestProjectFactory();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TestForm());
        }
    }
}
