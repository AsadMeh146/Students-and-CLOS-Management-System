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
    public partial class Rubric_Info_Update : Form
    {
        Dictionary<string, string> getRubricLevelId = null;
        Dictionary<string, string> getAssessComponentId = null;
       
        public Rubric_Info_Update()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT Rubric.Id,Rubric.Details,Clo.Name FROM Clo,Rubric WHERE Clo.Id = Rubric.CloId", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            rubric_GridView.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rowIndex = rubric_GridView.CurrentCell.RowIndex;
            int colIndex = rubric_GridView.CurrentCell.ColumnIndex;
            string stu_id_text = rubric_GridView.Rows[rowIndex].Cells[0].Value.ToString();
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd3 = new SqlCommand("SELECT Id FROM AssessmentComponent WHERE RubricId = @Id", con);
            cmd3.Parameters.AddWithValue("@Id", stu_id_text);
            SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            foreach (DataRow row in dt3.Rows)
            {
                getAssessComponentId.Add(row["Id"].ToString(), row["Id"].ToString());
            }
            foreach (KeyValuePair<string, string> keys in getAssessComponentId)
            {
                int get_AssessId = int.Parse(keys.Key);
                SqlCommand cmd2 = new SqlCommand("Delete FROM StudentResult WHERE AssessmentComponentId = @Id ", con);
                cmd2.Parameters.AddWithValue("@Id", get_AssessId);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
            }
            
            SqlCommand cmd1 = new SqlCommand("Delete from Rubric WHERE Id = @Id ; Delete FROM RubricLevel WHERE RubricId = @Id ; Delete FROM AssessmentComponent WHERE RubricId = @Id", con);
            cmd1.Parameters.AddWithValue("@Id", stu_id_text);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            MessageBox.Show("Deleted Successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            int rowIndex = rubric_GridView.CurrentCell.RowIndex;
            int colIndex = rubric_GridView.CurrentCell.ColumnIndex;
            string updateValue = rubric_GridView.Rows[rowIndex].Cells[colIndex].Value.ToString();
            string stu_id = rubric_GridView.Rows[rowIndex].Cells[0].Value.ToString();

            string columnHeader = rubric_GridView.Columns[colIndex].HeaderText;
            if (columnHeader == "Name")
            {
                MessageBox.Show("Cannot Change Clo Name");
            }
            else
            {
                string query = columnHeader + " =@" + columnHeader;
                SqlCommand cmd = new SqlCommand("Update Rubric SET " + query + " WHERE Id = @Id", con);
                cmd.Parameters.AddWithValue("@" + columnHeader, updateValue);
                cmd.Parameters.AddWithValue("@Id", stu_id);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                MessageBox.Show("Successfully Updated");
                rubric_GridView.DataSource = dt;
            }
        }

        private void Rubric_Info_Update_Load(object sender, EventArgs e)
        {
            getRubricLevelId = new Dictionary<string, string>();
            getAssessComponentId = new Dictionary<string, string>();
        }
    }
}
