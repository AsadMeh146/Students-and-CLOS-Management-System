using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB2020_CS_10
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void manage_stu_btn_Click_1(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();
            Students studentForm = new Students() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            studentForm.FormBorderStyle = FormBorderStyle.None;
            this.mainPanel.Controls.Add(studentForm);
            studentForm.Show();
        }

        private void manage_clo_btn_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();
            CLOS cloForm = new CLOS() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            cloForm.FormBorderStyle = FormBorderStyle.None;
            this.mainPanel.Controls.Add(cloForm);
            cloForm.Show();
        }

        private void manage_rub_btn_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();
            Rubric rubricForm = new Rubric() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            rubricForm.FormBorderStyle = FormBorderStyle.None;
            this.mainPanel.Controls.Add(rubricForm);
            rubricForm.Show();
        }

        private void manage_asst_btn_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();
            Assessments assessmentForm = new Assessments() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            assessmentForm.FormBorderStyle = FormBorderStyle.None;
            this.mainPanel.Controls.Add(assessmentForm);
            assessmentForm.Show();
        }

        private void manage_eva_btn_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();
            Reports reportForm = new Reports() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            reportForm.FormBorderStyle = FormBorderStyle.None;
            this.mainPanel.Controls.Add(reportForm);
            reportForm.Show();
        }
    }
}
