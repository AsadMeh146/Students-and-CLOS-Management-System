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
    public partial class Assessment_Info : Form
    {
        Dictionary<string, string> getAssessId = new Dictionary<string, string>();
        public Assessment_Info()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Assessment", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            assess_Grid.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rowIndex = assess_Grid.CurrentCell.RowIndex;
            int colIndex = assess_Grid.CurrentCell.ColumnIndex;
            string stu_id_text = assess_Grid.Rows[rowIndex].Cells[0].Value.ToString();
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd2 = new SqlCommand("SELECT Id FROM AssessmentComponent WHERE AssessmentId = @Id", con);
            cmd2.Parameters.AddWithValue("@Id", stu_id_text);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            foreach (DataRow row in dt2.Rows)
            {
                getAssessId.Add(row["Id"].ToString(), row["Id"].ToString());
            }
            foreach (KeyValuePair<string, string> getKeys in getAssessId)
            {
                int getAssessId = int.Parse(getKeys.Key);
                SqlCommand cmd3 = new SqlCommand("Delete FROM StudentResult WHERE AssessmentComponentId = @Id", con);
                cmd3.Parameters.AddWithValue("@Id", getAssessId);
                SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
                DataTable dt3 = new DataTable();
                da3.Fill(dt3);
            }

            SqlCommand cmd1 = new SqlCommand("Delete FROM AssessmentComponent WHERE AssessmentId = @Id;Delete FROM Assessment WHERE Id = @Id", con);
            cmd1.Parameters.AddWithValue("@Id", stu_id_text);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            MessageBox.Show("Deleted Successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            int rowIndex = assess_Grid.CurrentCell.RowIndex;
            int colIndex = assess_Grid.CurrentCell.ColumnIndex;
            string updateValue = assess_Grid.Rows[rowIndex].Cells[colIndex].Value.ToString();
            string stu_id = assess_Grid.Rows[rowIndex].Cells[0].Value.ToString();
            string columnHeader = assess_Grid.Columns[colIndex].HeaderText;
            if (columnHeader == "DateCreated" || columnHeader == "Id")
            {
                MessageBox.Show("Wrong item selected");
            }
            else
            {
                string query = columnHeader + " =@" + columnHeader;
                string getDate = DateTime.Now.ToString("yyyy/MM/dd");
                SqlCommand cmd = new SqlCommand("Update Assessment SET " + query + " WHERE Id = @Id", con);
                cmd.Parameters.AddWithValue("@" + columnHeader, updateValue);
                cmd.Parameters.AddWithValue("@Id", stu_id);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                MessageBox.Show("Successfully Updated");
                assess_Grid.DataSource = dt;
            }
        }
    }
}

