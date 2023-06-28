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

namespace DB2020_CS_10
{
    public partial class Assessment_Component_Info : Form
    {
        Dictionary<string, string> getAssessMarks = null;
        Dictionary<string, string> getAssessCompMarks = null;
        Dictionary<string, string> getSelectedAssessMarks = null;
        int get_assess_marks = 0;
        int get_selected_assess_marks = 0;
        int get_assess_comp_marks = 0;
        public Assessment_Component_Info()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT AssessmentComponent.Id AS Id,AssessmentComponent.AssessmentId,AssessmentComponent.Name AS Name,Rubric.Details AS RubricDetails,AssessmentComponent.TotalMarks AS TotalMarks,AssessmentComponent.DateCreated,AssessmentComponent.DateUpdated,Assessment.Title AS AssessmentTitle FROM Rubric, AssessmentComponent, Assessment WHERE Rubric.Id = AssessmentComponent.RubricId AND AssessmentComponent.AssessmentId = Assessment.Id ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            assess_comp_Grid.DataSource = dt;
            assess_comp_Grid.Columns["AssessmentId"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rowIndex = assess_comp_Grid.CurrentCell.RowIndex;
            int colIndex = assess_comp_Grid.CurrentCell.ColumnIndex;
            string stu_id_text = assess_comp_Grid.Rows[rowIndex].Cells[0].Value.ToString();
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd1 = new SqlCommand("Delete FROM AssessmentComponent WHERE Id = @Id ; Delete FROM StudentResult WHERE AssessmentComponentId = @Id", con);
            cmd1.Parameters.AddWithValue("@Id", stu_id_text);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            MessageBox.Show("Deleted Successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            int rowIndex = assess_comp_Grid.CurrentCell.RowIndex;
            int colIndex = assess_comp_Grid.CurrentCell.ColumnIndex;
            string updateValue = assess_comp_Grid.Rows[rowIndex].Cells[colIndex].Value.ToString();
            string stu_id = assess_comp_Grid.Rows[rowIndex].Cells[0].Value.ToString();
            string stu_id1 = assess_comp_Grid.Rows[rowIndex].Cells[1].Value.ToString();
            string columnHeader = assess_comp_Grid.Columns[colIndex].HeaderText;
            if (columnHeader == "DateCreated" || columnHeader == "Id" || columnHeader == "DateUpdated" || columnHeader == "RubricDetails" || columnHeader == "AssessmentTitle")
            {
                MessageBox.Show("Wrong item selected");
            }
            else
            {
                SqlCommand cmd4 = new SqlCommand("SELECT TotalMarks FROM AssessmentComponent WHERE Id = @Id ", con);
                cmd4.Parameters.AddWithValue("@Id", stu_id);
                SqlDataAdapter da4 = new SqlDataAdapter(cmd4);
                DataTable dt4 = new DataTable();
                da4.Fill(dt4);
                foreach (DataRow getrow in dt4.Rows)
                {
                    getSelectedAssessMarks.Add(getrow["TotalMarks"].ToString(), getrow["TotalMarks"].ToString());
                }
                SqlCommand cmd2 = new SqlCommand("SELECT TotalMarks FROM Assessment WHERE Id = @Id ", con);
                cmd2.Parameters.AddWithValue("@Id", stu_id1);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                foreach (DataRow row in dt2.Rows)
                {
                    getAssessMarks.Add(row["TotalMarks"].ToString(), row["TotalMarks"].ToString());
                }
                SqlCommand cmd3 = new SqlCommand("SELECT SUM(TotalMarks) AS Marks FROM AssessmentComponent WHERE Id = @Id ", con);
                cmd3.Parameters.AddWithValue("@Id", stu_id);
                SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
                DataTable dt3 = new DataTable();
                da3.Fill(dt3);
                foreach (DataRow rows in dt3.Rows)
                {
                    getAssessCompMarks.Add(rows["Marks"].ToString(), rows["Marks"].ToString());
                
                }
                foreach (KeyValuePair<string, string> rows in getAssessMarks)
                {
                    get_assess_marks = int.Parse(rows.Key);
                }
                foreach (KeyValuePair<string, string> rows1 in getAssessCompMarks)
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
                foreach (KeyValuePair<string, string> getMarks in getSelectedAssessMarks)
                {
                    get_selected_assess_marks = int.Parse(getMarks.Value);
                }
                if (((get_assess_comp_marks + int.Parse(updateValue)) - get_selected_assess_marks) > get_assess_marks)
                {
                    int difference = (((get_assess_comp_marks + int.Parse(updateValue)) - get_selected_assess_marks) - get_assess_marks);
                    MessageBox.Show("You cannot add more marks as u have exceed " + difference.ToString() + " in selected asssessment");
                }
                else
                {
                    string query = columnHeader + " =@" + columnHeader;
                    string getDate = DateTime.Now.ToString("yyyy/MM/dd");
                    SqlCommand cmd = new SqlCommand("Update AssessmentComponent SET " + query + " , DateUpdated = @Time WHERE Id = @Id", con);
                    cmd.Parameters.AddWithValue("@" + columnHeader, updateValue);
                    cmd.Parameters.AddWithValue("@Id", stu_id);
                    cmd.Parameters.AddWithValue("@Time", getDate);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    MessageBox.Show("Successfully Updated");
                    assess_comp_Grid.DataSource = dt;
                }
                ///////////////////
            }
        }

        private void Assessment_Component_Info_Load(object sender, EventArgs e)
        {
            getAssessMarks = new Dictionary<string, string>();
            getAssessCompMarks = new Dictionary<string, string>();
            getSelectedAssessMarks = new Dictionary<string, string>();
        }
    }
}
