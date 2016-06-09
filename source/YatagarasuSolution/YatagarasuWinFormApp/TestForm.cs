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
        private List<TestProject> _projectList = new List<TestProject>();

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
            LoadTestProjects();
        }

        private void LoadTestProjects()
        {
            treeView1.Nodes.Clear();

            _projectList = YatagarasuLibrary.Registory.TestProjectRepogitory.SelectAll();
            foreach (var p in _projectList)
            {
                testProjectComboBox.Items.Add(p);

            }
            testProjectComboBox.SelectedIndex = 0;

            treeView1.Nodes.AddRange(ProjectToTreeNode().ToArray());
        }

        private List<TreeNode> ProjectToTreeNode()
        {
            var root = new List<TreeNode>();
            foreach (var p in _projectList)
            {
                var ptn = new TreeNode();
                ptn.Name = p.Id.ToString();
                ptn.Text = p.Name;
                foreach (var c in p.List)
                {
                    var ctn = new TreeNode();

                    var contextmenustrip = new ContextMenuStrip();
                    var i = new ToolStripMenuItem();
                    i.Text = "add test step";
                    i.Click += changeDirectionButton_Click;
                    contextmenustrip.Items.Add(i);
                    ctn.ContextMenuStrip = contextmenustrip;

                    ctn.Name = c.Id.ToString();
                    ctn.Text = c.Title;
                    foreach (var s in c.List)
                    {
                        var stn = new TreeNode();
                        stn.Name = s.Id.ToString();
                        stn.Text = s.Title;
                        ctn.Nodes.Add(stn);
                    }
                    ptn.Nodes.Add(ctn);
                }
                root.Add(ptn);
            }
            return root;
        }

        private void I_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (treeView1.SelectedNode == null) { return; }
            if (string.IsNullOrWhiteSpace(treeView1.SelectedNode.Name)) { return; }
            var id = new Guid(treeView1.SelectedNode.Name);

            foreach (var p in _projectList)
            {
                if (!p.HasTestStep(id)) { continue; }
                testStepTextBox.Lines = p.SelectTestStep(id).Detail.ToArray();
                return;
            }

        }

        private void changeDirectionButton_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode == null) { return; }
            if (string.IsNullOrWhiteSpace(treeView1.SelectedNode.Name)) { return; }
            ToolStripItem item = (ToolStripItem)sender;

            var id = new Guid(treeView1.SelectedNode.Name);

            var selectedProjectName = "";
            var selectedCaseName = "";
            foreach (var p in _projectList)
            {
                if (!p.HasTestCase(id)) { continue; }
                selectedProjectName = p.Name;
                selectedCaseName = p.SelectTestCase(id).Title;
                break;
            }

            using (var fm = new AddStepForm())
            {
                fm.TestProjectName = selectedProjectName;
                fm.TestCaseName = selectedCaseName;
                fm.ShowDialog();
            }
            LoadTestProjects();
        }
    }
}
