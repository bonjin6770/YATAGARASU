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
    public partial class AddTestCaseForm : Form
    {
        public string TestProjectName { get; set; }

        public AddTestCaseForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var project = Registory.TestProjectRepogitory.SelectByName(TestProjectName);
            project.AddTestCase(titleTextBox.Text, detailTextBox.Text);
            Registory.TestProjectRepogitory.Save(project);
            Close();
        }

        private void AddTestCaseForm_Shown(object sender, EventArgs e)
        {
            projectLabel.Text = TestProjectName;
        }

        private void AddTestCaseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
