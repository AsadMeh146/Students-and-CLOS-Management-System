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
    public partial class Rubric_Level_Info : Form
    {
        bool isFound = false;
        Dictionary<string, string> check_rubricLevel_ID = null;
        public Rubric_Level_Info()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            int rowIndex = rubricLevel_Grid.CurrentCell.RowIndex;
            int colIndex = rubricLevel_Grid.CurrentCell.ColumnIndex;
            string updateValue = rubricLevel_Grid.Rows[rowIndex].Cells[colIndex].Value.ToString();
            string stu_id = rubricLevel_Grid.Rows[rowIndex].Cells[1].Value.ToString();
            string stu_id2 = rubricLevel_Grid.Rows[rowIndex].Cells[0].Value.ToString();
            string stu_id1 = rubricLevel_Grid.Rows[rowIndex].Cells[4].Value.ToString();
            string columnHeader = rubricLevel_Grid.Columns[colIndex].HeaderText;
            if (columnHeader == "RubricDetails" || columnHeader == "Id")
            {
                MessageBox.Show("Wrong item selected.");
            }
            else
            {
                SqlCommand cmd1 = new SqlCommand("SELECT Id,MeasurementLevel FROM RubricLevel WHERE RubricId = @Id", con);
                cmd1.Parameters.AddWithValue("@Id", stu_id2);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                foreach (DataRow rows in dt1.Rows)
                {
                    check_rubricLevel_ID.Add(rows["Id"].ToString(), rows["MeasurementLevel"].ToString());
                }

                foreach (KeyValuePair<string, string> getKey in check_rubricLevel_ID)
                {
                    int value = int.Parse(getKey.Value);
                    if (value == int.Parse(stu_id1))
                    {
                        isFound = true;
                    }
                }
                if (isFound == true)
                {
                    MessageBox.Show("Rubric with same level exists");
                }
                else
                {
                    string query = columnHeader + " =@" + columnHeader;
                    SqlCommand cmd = new SqlCommand("Update RubricLevel SET " + query + " WHERE Id = @Id2", con);
                    cmd.Parameters.AddWithValue("@" + columnHeader, updateValue);
                    cmd.Parameters.AddWithValue("@Id2", stu_id);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    MessageBox.Show("Successfully Updated");
                    rubricLevel_Grid.DataSource = dt;
                }
                
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT Rubric.Id AS RubricId,RubricLevel.Id,Rubric.Details AS RubricDetails,RubricLevel.Details,RubricLevel.MeasurementLevel FROM Rubric, RubricLevel WHERE Rubric.Id = RubricLevel.RubricId", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            rubricLevel_Grid.DataSource = dt;
            rubricLevel_Grid.Columns["RubricId"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rowIndex = rubricLevel_Grid.CurrentCell.RowIndex;
            int colIndex = rubricLevel_Grid.CurrentCell.ColumnIndex;
            string stu_id_text = rubricLevel_Grid.Rows[rowIndex].Cells[1].Value.ToString();
            var con = Configuration.getInstance().getConnection();
            
            SqlCommand cmd1 = new SqlCommand("Delete from StudentResult WHERE RubricMeasurementId = @Id;Delete from RubricLevel WHERE Id = @Id", con);
            cmd1.Parameters.AddWithValue("@Id", stu_id_text);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            MessageBox.Show("Deleted Successfully");
        }

        private void Rubric_Level_Info_Load(object sender, EventArgs e)
        {
            check_rubricLevel_ID = new Dictionary<string, string>();
        }
    }
}
