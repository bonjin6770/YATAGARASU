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
    public partial class SelectProjectForm : Form
    {
        public string SelectedProject { get; private set; }

        public SelectProjectForm()
        {
            InitializeComponent();
        }

        private void SelectProject_Shown(object sender, EventArgs e)
        {
            var projectList = Registory.TestProjectRepogitory.SelectAll();
            projectListBox.Items.AddRange(projectList.Select(D => D.Name).ToArray());
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            SelectProject();
        }

        private void projectListBox_DoubleClick(object sender, EventArgs e)
        {
            SelectProject();
        }

        private void SelectProject()
        {
            if (projectListBox.SelectedItem != null)
            {
                SelectedProject = projectListBox.SelectedItem.ToString();
            }
            Close();
        }
    }
}
