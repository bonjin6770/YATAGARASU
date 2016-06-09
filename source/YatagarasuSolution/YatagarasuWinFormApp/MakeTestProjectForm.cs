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
        public TestProject NewProject { get; private set; }

        public MakeTestProjectForm()
        {
            InitializeComponent();
        }

        private void makeButton_Click(object sender, EventArgs e)
        {
            NewProject = Registory.TestProjectFactory.CreateNew(projectNameTextBox.Text);
            Registory.TestProjectRepogitory.Add(NewProject);
            Close();
        }
    }
}
