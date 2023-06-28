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
    public partial class Student_Result_Info : Form
    {
       
        public Student_Result_Info()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT AssessmentComponent.Id AS AssessmentComponentId,StudentResult.StudentId,Student.RegistrationNumber,AssessmentComponent.Name AS AssessmentComponentName,RubricLevel.Details AS RubricDetails,StudentResult.EvaluationDate FROM StudentResult, AssessmentComponent, RubricLevel, Student WHERE StudentResult.RubricMeasurementId = RubricLevel.Id AND StudentResult.AssessmentComponentId = AssessmentComponent.Id AND Student.Id = StudentResult.StudentId", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            stn_res_Grid.DataSource = dt;
            stn_res_Grid.Columns["AssessmentComponentId"].Visible = false;
            stn_res_Grid.Columns["StudentId"].Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowIndex = stn_res_Grid.CurrentCell.RowIndex;
            int colIndex = stn_res_Grid.CurrentCell.ColumnIndex;
            string stu_id_text = stn_res_Grid.Rows[rowIndex].Cells[0].Value.ToString();
            string stu_id_text1 = stn_res_Grid.Rows[rowIndex].Cells[1].Value.ToString();
            var con = Configuration.getInstance().getConnection();
            //SqlCommand cmd1 = new SqlCommand("SELECT AssessmentComponentId FROM StudentResult WHERE StudentId = @Id AND AssessmentComponentId = @Id2", con);
            //cmd1.Parameters.AddWithValue("@Id", stu_id_text);
            //cmd1.Parameters.AddWithValue("@Id2", stu_id_text1);
            //SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            //DataTable dt1 = new DataTable();
            //da1.Fill(dt1);
            //foreach (DataRow row in dt1.Rows)
            //{
            //    getAssessId.Add(row["AssessmentComponentId"].ToString(), row["AssessmentComponentId"].ToString());
            //}
            //foreach (KeyValuePair<string, string> getKey in getAssessId)
            //{
            //    int value = int.Parse(getKey.Value);
            //    if (value == int.Parse(stu_id_text))
            //    {
            //        isFound = true;
            //    }
                
            //}
            //if (isFound == true)
            //{
            //    MessageBox.Show("Assessment for that component already exists");
            //}
            //else
            //{
            
            //}
            SqlCommand cmd2 = new SqlCommand("Delete FROM StudentResult WHERE StudentId = @Id AND AssessmentComponentId = @Id2", con);
            cmd2.Parameters.AddWithValue("@Id", stu_id_text);
            cmd2.Parameters.AddWithValue("@Id2", stu_id_text1);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            MessageBox.Show("Deleted Successfully");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            int rowIndex = stn_res_Grid.CurrentCell.RowIndex;
            int colIndex = stn_res_Grid.CurrentCell.ColumnIndex;
            string updateValue = stn_res_Grid.Rows[rowIndex].Cells[colIndex].Value.ToString();
            string stu_id = stn_res_Grid.Rows[rowIndex].Cells[0].Value.ToString();
            string columnHeader = stn_res_Grid.Columns[colIndex].HeaderText;
            if (columnHeader == "RegistrationNumber" || columnHeader == "AssessmentComponentName" || columnHeader == "RubricDetails")
            {
                MessageBox.Show("Wrong item selected");
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
                stn_res_Grid.DataSource = dt;
            }
        }

        private void Student_Result_Info_Load(object sender, EventArgs e)
        {
            //getAssessId = new Dictionary<string, string>();
        }
    }
}
