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
    public partial class ShowTestCaseForm : Form
    {
        public string SelectedProject { get; set; }
        public string SelectedCase { get; set; }
        public ShowTestCaseForm()
        {
            InitializeComponent();
        }

        private void ShowTestCaseForm_Shown(object sender, EventArgs e)
        {
            var project = Registory.TestProjectRepogitory.SelectByName(SelectedProject);
            //testCaseListBox.Items.AddRange(projectList.SelectMany(D => D.List).Select(d => d.Details).ToArray());
            testCaseListBox.Items.AddRange(project.List.Select(d => d.Title).ToArray());
        }

        private void testCaseListBox_DoubleClick(object sender, EventArgs e)
        {
            SelectCase();
        }

        private void SelectCase()
        {
            if (testCaseListBox.SelectedItem != null)
            {
                SelectedCase = testCaseListBox.SelectedItem.ToString();
            }
            Close();
        }
    }
}
