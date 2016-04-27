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
    public partial class ShowStepForm : Form
    {
        public string TestProjectName { get; set; }
        public string TestCaseName { get; set; }
        public string TestStep { get; set; }
        public ShowStepForm()
        {
            InitializeComponent();
        }

        private void ShowStepForm_Shown(object sender, EventArgs e)
        {
            var project = Registory.TestProjectRepogitory.SelectByName(TestProjectName);
            //testCaseListBox.Items.AddRange(projectList.SelectMany(D => D.List).Select(d => d.Title).ToArray());
            var a = project.List.Where(d => d.Title == TestCaseName).SelectMany(D => D.List).Select(d => d.Title).ToArray();
            stepsListBox.Items.AddRange(a);
        }

        private void stepsListBox_DoubleClick(object sender, EventArgs e)
        {
            SelectStep();
            using (var fm = new EditStepDetailForm())
            {
                fm.TestProjectName = TestProjectName;
                fm.TestCaseName = TestCaseName;
                fm.TestStep = TestStep;
                fm.ShowDialog();
            }
        }

        private void SelectStep()
        {
            if (stepsListBox.SelectedItem != null)
            {
                TestStep = stepsListBox.SelectedItem.ToString();
            }
        }
    }
}
