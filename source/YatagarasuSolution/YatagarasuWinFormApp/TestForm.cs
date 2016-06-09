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
    public partial class TestForm : Form
    {

        private List<YatagarasuLibrary.TestProject> _projectList = new List<YatagarasuLibrary.TestProject>();
        public TestForm()
        {
            InitializeComponent();
        }

        private void addTestCaseButton_Click(object sender, EventArgs e)
        {
            if (!IsSelectedProject())
            {
                MessageBox.Show("プロジェクトを選択してください");
                return;
            }
            using (var fm = new AddTestCaseForm())
            {
                fm.TestProjectName = selectedProjectTextBox.Text;
                fm.ShowDialog();
            }
        }

        private bool IsSelectedProject()
        {
            return !string.IsNullOrWhiteSpace(selectedProjectTextBox.Text);
        }

        private bool IsSelectedCase()
        {
            return !string.IsNullOrWhiteSpace(selectedCaseTextBox.Text);
        }

        private void makeTestProjectButton_Click(object sender, EventArgs e)
        {
            using (var fm = new MakeTestProjectForm())
            {
                fm.ShowDialog();
            }
        }

        private void selectProjectButton_Click(object sender, EventArgs e)
        {
            string selectedProject = string.Empty;
            using (var fm = new SelectProjectForm())
            {
                fm.ShowDialog();
                selectedProject = fm.SelectedProject;
            }

            if (string.IsNullOrWhiteSpace(selectedProject))
            {
                return;
            }

            selectedProjectTextBox.Text = selectedProject;
        }

        private void showTestCaseButton_Click(object sender, EventArgs e)
        {
            if (!IsSelectedProject())
            {
                MessageBox.Show("プロジェクトを選択してください");
                return;
            }

            string selectedCase = String.Empty;
            using (var fm = new ShowTestCaseForm())
            {
                fm.SelectedProject = selectedProjectTextBox.Text;
                fm.ShowDialog();
                selectedCase = fm.SelectedCase;
            }

            if (string.IsNullOrWhiteSpace(selectedCase))
            {
                return;
            }

            selectedCaseTextBox.Text = selectedCase;

        }

        private void addStepButton_Click(object sender, EventArgs e)
        {
            if (!IsSelectedProject())
            {
                MessageBox.Show("プロジェクトを選択してください");
                return;
            }

            if (!IsSelectedCase())
            {
                MessageBox.Show("テストケースを選択してください");
                return;
            }

            using (var fm = new AddStepForm())
            {
                fm.TestProjectName = selectedProjectTextBox.Text;
                fm.TestCaseName = selectedCaseTextBox.Text;
                fm.ShowDialog();
            }
        }

        private void showStepButton_Click(object sender, EventArgs e)
        {
            if (!IsSelectedProject())
            {
                MessageBox.Show("プロジェクトを選択してください");
                return;
            }

            if (!IsSelectedCase())
            {
                MessageBox.Show("テストケースを選択してください");
                return;
            }

            using (var fm = new ShowStepForm())
            {
                fm.TestProjectName = selectedProjectTextBox.Text;
                fm.TestCaseName = selectedCaseTextBox.Text;
                fm.ShowDialog();
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void TestForm_Shown(object sender, EventArgs e)
        {
            _projectList = YatagarasuLibrary.Registory.TestProjectRepogitory.SelectAll();
            foreach (var p in _projectList)
            {
                testProjectComboBox.Items.Add(p);
            }

            testProjectComboBox.SelectedIndex = 0;
        }

        private void testProjectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (testProjectComboBox.SelectedItem == null) { return; }
            var selectedProject = testProjectComboBox.SelectedItem as YatagarasuLibrary.TestProject;
            foreach (var c in selectedProject.List)
            {
                testCaseComboBox.Items.Add(c);
            }
        }

        private void testCaseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (testProjectComboBox.SelectedItem == null) { return; }
            if (testCaseComboBox.SelectedItem == null) { return; }
            var testcase = testCaseComboBox.SelectedItem as TestCase;
            foreach (var c in testcase.List)
            {
                testStepComboBox.Items.Add(c);
            }

        }

        private void testStepComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (testProjectComboBox.SelectedItem == null) { return; }
            if (testCaseComboBox.SelectedItem == null) { return; }
            if (testStepComboBox.SelectedItem == null) { return; }
            var teststep = testStepComboBox.SelectedItem as TestStep;
            testStepTextBox.Lines = teststep.Detail.ToArray();
        }
    }
}
