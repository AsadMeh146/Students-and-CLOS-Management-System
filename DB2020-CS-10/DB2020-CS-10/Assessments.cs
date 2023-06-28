using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DB2020_CS_10
{
    public partial class Assessments : Form
    {
        string get_date = "";
        Dictionary<string, string> Rubric_Id = null;
        Dictionary<string, string> Assessment_Id = null;
        Dictionary<string, string> AssessmentMarks_Id = null;
        Dictionary<string, string> AssessmentCompMarks_Id = null;
        int get_assess_marks = 0;
        int get_assess_comp_marks = 0;
        public Assessments()
        {
            InitializeComponent();
        }

        private void add_clo_btn_Click(object sender, EventArgs e)
        {
            Regex nonNumericRegex = new Regex(@"[1-9]\d*");
            if (assess_title.Text == " " || !(nonNumericRegex.IsMatch(assess_marks.Text)) || !(nonNumericRegex.IsMatch(assess_weightage.Text)))
            {
                MessageBox.Show("Please fill valid fields");
            }
            else
            {
                get_date = assess_date.Value.Year.ToString() + "-" + assess_date.Value.Month.ToString() + "-" + assess_date.Value.Day.ToString();
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Insert into Assessment values(@Title,CAST(@DateCreated AS datetime),@TotalMarks,@TotalWeightage)", con);
                cmd.Parameters.AddWithValue("@Title", assess_title.Text);
                cmd.Parameters.AddWithValue("@DateCreated", get_date);
                cmd.Parameters.AddWithValue("@TotalMarks", assess_marks.Text);
                cmd.Parameters.AddWithValue("@TotalWeightage", assess_weightage.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Added");
            }
            
        }

        private void Assessments_Load(object sender, EventArgs e)
        {
            Rubric_Id = new Dictionary<string, string>();
            Assessment_Id = new Dictionary<string, string>();
            AssessmentMarks_Id = new Dictionary<string, string>();
            AssessmentCompMarks_Id = new Dictionary<string, string>();

            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Rubric", con);
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Assessment", con);
            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
         

            foreach (DataRow rows in dt.Rows)
            {
                Rubric_Id.Add(rows["Id"].ToString(), rows["Details"].ToString());
            }
            foreach (DataRow rows in dt1.Rows)
            {
                Assessment_Id.Add(rows["Id"].ToString(), rows["Title"].ToString());
            }
            

            foreach (string value in Rubric_Id.Values)
            {
                rubricID_Box.Items.Add(value);
            }
            
            foreach (string value in Assessment_Id.Values)
            {
                assess_Id_Box.Items.Add(value);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AssessmentMarks_Id = new Dictionary<string, string>();
            AssessmentCompMarks_Id = new Dictionary<string, string>();
            Regex nonNumericRegex = new Regex(@"[1-9]\d*");
            if(assess_comp_name.Text == " " || rubricID_Box.Text == "--select" || assess_Id_Box.Text == "--select" || !(nonNumericRegex.IsMatch(assess_comp_marks.Text)))
            {
                MessageBox.Show("Please fill valid fields");
            }
            else
            {
                int selectedIndex1 = rubricID_Box.SelectedIndex;
                int get_rubricid = int.Parse(Rubric_Id.Keys.ElementAt(selectedIndex1));
                int selectedIndex2 = assess_Id_Box.SelectedIndex;
                int get_asses_id = int.Parse(Assessment_Id.Keys.ElementAt(selectedIndex2));
                get_date = assess_comp_datecreated.Value.Year.ToString() + "-" + assess_comp_datecreated.Value.Month.ToString() + "-" + assess_comp_datecreated.Value.Day.ToString();
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd2 = new SqlCommand("SELECT TotalMarks FROM Assessment WHERE Id = @Id", con);
                cmd2.Parameters.AddWithValue("@Id", get_asses_id);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                foreach (DataRow row1 in dt2.Rows)
                {
                    AssessmentMarks_Id.Add(row1["TotalMarks"].ToString(), row1["TotalMarks"].ToString());
                }
                SqlCommand cmd3 = new SqlCommand("SELECT SUM(TotalMarks) AS TotalMarks FROM AssessmentComponent WHERE AssessmentId = @Id", con);
                cmd3.Parameters.AddWithValue("@Id", get_asses_id);
                SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
                DataTable dt3 = new DataTable();
                da3.Fill(dt3);

                foreach (DataRow row1 in dt3.Rows)
                {
                    AssessmentCompMarks_Id.Add(row1["TotalMarks"].ToString(), row1["TotalMarks"].ToString());
                }
                foreach (KeyValuePair<string, string> rows in AssessmentMarks_Id)
                {
                    get_assess_marks = int.Parse(rows.Key);
                }
                foreach (KeyValuePair<string, string> rows1 in AssessmentCompMarks_Id)
                {
                    if (rows1.Value == "" || rows1.Value == "NULL" || rows1.Value == "null")
                    {
                        get_assess_comp_marks = 0;
                    }
                    else
                    {
                        get_assess_comp_marks = int.Parse(rows1.Key);
                    }
                }
                if ((get_assess_comp_marks + int.Parse(assess_comp_marks.Text)) > get_assess_marks)
                {
                    int difference = ((get_assess_comp_marks + int.Parse(assess_comp_marks.Text)) - get_assess_marks);
                    MessageBox.Show("You cannot add more marks as u have exceed " + difference.ToString() + " in selected asssessment");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("Insert into AssessmentComponent values(@Name,@RubricId,@TotalMarks,CAST(@DateCreated AS datetime),CAST(@DateUpdated AS datetime),@AssessmentId)", con);
                    cmd.Parameters.AddWithValue("@Name", assess_comp_name.Text);
                    cmd.Parameters.AddWithValue("@RubricId", get_rubricid);
                    cmd.Parameters.AddWithValue("@TotalMarks", int.Parse(assess_comp_marks.Text));
                    cmd.Parameters.AddWithValue("@DateCreated", get_date);
                    cmd.Parameters.AddWithValue("@DateUpdated", get_date);
                    cmd.Parameters.AddWithValue("@AssessmentId", get_asses_id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Added");
                    rubricID_Box.Text = "--select";
                    assess_Id_Box.Text = "--select";
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.assessment_panel.Controls.Clear();
            Assessment_Info ass_info_up_Form = new Assessment_Info() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            ass_info_up_Form.FormBorderStyle = FormBorderStyle.None;
            this.assessment_panel.Controls.Add(ass_info_up_Form);
            ass_info_up_Form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.assessment_panel.Controls.Clear();
            Assessment_Component_Info ass_comp_info_up_Form = new Assessment_Component_Info() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            ass_comp_info_up_Form.FormBorderStyle = FormBorderStyle.None;
            this.assessment_panel.Controls.Add(ass_comp_info_up_Form);
            ass_comp_info_up_Form.Show();
        }
    }
}
