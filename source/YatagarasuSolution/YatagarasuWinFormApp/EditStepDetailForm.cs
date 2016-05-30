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
    public partial class EditStepDetailForm : Form
    {
        public string TestProjectName { get; set; }
        public string TestCaseName { get; set; }
        public string TestStep { get; set; }
        private TestProject _project;
        private TestStep _step;
        public EditStepDetailForm()
        {
            InitializeComponent();
        }

        private void ShowStepDetailForm_Shown(object sender, EventArgs e)
        {
            _project = Registory.TestProjectRepogitory.SelectByName(TestProjectName);
            //testCaseListBox.Items.AddRange(projectList.SelectMany(D => D.List).Select(d => d.Title).ToArray());
            _step = _project.List.Where(d => d.Title == TestCaseName).First().List.Where(d => d.Title == TestStep).First();
            titleTextBox.Text = _step.Title;
            detailTextBox.Lines = _step.Detail.ToArray();
            createdDateTimePicker.Value = _step.Created;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

            _step.Title = titleTextBox.Text;
            _step.Detail = detailTextBox.Lines.ToList();
            _step.Created = createdDateTimePicker.Value;

            Registory.TestProjectRepogitory.Save(_project);
            Close();
        }
    }
}
