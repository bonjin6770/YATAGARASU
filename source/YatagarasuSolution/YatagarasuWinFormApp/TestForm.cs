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

            // 初期選択
            if (treeView1.Nodes.Count == 0)
            {
                return;
            }
            treeView1.SelectedNode = treeView1.Nodes[0];
            treeView1.Select();

        }

        /// <summary>
        /// 
        /// </summary>
        private void LoadTestProjects()
        {
            var contextmenustrip = new ContextMenuStrip();
            var addNewProjectItem = new ToolStripMenuItem();
            addNewProjectItem.Text = "add project step";
            addNewProjectItem.Click += AddNewProjectEvent;
            contextmenustrip.Items.Add(addNewProjectItem);
            treeView1.ContextMenuStrip = contextmenustrip;

            treeView1.Nodes.Clear();

            _projectList = YatagarasuLibrary.Registory.TestProjectRepogitory.SelectAll();
            foreach (var p in _projectList)
            {
                testProjectComboBox.Items.Add(p);

            }
            testProjectComboBox.SelectedIndex = 0;

            treeView1.Nodes.AddRange(ProjectToTreeNode().ToArray());

        }

        private void AddProject(TreeNode n)
        {
            treeView1.Nodes.Add(n);
        }

        private void AddCase(TreeNode n, TreeNode testProject)
        {

        }

        private void AddStep(TreeNode n)
        {

        }

        private TreeNode ProjectToTreeNode(TestProject p)
        {
            var ptn = new TreeNode();
            var contextmenustripToP = new ContextMenuStrip();
            var addNewCaseItem = new ToolStripMenuItem();
            addNewCaseItem.Text = "add new case";
            addNewCaseItem.Click += AddNewCaseEvent;
            contextmenustripToP.Items.Add(addNewCaseItem);
            ptn.ContextMenuStrip = contextmenustripToP;

            ptn.Name = p.Id.ToString();
            ptn.Text = p.Name;
            return ptn;
        }

        private TreeNode CaseToTreeNode(TestCase c)
        {
            var ctn = new TreeNode();
            var contextmenustrip = new ContextMenuStrip();
            var addNewStepItem = new ToolStripMenuItem();
            addNewStepItem.Text = "add new step";
            addNewStepItem.Click += AddNewStepEvent;
            contextmenustrip.Items.Add(addNewStepItem);
            ctn.ContextMenuStrip = contextmenustrip;

            ctn.Name = c.Id.ToString();
            ctn.Text = c.Title;
            return ctn;
        }

        private TreeNode StepToTreeNode(TestStep s)
        {
            var stn = new TreeNode();
            stn.Name = s.Id.ToString();
            stn.Text = s.Title;
            return stn;
        }

        private List<TreeNode> ProjectToTreeNode()
        {
            var root = new List<TreeNode>();
            foreach (var p in _projectList)
            {
                var ptn = ProjectToTreeNode(p);
                foreach (var c in p.List)
                {
                    var ctn = CaseToTreeNode(c);
                    foreach (var s in c.List)
                    {
                        var stn = StepToTreeNode(s);
                        ctn.Nodes.Add(stn);
                    }
                    ptn.Nodes.Add(ctn);
                }
                root.Add(ptn);
            }
            return root;
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



        private TestProject GetSelectedProject()
        {
            var id = GetSelectedId();

            foreach (var p in _projectList)
            {
                if (!(p.Id == id)) { continue; }
                return p;
            }

            foreach (var p in _projectList)
            {
                if (!p.HasTestCase(id)) { continue; }
                return p;
            }

            throw new IndexOutOfRangeException();
        }

        private TreeNode GetSelectedProjectNode()
        {
            var selectedProject = GetSelectedProject();
            foreach (TreeNode n in treeView1.Nodes)
            {

                if (n.Name == selectedProject.Id.ToString()) { return n; }
            }

            throw new IndexOutOfRangeException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Guid GetSelectedId()
        {
            if (treeView1.SelectedNode == null) { throw new IndexOutOfRangeException(); }
            if (string.IsNullOrWhiteSpace(treeView1.SelectedNode.Name)) { throw new IndexOutOfRangeException(); }

            return new Guid(treeView1.SelectedNode.Name);
        }

        private string GetSelectedCaseName()
        {
            var id = GetSelectedId();

            foreach (var p in _projectList)
            {
                if (!p.HasTestCase(id)) { continue; }
                return p.SelectTestCase(id).Title;
            }

            throw new IndexOutOfRangeException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNewProjectEvent(object sender, EventArgs e)
        {
            using (var fm = new MakeTestProjectForm())
            {
                fm.ShowDialog();
                AddProject(ProjectToTreeNode(fm.NewProject));
            }
        }

        private void AddNewCaseEvent(object sender, EventArgs e)
        {
            var selectedProject = GetSelectedProjectNode();
            using (var fm = new AddTestCaseForm())
            {
                fm.TestProjectName = selectedProject.Text;
                fm.ShowDialog();
                AddCase(CaseToTreeNode(fm.NewTestCase), selectedProject);
            }

            LoadTestProjects();

        }

        private void AddNewStepEvent(object sender, EventArgs e)
        {
            var selectedProjectName = GetSelectedProject().Name;
            var selectedCaseName = GetSelectedCaseName();

            using (var fm = new AddStepForm())
            {
                fm.TestProjectName = selectedProjectName;
                fm.TestCaseName = selectedCaseName;
                fm.ShowDialog();
            }
            LoadTestProjects();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // save
        }
    }
}
