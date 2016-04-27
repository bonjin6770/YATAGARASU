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
    public partial class AddStepForm : Form
    {
        public string TestProjectName { get; set; }
        public string TestCaseName { get; set; }
        public AddStepForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var project = Registory.TestProjectRepogitory.SelectByName(TestProjectName);
            var testCase = project.List.Where(d => d.Title == TestCaseName).Select(d => d).First();
            testCase.AddStep(titleTextBox.Text, detailTextBox.Lines.ToList());
            //project.AddTestCase(titleTextBox.Text, detailTextBox.Text);
            Registory.TestProjectRepogitory.Save(project);
            Close();
        }
    }
}
