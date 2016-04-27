using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YatagarasuLibrary;

namespace YatagarasuWinFormApp
{
    public partial class MakeTestProjectForm : Form
    {
        public MakeTestProjectForm()
        {
            InitializeComponent();
        }

        private void makeButton_Click(object sender, EventArgs e)
        {
            var project = Registory.TestProjectFactory.Create(projectNameTextBox.Text);
            Registory.TestProjectRepogitory.Add(project);
            Close();
        }
    }
}
